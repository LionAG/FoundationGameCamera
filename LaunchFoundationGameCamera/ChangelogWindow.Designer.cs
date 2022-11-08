namespace LaunchFoundationGameCamera
{
    partial class ChangelogWindow
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
            this.richTextBox_Changelog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_Changelog
            // 
            this.richTextBox_Changelog.BackColor = System.Drawing.Color.Black;
            this.richTextBox_Changelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Changelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Changelog.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_Changelog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.richTextBox_Changelog.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Changelog.Name = "richTextBox_Changelog";
            this.richTextBox_Changelog.ReadOnly = true;
            this.richTextBox_Changelog.Size = new System.Drawing.Size(784, 401);
            this.richTextBox_Changelog.TabIndex = 0;
            this.richTextBox_Changelog.Text = "";
            // 
            // ChangelogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.richTextBox_Changelog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangelogWindow";
            this.Text = "Changelog";
            this.Load += new System.EventHandler(this.ChangelogWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox_Changelog;
    }
}