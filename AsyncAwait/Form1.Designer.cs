
namespace AsyncAwait
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
            this.Htmlbox = new System.Windows.Forms.TextBox();
            this.Download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Htmlbox
            // 
            this.Htmlbox.Location = new System.Drawing.Point(12, 12);
            this.Htmlbox.Multiline = true;
            this.Htmlbox.Name = "Htmlbox";
            this.Htmlbox.Size = new System.Drawing.Size(776, 561);
            this.Htmlbox.TabIndex = 0;
            this.Htmlbox.TextChanged += new System.EventHandler(this.Htmlbox_TextChanged);
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(343, 579);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(89, 23);
            this.Download.TabIndex = 1;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Htmlbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Htmlbox;
        private System.Windows.Forms.Button Download;
    }
}

