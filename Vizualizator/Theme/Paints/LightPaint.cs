namespace Vizualizator.Theme.Paints
{
    public class LightPaint
    {
        public Color PanelLight { get; init; }
        public Color ButtonLight { get; init; }
        public Color LabelLight { get; init; }
        public Color TextLight { get; init; }
        public Color MouseOverLayLight { get; set; }
        public Dictionary<string, Color> LightColorsForDataGridView { get; set; }

        public LightPaint()
        {
            PanelLight = Color.FromArgb(189, 211, 204);
            TextLight = Color.FromArgb(42, 37, 57);
            ButtonLight = Color.FromArgb(189, 211, 204);
            LabelLight = Color.FromArgb(189, 211, 204);
            MouseOverLayLight = Color.FromArgb(170, 170, 170);

            LightColorsForDataGridView = InitializeColorsContainer();
        }
        private Dictionary<string, Color> InitializeColorsContainer()
        {
            return new Dictionary<string, Color>()
            {
                ["BackgroundColor"] = Color.FromArgb(234, 233, 229),
                ["BackColor"] = Color.FromArgb(189, 211, 204),
                ["TextColor"] = TextLight,
                ["SelectionColor"] = Color.FromArgb(234, 233, 229),
                ["SelectionBackColor"] = TextLight
            };
        }
    }
}
