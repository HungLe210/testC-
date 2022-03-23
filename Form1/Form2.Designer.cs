
namespace Form1
{
    partial class Form2
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
            this.hienthi = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.listimage = new System.Windows.Forms.ListBox();
            this.duongdan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // hienthi
            // 
            this.hienthi.Location = new System.Drawing.Point(77, 23);
            this.hienthi.Name = "hienthi";
            this.hienthi.Size = new System.Drawing.Size(672, 291);
            this.hienthi.TabIndex = 0;
            this.hienthi.TabStop = false;
            this.hienthi.Click += new System.EventHandler(this.hienthi_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(107, 384);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(129, 23);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "Select Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // listimage
            // 
            this.listimage.FormattingEnabled = true;
            this.listimage.ItemHeight = 16;
            this.listimage.Location = new System.Drawing.Point(362, 359);
            this.listimage.Name = "listimage";
            this.listimage.Size = new System.Drawing.Size(387, 84);
            this.listimage.TabIndex = 2;
            this.listimage.SelectedIndexChanged += new System.EventHandler(this.listimage_SelectedIndexChanged);
            // 
            // duongdan
            // 
            this.duongdan.Location = new System.Drawing.Point(435, 331);
            this.duongdan.Name = "duongdan";
            this.duongdan.Size = new System.Drawing.Size(314, 22);
            this.duongdan.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.duongdan);
            this.Controls.Add(this.listimage);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.hienthi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hienthi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.ListBox listimage;
        private System.Windows.Forms.TextBox duongdan;
    }
}