namespace LaunchFoundationGameCamera
{
    partial class LogWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogWindow));
            this.richTextBox_LogData = new System.Windows.Forms.RichTextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_LogData
            // 
            this.richTextBox_LogData.BackColor = System.Drawing.Color.Black;
            this.richTextBox_LogData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_LogData.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_LogData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.richTextBox_LogData.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_LogData.Name = "richTextBox_LogData";
            this.richTextBox_LogData.ReadOnly = true;
            this.richTextBox_LogData.Size = new System.Drawing.Size(660, 287);
            this.richTextBox_LogData.TabIndex = 0;
            this.richTextBox_LogData.Text = "";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Red;
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Save.Location = new System.Drawing.Point(244, 311);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(173, 37);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(660, 360);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.richTextBox_LogData);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogWindow";
            this.Text = "Launcher Log";
            this.Load += new System.EventHandler(this.LogWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox_LogData;
        private Button button_Save;
    }
}