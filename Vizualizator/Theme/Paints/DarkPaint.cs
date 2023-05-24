namespace Vizualizator.Theme.Paints
{
    public class DarkPaint
    {
        public Color PanelDark { get; init; }
        public Color TextDark { get; init; }
        public Color ButtonDark { get; set; }
        public Color LabelDark { get; set; }
        public Color MouseOverLayDark { get; set; }
        public Color TextBoxDark { get; set; }

        public Dictionary<string,Color> DarkColorsForDataGridView { get; set; }

        public DarkPaint()
        {
            PanelDark = Color.FromArgb(31, 31, 31);
            TextDark = Color.FromArgb(226, 232, 236);
            ButtonDark = Color.FromArgb(31, 31, 31);
            LabelDark = Color.FromArgb(31, 31, 31);
            MouseOverLayDark = Color.FromArgb(61, 61, 61);
            TextBoxDark = Color.FromArgb(46, 46, 46);

            DarkColorsForDataGridView = InitializeColorsContainer();
        }

        private Dictionary<string, Color> InitializeColorsContainer()
        {
            return new Dictionary<string, Color>()
            {
                ["BackgroundColor"] = Color.FromArgb(46, 46, 46),
                ["BackColor"] = Color.FromArgb(31, 31, 31),
                ["TextColor"] = TextDark,
                ["SelectionForeColor"] = TextDark,
                ["SelectionBackColor"] = Color.FromArgb(46, 46, 46),
        };
        }
    }
}
