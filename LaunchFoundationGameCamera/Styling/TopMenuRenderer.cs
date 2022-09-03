namespace LaunchFoundationGameCamera.Styling
{
    internal class TopMenuRendererColors : ProfessionalColorTable
    {
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(40, 40, 40);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(40, 40, 40);
        public override Color MenuItemBorder => Color.FromArgb(70, 70, 70);
        public override Color MenuItemPressedGradientBegin => Color.Black;
        public override Color MenuItemPressedGradientMiddle => Color.Black;
        public override Color MenuItemPressedGradientEnd => Color.Black;
        public override Color MenuItemSelected => Color.Black;

        public override Color ImageMarginGradientBegin => Color.Black;
        public override Color ImageMarginGradientEnd => Color.Black;
        public override Color ImageMarginGradientMiddle => Color.Black;

        public override Color MenuBorder => Color.FromArgb(50, 50, 50);
        public override Color ToolStripDropDownBackground => Color.FromArgb(50, 50, 50);
        public override Color MenuStripGradientBegin => Color.Black;
        public override Color MenuStripGradientEnd => Color.Black;
    }

    internal class TopMenuRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            e.ToolStrip.BackColor = Color.Black;
            e.ToolStrip.ForeColor = Color.FromArgb(222, 222, 222);

            base.OnRenderMenuItemBackground(e);
        }

        //protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        //{
        //    base.OnRenderToolStripBorder(e);
        //    ControlPaint.DrawFocusRectangle(e.Graphics, e.AffectedBounds, SystemColors.ControlDarkDark, SystemColors.ControlDarkDark);
        //}

        public TopMenuRenderer() : base(new TopMenuRendererColors())
        {

        }
    }
}
