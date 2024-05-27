using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


//TODO 応答なし、進捗メーター

namespace ImageBatchMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ドラッグアンドドロップのイベントハンドラを設定
            this.textBoxFolderPath.AllowDrop = true;
            this.textBoxFolderPath.DragEnter += textBoxFolderPath_DragEnter;
            this.textBoxFolderPath.DragDrop += textBoxFolderPath_DragDrop;

            this.textBoxFolderPathSave.AllowDrop = true;
            this.textBoxFolderPathSave.DragEnter += textBoxFolderPathSave_DragEnter;
            this.textBoxFolderPathSave.DragDrop += textBoxFolderPathSave_DragDrop;

            this.textBoxFolderPath.TextChanged += textBox_TextChanged;
            this.textBoxFolderPathSave.TextChanged += textBox_TextChanged;
            this.textBoxHowManyFiles.TextChanged += textBox_TextChanged;

            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            labelStatus.Text = "";
        }

        

        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            // Source and target folder paths from the text boxes
            string sourceFolderPath = textBoxFolderPath.Text;
            string baseTargetFolderPath = textBoxFolderPathSave.Text;

            // Set the status message
            labelStatus.Text = "ファイル確認中...";

            // Wait a bit to allow the status message to be displayed
            await Task.Delay(100);

            // Check if the target folder is empty
            if (Directory.GetFiles(baseTargetFolderPath).Length > 0 || Directory.GetDirectories(baseTargetFolderPath).Length > 0)
            {
                MessageBox.Show("Target folder must be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            // File count limit from the text box
            int fileCountLimit;
            if (!int.TryParse(textBoxHowManyFiles.Text, out fileCountLimit))
            {
                // Show an error message if the input is not an integer
                MessageBox.Show("Invalid input for file count. Please enter an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get all image files recursively from the source folder
            string[] imageFiles = Directory.GetFiles(sourceFolderPath, "*", SearchOption.AllDirectories)
                                          .Where(file => IsImageFile(file))
                                          .ToArray();

            // Reset the status message
            labelStatus.Text = "";

            // Counters for files and folders
            int fileCount = 0;
            int folderCount = 1;

            // Create the first target folder
            string targetFolderPath = Path.Combine(baseTargetFolderPath, $"Folder{folderCount}");
            Directory.CreateDirectory(targetFolderPath);

            // ProgressBarを表示
            progressBar1.Visible = true;


            // 進捗バーの最大値を設定
            progressBar1.Maximum = imageFiles.Length;
            progressBar1.Value = 0;

            // 別スレッドでファイルの移動を行う
            await Task.Run(() =>
                {
                    // Move the image files to the target folders
                    foreach (string file in imageFiles)
                    {
                        // Move the file to the target folder
                        string targetFilePath = Path.Combine(targetFolderPath, Path.GetFileName(file));
                        File.Move(file, targetFilePath);

                        // Increase the file count
                        fileCount++;

                        // If the file count has reached the limit, create a new folder
                        if (fileCount % fileCountLimit == 0)
                        {
                            folderCount++;
                            targetFolderPath = Path.Combine(baseTargetFolderPath, $"Folder{folderCount}");
                            Directory.CreateDirectory(targetFolderPath);
                        }

                        // UI スレッドに進捗バーの更新を指示
                        this.Invoke(new Action(() =>
                        {
                            progressBar1.Value++;
                        }));
                    }
                });

            // Display a message box when the operation is completed
            MessageBox.Show("Images have been consolidated into multiple folders and original files deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return (extension == ".jpg" || extension == ".png" || extension == ".bmp" || extension == ".gif");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFolderPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void buttonBrowseSave_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFolderPathSave.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        // ファイルやフォルダがテキストボックス上にドラッグされたときのイベントハンドラ
        private void textBoxFolderPath_DragEnter(object sender, DragEventArgs e)
        {
            // ドラッグされたデータがファイルやフォルダである場合のみ、ドロップを許可する
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // ファイルやフォルダがテキストボックスにドロップされたときのイベントハンドラ
        private void textBoxFolderPath_DragDrop(object sender, DragEventArgs e)
        {
            // ドロップされたファイルやフォルダのパスを取得
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (paths.Length > 0)
            {
                // 最初のファイルやフォルダのパスをテキストボックスに設定
                textBoxFolderPath.Text = paths[0];
            }
        }

        // Drag and drop event handlers for textBoxFolderPathSave
        private void textBoxFolderPathSave_DragEnter(object sender, DragEventArgs e)
        {
            // Only allow a drop if a file or folder is being dragged
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBoxFolderPathSave_DragDrop(object sender, DragEventArgs e)
        {
            // Get the paths of the dropped files and folders
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (paths.Length > 0)
            {
                // Set the text box to the path of the first file or folder
                textBoxFolderPathSave.Text = paths[0];
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // Check if all textboxes have content and if textBoxHowManyFiles contains a valid integer
            ButtonStart.Enabled = !string.IsNullOrWhiteSpace(textBoxFolderPath.Text)
                && !string.IsNullOrWhiteSpace(textBoxFolderPathSave.Text)
                && int.TryParse(textBoxHowManyFiles.Text, out _);
        }

        private void texBoxFolderPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFolderPathSave_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHowManyFiles_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
