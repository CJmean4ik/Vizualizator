namespace Vizualizator.Theme.Paints
{
    public class LightPaint
    {
        public Color PanelLight { get; init; }
        public Color ButtonLight { get; init; }
        public Color LabelLight { get; init; }
        public Color DataGridLight { get; init; }
        public Color DataCellsHeaderLight { get; init; }
        public Color TextLight { get; init; }

        public LightPaint()
        {
            PanelLight = Color.FromArgb(189, 211, 204);
            DataGridLight = Color.FromArgb(234, 233, 229);
            DataCellsHeaderLight = Color.FromArgb(189, 211, 204);
            TextLight = Color.FromArgb(42, 37, 57);
            ButtonLight = Color.FromArgb(189, 211, 204);
            LabelLight = Color.FromArgb(189, 211, 204);
        }

    }
}
