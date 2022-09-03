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
            this.button_Start = new System.Windows.Forms.Button();
            this.panel_Middle = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Supportinfo = new System.Windows.Forms.Label();
            this.label_ClickHere = new System.Windows.Forms.Label();
            this.label_LoadingInfo = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Header = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.launcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_OpenGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.openDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.launcherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.foVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandedPhotoModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Content.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.panel_Middle.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.panel_Content.Size = new System.Drawing.Size(726, 401);
            this.panel_Content.TabIndex = 0;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Controls.Add(this.button_Start);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 305);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(726, 96);
            this.panel_Bottom.TabIndex = 2;
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.Red;
            this.button_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Start.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_Start.FlatAppearance.BorderSize = 0;
            this.button_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Start.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.button_Start.Location = new System.Drawing.Point(0, 0);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(726, 96);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "START";
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
            this.panel_Middle.Size = new System.Drawing.Size(726, 162);
            this.panel_Middle.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label_Supportinfo);
            this.flowLayoutPanel1.Controls.Add(this.label_ClickHere);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 65);
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
            this.label_Supportinfo.Size = new System.Drawing.Size(531, 43);
            this.label_Supportinfo.TabIndex = 1;
            this.label_Supportinfo.Text = "For support, troubleshooting and issue reporting join the Discord chat:";
            this.label_Supportinfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Supportinfo.Click += new System.EventHandler(this.Label_Supportinfo_Click);
            // 
            // label_ClickHere
            // 
            this.label_ClickHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ClickHere.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ClickHere.ForeColor = System.Drawing.Color.LightBlue;
            this.label_ClickHere.Location = new System.Drawing.Point(540, 0);
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
            this.label_LoadingInfo.Size = new System.Drawing.Size(726, 65);
            this.label_LoadingInfo.TabIndex = 0;
            this.label_LoadingInfo.Text = "To begin make sure that the game is running and the save has been fully loaded be" +
    "fore initiating FGC";
            this.label_LoadingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.label_Header);
            this.panel_Top.Controls.Add(this.menuStrip1);
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
            this.label_Header.Location = new System.Drawing.Point(0, 24);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(726, 119);
            this.label_Header.TabIndex = 1;
            this.label_Header.Text = "Welcome to FoundationGameCamera";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launcherToolStripMenuItem,
            this.launcherToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // launcherToolStripMenuItem
            // 
            this.launcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_OpenGithub,
            this.openDiscordToolStripMenuItem,
            this.viewLicenseToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.closeToolStripMenuItem1});
            this.launcherToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.launcherToolStripMenuItem.Name = "launcherToolStripMenuItem";
            this.launcherToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.launcherToolStripMenuItem.Text = "Application";
            // 
            // toolStripMenuItem_OpenGithub
            // 
            this.toolStripMenuItem_OpenGithub.Image = global::LaunchFoundationGameCamera.Properties.Resources.github_logo_pixabayg767c696ab_640;
            this.toolStripMenuItem_OpenGithub.Name = "toolStripMenuItem_OpenGithub";
            this.toolStripMenuItem_OpenGithub.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem_OpenGithub.Text = "Open GitHub";
            this.toolStripMenuItem_OpenGithub.Click += new System.EventHandler(this.ToolStripMenuItem_OpenGithub_Click);
            // 
            // openDiscordToolStripMenuItem
            // 
            this.openDiscordToolStripMenuItem.Image = global::LaunchFoundationGameCamera.Properties.Resources.logo_ge5513914d_1920;
            this.openDiscordToolStripMenuItem.Name = "openDiscordToolStripMenuItem";
            this.openDiscordToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openDiscordToolStripMenuItem.Text = "Open Discord";
            this.openDiscordToolStripMenuItem.Click += new System.EventHandler(this.OpenDiscordToolStripMenuItem_Click);
            // 
            // viewLicenseToolStripMenuItem
            // 
            this.viewLicenseToolStripMenuItem.Image = global::LaunchFoundationGameCamera.Properties.Resources.license_icon_2793454_1280;
            this.viewLicenseToolStripMenuItem.Name = "viewLicenseToolStripMenuItem";
            this.viewLicenseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewLicenseToolStripMenuItem.Text = "View License";
            this.viewLicenseToolStripMenuItem.Click += new System.EventHandler(this.ViewLicenseToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::LaunchFoundationGameCamera.Properties.Resources.camera_pixabay_1724286_12801;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closeToolStripMenuItem.Text = "Check Updates";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Image = global::LaunchFoundationGameCamera.Properties.Resources.x_g95cc721a4_1280;
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.CloseToolStripMenuItem1_Click);
            // 
            // launcherToolStripMenuItem1
            // 
            this.launcherToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foVToolStripMenuItem,
            this.expandedPhotoModeToolStripMenuItem});
            this.launcherToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.launcherToolStripMenuItem1.Name = "launcherToolStripMenuItem1";
            this.launcherToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.launcherToolStripMenuItem1.Text = "Launcher";
            // 
            // foVToolStripMenuItem
            // 
            this.foVToolStripMenuItem.Name = "foVToolStripMenuItem";
            this.foVToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.foVToolStripMenuItem.Text = "FoV";
            this.foVToolStripMenuItem.Click += new System.EventHandler(this.FoVToolStripMenuItem_Click);
            // 
            // expandedPhotoModeToolStripMenuItem
            // 
            this.expandedPhotoModeToolStripMenuItem.Name = "expandedPhotoModeToolStripMenuItem";
            this.expandedPhotoModeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.expandedPhotoModeToolStripMenuItem.Text = "Expanded Photo Mode";
            this.expandedPhotoModeToolStripMenuItem.Click += new System.EventHandler(this.ExpandedPhotoModeToolStripMenuItem_Click);
            // 
            // LauncherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(726, 401);
            this.Controls.Add(this.panel_Content);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LauncherWindow";
            this.Text = "Foundation Game Camera Launcher";
            this.Load += new System.EventHandler(this.LauncherWindow_Load);
            this.Shown += new System.EventHandler(this.LauncherWindow_Shown);
            this.panel_Content.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Middle.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private Label label_ClickHere;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem launcherToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem_OpenGithub;
        private ToolStripMenuItem openDiscordToolStripMenuItem;
        private ToolStripMenuItem viewLicenseToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem1;
        private ToolStripMenuItem launcherToolStripMenuItem1;
        private ToolStripMenuItem foVToolStripMenuItem;
        private ToolStripMenuItem expandedPhotoModeToolStripMenuItem;
    }
}