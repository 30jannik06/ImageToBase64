namespace ImageToBase64
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.browseButton = new System.Windows.Forms.Button();
            this.imageToBase64Button = new System.Windows.Forms.Button();
            this.base64ToImageButton = new System.Windows.Forms.Button();
            this.imageOriginal = new System.Windows.Forms.PictureBox();
            this.picBase64ToImage = new System.Windows.Forms.PictureBox();
            this.txtBase64 = new System.Windows.Forms.RichTextBox();
            this.filePathTextBox = new System.Windows.Forms.RichTextBox();
            this.copyBase64Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase64ToImage)).BeginInit();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(12, 308);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(177, 62);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // imageToBase64Button
            // 
            this.imageToBase64Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageToBase64Button.ForeColor = System.Drawing.Color.White;
            this.imageToBase64Button.Location = new System.Drawing.Point(195, 308);
            this.imageToBase64Button.Name = "imageToBase64Button";
            this.imageToBase64Button.Size = new System.Drawing.Size(177, 62);
            this.imageToBase64Button.TabIndex = 1;
            this.imageToBase64Button.Text = "Image to Base64";
            this.imageToBase64Button.UseVisualStyleBackColor = true;
            this.imageToBase64Button.Click += new System.EventHandler(this.imageToBase64Button_Click);
            // 
            // base64ToImageButton
            // 
            this.base64ToImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.base64ToImageButton.ForeColor = System.Drawing.Color.White;
            this.base64ToImageButton.Location = new System.Drawing.Point(12, 376);
            this.base64ToImageButton.Name = "base64ToImageButton";
            this.base64ToImageButton.Size = new System.Drawing.Size(177, 62);
            this.base64ToImageButton.TabIndex = 2;
            this.base64ToImageButton.Text = "Base64 to Image";
            this.base64ToImageButton.UseVisualStyleBackColor = true;
            this.base64ToImageButton.Click += new System.EventHandler(this.base64ToImageButton_Click);
            // 
            // imageOriginal
            // 
            this.imageOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageOriginal.Location = new System.Drawing.Point(12, 12);
            this.imageOriginal.Name = "imageOriginal";
            this.imageOriginal.Size = new System.Drawing.Size(361, 222);
            this.imageOriginal.TabIndex = 3;
            this.imageOriginal.TabStop = false;
            // 
            // picBase64ToImage
            // 
            this.picBase64ToImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBase64ToImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBase64ToImage.Location = new System.Drawing.Point(379, 152);
            this.picBase64ToImage.Name = "picBase64ToImage";
            this.picBase64ToImage.Size = new System.Drawing.Size(409, 286);
            this.picBase64ToImage.TabIndex = 4;
            this.picBase64ToImage.TabStop = false;
            // 
            // txtBase64
            // 
            this.txtBase64.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBase64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBase64.ForeColor = System.Drawing.Color.White;
            this.txtBase64.Location = new System.Drawing.Point(379, 12);
            this.txtBase64.Name = "txtBase64";
            this.txtBase64.Size = new System.Drawing.Size(409, 134);
            this.txtBase64.TabIndex = 6;
            this.txtBase64.Text = "";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.filePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePathTextBox.ForeColor = System.Drawing.Color.White;
            this.filePathTextBox.Location = new System.Drawing.Point(12, 240);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(360, 62);
            this.filePathTextBox.TabIndex = 7;
            this.filePathTextBox.Text = "";
            // 
            // copyBase64Button
            // 
            this.copyBase64Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBase64Button.ForeColor = System.Drawing.Color.White;
            this.copyBase64Button.Location = new System.Drawing.Point(195, 376);
            this.copyBase64Button.Name = "copyBase64Button";
            this.copyBase64Button.Size = new System.Drawing.Size(177, 62);
            this.copyBase64Button.TabIndex = 8;
            this.copyBase64Button.Text = "Copy Base64 String";
            this.copyBase64Button.UseVisualStyleBackColor = true;
            this.copyBase64Button.Click += new System.EventHandler(this.copyBase64Button_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.copyBase64Button);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.txtBase64);
            this.Controls.Add(this.picBase64ToImage);
            this.Controls.Add(this.imageOriginal);
            this.Controls.Add(this.base64ToImageButton);
            this.Controls.Add(this.imageToBase64Button);
            this.Controls.Add(this.browseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image to Base64";
            ((System.ComponentModel.ISupportInitialize)(this.imageOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase64ToImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button browseButton;
        private Button imageToBase64Button;
        private Button base64ToImageButton;
        private PictureBox imageOriginal;
        private PictureBox picBase64ToImage;
        private RichTextBox txtBase64;
        private RichTextBox filePathTextBox;
        private Button copyBase64Button;
    }
}