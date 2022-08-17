namespace LaunchFoundationGameCamera
{
    partial class LauncherWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherWindow));
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.pictureBox_License = new System.Windows.Forms.PictureBox();
            this.button_LoadFovFix = new System.Windows.Forms.Button();
            this.pictureBox_Github = new System.Windows.Forms.PictureBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.panel_Middle = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Supportinfo = new System.Windows.Forms.Label();
            this.label_ClickHere = new System.Windows.Forms.Label();
            this.label_LoadingInfo = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Header = new System.Windows.Forms.Label();
            this.panel_Content.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_License)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Github)).BeginInit();
            this.panel_Middle.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.panel_Bottom);
            this.panel_Content.Controls.Add(this.panel_Middle);
            this.panel_Content.Controls.Add(this.panel_Top);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(0, 0);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(726, 439);
            this.panel_Content.TabIndex = 0;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Controls.Add(this.pictureBox_License);
            this.panel_Bottom.Controls.Add(this.button_LoadFovFix);
            this.panel_Bottom.Controls.Add(this.pictureBox_Github);
            this.panel_Bottom.Controls.Add(this.button_Start);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 238);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(726, 209);
            this.panel_Bottom.TabIndex = 2;
            // 
            // pictureBox_License
            // 
            this.pictureBox_License.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_License.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_License.Image")));
            this.pictureBox_License.Location = new System.Drawing.Point(683, 158);
            this.pictureBox_License.Name = "pictureBox_License";
            this.pictureBox_License.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_License.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_License.TabIndex = 4;
            this.pictureBox_License.TabStop = false;
            this.pictureBox_License.Click += new System.EventHandler(this.PictureBox_License_Click);
            // 
            // button_LoadFovFix
            // 
            this.button_LoadFovFix.BackColor = System.Drawing.Color.Indigo;
            this.button_LoadFovFix.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button_LoadFovFix.FlatAppearance.BorderSize = 0;
            this.button_LoadFovFix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.button_LoadFovFix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_LoadFovFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LoadFovFix.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_LoadFovFix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button_LoadFovFix.Location = new System.Drawing.Point(392, 47);
            this.button_LoadFovFix.Name = "button_LoadFovFix";
            this.button_LoadFovFix.Size = new System.Drawing.Size(276, 54);
            this.button_LoadFovFix.TabIndex = 3;
            this.button_LoadFovFix.Text = "LOAD FoV FIX";
            this.button_LoadFovFix.UseVisualStyleBackColor = false;
            this.button_LoadFovFix.Click += new System.EventHandler(this.Button_LoadFovFix_Click);
            // 
            // pictureBox_Github
            // 
            this.pictureBox_Github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Github.Image = global::LaunchFoundationGameCamera.Properties.Resources.github_logo_pixabayg767c696ab_640;
            this.pictureBox_Github.Location = new System.Drawing.Point(637, 158);
            this.pictureBox_Github.Name = "pictureBox_Github";
            this.pictureBox_Github.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Github.TabIndex = 2;
            this.pictureBox_Github.TabStop = false;
            this.pictureBox_Github.Click += new System.EventHandler(this.PictureBox_Github_Click);
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.Indigo;
            this.button_Start.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.button_Start.FlatAppearance.BorderSize = 0;
            this.button_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.button_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Start.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button_Start.Location = new System.Drawing.Point(58, 47);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(276, 54);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "LOAD GAME CAMERA";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // panel_Middle
            // 
            this.panel_Middle.Controls.Add(this.flowLayoutPanel1);
            this.panel_Middle.Controls.Add(this.label_LoadingInfo);
            this.panel_Middle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Middle.Location = new System.Drawing.Point(0, 143);
            this.panel_Middle.Name = "panel_Middle";
            this.panel_Middle.Size = new System.Drawing.Size(726, 95);
            this.panel_Middle.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label_Supportinfo);
            this.flowLayoutPanel1.Controls.Add(this.label_ClickHere);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(726, 43);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label_Supportinfo
            // 
            this.label_Supportinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Supportinfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Supportinfo.Location = new System.Drawing.Point(3, 0);
            this.label_Supportinfo.Name = "label_Supportinfo";
            this.label_Supportinfo.Size = new System.Drawing.Size(564, 43);
            this.label_Supportinfo.TabIndex = 1;
            this.label_Supportinfo.Text = "For support, troubleshooting and sharing screen captures join the element chat:";
            this.label_Supportinfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Supportinfo.Click += new System.EventHandler(this.Label_Supportinfo_Click);
            // 
            // label_ClickHere
            // 
            this.label_ClickHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ClickHere.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ClickHere.ForeColor = System.Drawing.Color.LightBlue;
            this.label_ClickHere.Location = new System.Drawing.Point(573, 0);
            this.label_ClickHere.Name = "label_ClickHere";
            this.label_ClickHere.Size = new System.Drawing.Size(91, 43);
            this.label_ClickHere.TabIndex = 2;
            this.label_ClickHere.Text = "CLICK HERE";
            this.label_ClickHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ClickHere.Click += new System.EventHandler(this.Label_ClickHere_Click);
            // 
            // label_LoadingInfo
            // 
            this.label_LoadingInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_LoadingInfo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_LoadingInfo.Location = new System.Drawing.Point(0, 0);
            this.label_LoadingInfo.Name = "label_LoadingInfo";
            this.label_LoadingInfo.Size = new System.Drawing.Size(726, 52);
            this.label_LoadingInfo.TabIndex = 0;
            this.label_LoadingInfo.Text = "To begin make sure that the game is running and the save has been fully loaded be" +
    "fore initiating FGC";
            this.label_LoadingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.label_Header);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(726, 143);
            this.panel_Top.TabIndex = 0;
            // 
            // label_Header
            // 
            this.label_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Header.Location = new System.Drawing.Point(0, 0);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(726, 143);
            this.label_Header.TabIndex = 1;
            this.label_Header.Text = "Welcome to FoundationGameCamera";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LauncherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(726, 439);
            this.Controls.Add(this.panel_Content);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LauncherWindow";
            this.Text = "Foundation Game Camera Launcher";
            this.Load += new System.EventHandler(this.LauncherWindow_Load);
            this.Shown += new System.EventHandler(this.LauncherWindow_Shown);
            this.panel_Content.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_License)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Github)).EndInit();
            this.panel_Middle.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Content;
        private Panel panel_Top;
        private Label label_LoadingInfo;
        private Panel panel_Middle;
        private Label label_Header;
        private Panel panel_Bottom;
        private Label label_Supportinfo;
        private Button button_Start;
        private PictureBox pictureBox_Github;
        private Button button_LoadFovFix;
        private PictureBox pictureBox_License;
        private Label label_ClickHere;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}