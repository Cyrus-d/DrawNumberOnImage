namespace DrawNumberOnImage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.tbNumOfImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGenerate = new System.Windows.Forms.Button();
            this.lblOutPath = new System.Windows.Forms.Label();
            this.btnSelectOutFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(65, 35);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(150, 23);
            this.btnSelectImage.TabIndex = 0;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.BtnSelectImage_Click);
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(62, 61);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(0, 13);
            this.lblImagePath.TabIndex = 1;
            this.lblImagePath.Click += new System.EventHandler(this.LblPath_Click);
            // 
            // tbNumOfImage
            // 
            this.tbNumOfImage.Location = new System.Drawing.Point(65, 172);
            this.tbNumOfImage.Name = "tbNumOfImage";
            this.tbNumOfImage.Size = new System.Drawing.Size(150, 20);
            this.tbNumOfImage.TabIndex = 2;
            this.tbNumOfImage.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number Of Image To Generate";
            // 
            // tbGenerate
            // 
            this.tbGenerate.Location = new System.Drawing.Point(65, 215);
            this.tbGenerate.Name = "tbGenerate";
            this.tbGenerate.Size = new System.Drawing.Size(150, 23);
            this.tbGenerate.TabIndex = 4;
            this.tbGenerate.Text = "Generate Images";
            this.tbGenerate.UseVisualStyleBackColor = true;
            this.tbGenerate.Click += new System.EventHandler(this.TbGenerate_Click);
            // 
            // lblOutPath
            // 
            this.lblOutPath.AutoSize = true;
            this.lblOutPath.Location = new System.Drawing.Point(62, 119);
            this.lblOutPath.Name = "lblOutPath";
            this.lblOutPath.Size = new System.Drawing.Size(0, 13);
            this.lblOutPath.TabIndex = 6;
            // 
            // btnSelectOutFolder
            // 
            this.btnSelectOutFolder.Location = new System.Drawing.Point(65, 93);
            this.btnSelectOutFolder.Name = "btnSelectOutFolder";
            this.btnSelectOutFolder.Size = new System.Drawing.Size(150, 23);
            this.btnSelectOutFolder.TabIndex = 5;
            this.btnSelectOutFolder.Text = "Select Output Folder";
            this.btnSelectOutFolder.UseVisualStyleBackColor = true;
            this.btnSelectOutFolder.Click += new System.EventHandler(this.BtnSelectOutFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 288);
            this.Controls.Add(this.lblOutPath);
            this.Controls.Add(this.btnSelectOutFolder);
            this.Controls.Add(this.tbGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumOfImage);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.btnSelectImage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.TextBox tbNumOfImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbGenerate;
        private System.Windows.Forms.Label lblOutPath;
        private System.Windows.Forms.Button btnSelectOutFolder;
    }
}

