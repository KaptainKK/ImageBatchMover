
namespace ImageBatchMover
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFolderPathSave = new System.Windows.Forms.TextBox();
            this.buttonBrowseSave = new System.Windows.Forms.Button();
            this.labelHowManyFiles = new System.Windows.Forms.Label();
            this.textBoxHowManyFiles = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFolderPath.Location = new System.Drawing.Point(23, 47);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFolderPath.Size = new System.Drawing.Size(446, 26);
            this.textBoxFolderPath.TabIndex = 0;
            this.textBoxFolderPath.TextChanged += new System.EventHandler(this.texBoxFolderPath_TextChanged);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBrowse.Location = new System.Drawing.Point(493, 47);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(148, 26);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "フォルダを選択";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ソースフォルダ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "保存フォルダ （空フォルダのみ）";
            // 
            // textBoxFolderPathSave
            // 
            this.textBoxFolderPathSave.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxFolderPathSave.Location = new System.Drawing.Point(23, 121);
            this.textBoxFolderPathSave.Name = "textBoxFolderPathSave";
            this.textBoxFolderPathSave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFolderPathSave.Size = new System.Drawing.Size(446, 26);
            this.textBoxFolderPathSave.TabIndex = 4;
            this.textBoxFolderPathSave.TextChanged += new System.EventHandler(this.textBoxFolderPathSave_TextChanged);
            // 
            // buttonBrowseSave
            // 
            this.buttonBrowseSave.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBrowseSave.Location = new System.Drawing.Point(493, 121);
            this.buttonBrowseSave.Name = "buttonBrowseSave";
            this.buttonBrowseSave.Size = new System.Drawing.Size(148, 26);
            this.buttonBrowseSave.TabIndex = 5;
            this.buttonBrowseSave.Text = "フォルダを選択";
            this.buttonBrowseSave.UseVisualStyleBackColor = true;
            this.buttonBrowseSave.Click += new System.EventHandler(this.buttonBrowseSave_Click);
            // 
            // labelHowManyFiles
            // 
            this.labelHowManyFiles.AutoSize = true;
            this.labelHowManyFiles.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHowManyFiles.Location = new System.Drawing.Point(19, 182);
            this.labelHowManyFiles.Name = "labelHowManyFiles";
            this.labelHowManyFiles.Size = new System.Drawing.Size(255, 19);
            this.labelHowManyFiles.TabIndex = 6;
            this.labelHowManyFiles.Text = "何枚ごとにサブフォルダに分けるか";
            // 
            // textBoxHowManyFiles
            // 
            this.textBoxHowManyFiles.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxHowManyFiles.Location = new System.Drawing.Point(23, 204);
            this.textBoxHowManyFiles.Name = "textBoxHowManyFiles";
            this.textBoxHowManyFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHowManyFiles.Size = new System.Drawing.Size(251, 26);
            this.textBoxHowManyFiles.TabIndex = 7;
            this.textBoxHowManyFiles.TextChanged += new System.EventHandler(this.textBoxHowManyFiles_TextChanged);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Enabled = false;
            this.ButtonStart.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonStart.Location = new System.Drawing.Point(23, 264);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(161, 61);
            this.ButtonStart.TabIndex = 8;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(294, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 144);
            this.label3.TabIndex = 11;
            this.label3.Text = "注意\r\n・ソースフォルダ及びそのすべてのサブフォルダから、すべての画像\r\n  ファイル（jpg、png、bmp、gifのみ）が移動\r\n\r\n・3行目で指定した数に基" +
    "づいて、画像ファイルが新しく生成され\r\n  るサブフォルダに分散\r\n\r\n・画像ファイルの移動が完了した後、ソースフォルダからは削除\r\n  ただし、対象外のファイ" +
    "ルやフォルダはその場に残る　";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(117, 383);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(443, 31);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.labelStatus.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStatus.Location = new System.Drawing.Point(273, 361);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(248, 19);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "　　　　　　　   　　　　　　　　　　\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 435);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.textBoxHowManyFiles);
            this.Controls.Add(this.labelHowManyFiles);
            this.Controls.Add(this.buttonBrowseSave);
            this.Controls.Add(this.textBoxFolderPathSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFolderPath);
            this.Name = "Form1";
            this.Text = "FileOrganizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFolderPathSave;
        private System.Windows.Forms.Button buttonBrowseSave;
        private System.Windows.Forms.Label labelHowManyFiles;
        private System.Windows.Forms.TextBox textBoxHowManyFiles;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelStatus;
    }
}

