namespace Vizualizator.Theme.Paints
{
    public class DarkPaint
    {
        public Color PanelDark { get; init; }
        public Color DataGridDark { get; init; }
        public Color DataCellsHeaderDark { get; init; }
        public Color TextDark { get; init; }
        public Color ButtonDark { get; set; }
        public Color LabelDark { get; set; }

        public DarkPaint()
        {
            PanelDark = Color.FromArgb(31, 31, 31);
            DataGridDark = Color.FromArgb(46, 46, 46);
            DataCellsHeaderDark = Color.FromArgb(31, 31, 31); 
            TextDark = Color.FromArgb(226, 232, 236);
            ButtonDark = Color.FromArgb(31, 31, 31);
            LabelDark = Color.FromArgb(31, 31, 31);
        }
    }
}
