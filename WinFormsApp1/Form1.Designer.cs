
namespace WinFormsApp1
{
    partial class Background_imager_form
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
            this.components = new System.ComponentModel.Container();
            this.excerpt_params = new System.Windows.Forms.GroupBox();
            this.keywords_textbox = new System.Windows.Forms.TextBox();
            this.attribute_textbox = new System.Windows.Forms.TextBox();
            this.excerpt_textbox = new System.Windows.Forms.TextBox();
            this.get_images_button = new System.Windows.Forms.Button();
            this.download_button = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.image_picture_box = new System.Windows.Forms.PictureBox();
            this.first_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.last_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.user_docs = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.excerpt_params.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // excerpt_params
            // 
            this.excerpt_params.Controls.Add(this.keywords_textbox);
            this.excerpt_params.Controls.Add(this.attribute_textbox);
            this.excerpt_params.Controls.Add(this.excerpt_textbox);
            this.excerpt_params.Location = new System.Drawing.Point(44, 37);
            this.excerpt_params.Name = "excerpt_params";
            this.excerpt_params.Size = new System.Drawing.Size(416, 311);
            this.excerpt_params.TabIndex = 0;
            this.excerpt_params.TabStop = false;
            this.excerpt_params.Text = "Quotes Parameters";
            // 
            // keywords_textbox
            // 
            this.keywords_textbox.Location = new System.Drawing.Point(219, 269);
            this.keywords_textbox.Name = "keywords_textbox";
            this.keywords_textbox.PlaceholderText = "Indicate keyword here";
            this.keywords_textbox.Size = new System.Drawing.Size(191, 23);
            this.keywords_textbox.TabIndex = 2;
            // 
            // attribute_textbox
            // 
            this.attribute_textbox.Location = new System.Drawing.Point(7, 269);
            this.attribute_textbox.Name = "attribute_textbox";
            this.attribute_textbox.PlaceholderText = "Indicate your attribution here";
            this.attribute_textbox.Size = new System.Drawing.Size(197, 23);
            this.attribute_textbox.TabIndex = 1;
            // 
            // excerpt_textbox
            // 
            this.excerpt_textbox.Location = new System.Drawing.Point(7, 22);
            this.excerpt_textbox.Multiline = true;
            this.excerpt_textbox.Name = "excerpt_textbox";
            this.excerpt_textbox.PlaceholderText = "Write/Paste your quote here";
            this.excerpt_textbox.Size = new System.Drawing.Size(403, 241);
            this.excerpt_textbox.TabIndex = 0;
            this.excerpt_textbox.TextChanged += new System.EventHandler(this.excerpt_textbox_TextChanged);
            // 
            // get_images_button
            // 
            this.get_images_button.Location = new System.Drawing.Point(208, 354);
            this.get_images_button.Name = "get_images_button";
            this.get_images_button.Size = new System.Drawing.Size(246, 38);
            this.get_images_button.TabIndex = 1;
            this.get_images_button.Text = "Get Images";
            this.get_images_button.UseVisualStyleBackColor = true;
            this.get_images_button.Click += new System.EventHandler(this.get_images_button_click);
            // 
            // download_button
            // 
            this.download_button.Location = new System.Drawing.Point(563, 355);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(209, 38);
            this.download_button.TabIndex = 3;
            this.download_button.Text = "Download";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.download_button_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth4Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(4, 4);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList4.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // image_picture_box
            // 
            this.image_picture_box.Location = new System.Drawing.Point(563, 37);
            this.image_picture_box.Name = "image_picture_box";
            this.image_picture_box.Size = new System.Drawing.Size(209, 292);
            this.image_picture_box.TabIndex = 4;
            this.image_picture_box.TabStop = false;
            // 
            // first_button
            // 
            this.first_button.Location = new System.Drawing.Point(513, 72);
            this.first_button.Name = "first_button";
            this.first_button.Size = new System.Drawing.Size(44, 39);
            this.first_button.TabIndex = 5;
            this.first_button.Text = "First";
            this.first_button.UseVisualStyleBackColor = true;
            this.first_button.Click += new System.EventHandler(this.first_button_Click);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(513, 128);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(44, 39);
            this.next_button.TabIndex = 6;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // last_button
            // 
            this.last_button.Location = new System.Drawing.Point(513, 240);
            this.last_button.Name = "last_button";
            this.last_button.Size = new System.Drawing.Size(44, 39);
            this.last_button.TabIndex = 7;
            this.last_button.Text = "Last";
            this.last_button.UseVisualStyleBackColor = true;
            this.last_button.Click += new System.EventHandler(this.last_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(513, 185);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(44, 39);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(51, 354);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(143, 37);
            this.clear_button.TabIndex = 9;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // user_docs
            // 
            this.user_docs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_docs.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_docs.Location = new System.Drawing.Point(479, 37);
            this.user_docs.Multiline = true;
            this.user_docs.Name = "user_docs";
            this.user_docs.ReadOnly = true;
            this.user_docs.Size = new System.Drawing.Size(293, 311);
            this.user_docs.TabIndex = 3;
            this.user_docs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backgroundWorker1
            // 

            // 
            // Background_imager_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.user_docs);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.last_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.first_button);
            this.Controls.Add(this.image_picture_box);
            this.Controls.Add(this.download_button);
            this.Controls.Add(this.get_images_button);
            this.Controls.Add(this.excerpt_params);
            this.Name = "Background_imager_form";
            this.Text = "Background Imager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.excerpt_params.ResumeLayout(false);
            this.excerpt_params.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox excerpt_params;
        private System.Windows.Forms.TextBox keywords_textbox;
        private System.Windows.Forms.TextBox attribute_textbox;
        private System.Windows.Forms.TextBox excerpt_textbox;
        private System.Windows.Forms.Button get_images_button;
        private System.Windows.Forms.Button download_button;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.PictureBox image_picture_box;
        private System.Windows.Forms.Button first_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button last_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox user_docs;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

