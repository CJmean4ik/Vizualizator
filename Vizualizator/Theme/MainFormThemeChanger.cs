using Vizualizator.Theme.Images;
using Vizualizator.Theme.Images.ImageBinder.Interfaces;
using Vizualizator.Theme.Paints;

namespace Vizualizator.Theme
{
    internal class FormThemeChanger : IThemeChanger<Control>
    {
        private readonly DarkPaint _darkPaint;
        private readonly LightPaint _lightPaint;
        private readonly Dictionary<string,ButtonImageContainer> _buttonImage;
        private readonly Dictionary<string, LabelImageContainer> _labelImage;
        public FormThemeChanger(IButtonImageBinder buttonImageBinder, ILabelImageBinder labelImageBinder)
        {
            _darkPaint = new DarkPaint();
            _lightPaint = new LightPaint();
            _buttonImage = buttonImageBinder.GetSources();
            _labelImage = labelImageBinder.GetSources();
        }

        public void ChangeToDark(Control form)
        {
            if (form == null) return;

            foreach (var control in form.Controls)
            {
                if (control is Panel panel)
                {
                    int.TryParse((string)panel.Tag, out int tag);
                    if (tag == 1) return;
                    
                    panel.BackColor = _darkPaint.PanelDark;
                    ChangeToDark(panel);
                    continue;
                }
                if (control is Button button)
                {
                    button.BackColor = _darkPaint.ButtonDark;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 61, 61);
                    if (button.Text != "") button.ForeColor = _darkPaint.TextDark;
                    continue;
                }
                if (control is Label label)
                {
                    int.TryParse((string)label.Tag, out int tag);
                    if (tag == 2 || tag == 3 || tag == 4 || tag == 5 || tag == 6 || tag == 7) continue;

                    label.BackColor = _darkPaint.LabelDark;
                    label.ForeColor = _darkPaint.TextDark;
                    continue;
                }
                if (control is GroupBox group)
                {
                    group.BackColor = _darkPaint.PanelDark;
                    group.ForeColor = _darkPaint.TextDark;
                    ChangeToDark(group);
                    continue;
                }
                if (control is DataGridView gridView)
                {
                    //Ячейки
                    gridView.BackgroundColor = _darkPaint.DataGridDark;
                    gridView.DefaultCellStyle.BackColor = _darkPaint.DataCellsHeaderDark;
                    gridView.DefaultCellStyle.ForeColor = _darkPaint.TextDark;
                    gridView.DefaultCellStyle.SelectionForeColor = _darkPaint.DataGridDark;
                    gridView.DefaultCellStyle.SelectionBackColor = _darkPaint.TextDark;

                    //Заголовки
                    gridView.ColumnHeadersDefaultCellStyle.BackColor = _darkPaint.DataCellsHeaderDark;
                    gridView.ColumnHeadersDefaultCellStyle.ForeColor = _darkPaint.TextDark;
                    gridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = _darkPaint.DataGridDark;
                    gridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = _darkPaint.TextDark;
                    continue;
                }
                if (control is TextBox textBox)
                {
                    textBox.BackColor = _darkPaint.DataGridDark;
                    textBox.ForeColor = _darkPaint.DataGridDark;
                }

            }
        }

        public void ChangeToLight(Control form)
        {
            if (form == null) return;

            foreach (var control in form.Controls)
            {
                if (control is Panel panel)
                {
                    int.TryParse((string)panel.Tag, out int tag);
                    if (tag == 1) return;

                    panel.BackColor = _lightPaint.PanelLight;
                    ChangeToLight(panel);
                    continue;
                }
                if (control is Button button)
                {
                    button.BackColor = _lightPaint.ButtonLight;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, 170, 170);
                    if (button.Text != "") button.ForeColor = _lightPaint.TextLight;
                    continue;
                }
                if (control is Label label)
                {
                    int.TryParse((string)label.Tag, out int tag);
                    if (tag == 2 || tag == 3 || tag == 4 || tag == 5 || tag == 6 || tag == 7) continue;

                    label.BackColor = _lightPaint.LabelLight;
                    label.ForeColor = _lightPaint.TextLight;
                    continue;
                }
                if (control is GroupBox group)
                {
                    group.BackColor = _lightPaint.PanelLight;
                    group.ForeColor = _lightPaint.TextLight;
                    ChangeToLight(group);
                    continue;
                }
                if (control is DataGridView gridView)
                {
                    //Ячейки
                    gridView.BackgroundColor = _lightPaint.DataGridLight;
                    gridView.DefaultCellStyle.BackColor = _lightPaint.DataCellsHeaderLight;
                    gridView.DefaultCellStyle.ForeColor = _lightPaint.TextLight;
                    gridView.DefaultCellStyle.SelectionForeColor = _lightPaint.DataGridLight;
                    gridView.DefaultCellStyle.SelectionBackColor = _lightPaint.TextLight;
                    
                    //Заголовки
                    gridView.ColumnHeadersDefaultCellStyle.BackColor = _lightPaint.DataCellsHeaderLight;
                    gridView.ColumnHeadersDefaultCellStyle.ForeColor = _lightPaint.TextLight;
                    gridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = _lightPaint.DataGridLight;
                    gridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = _lightPaint.TextLight;
                    continue;
                }
                if (control is TextBox textBox)
                {
                    textBox.BackColor = _lightPaint.DataGridLight;
                    textBox.ForeColor = _lightPaint.TextLight;
                }

            }
            

            
        }

        public void ChangeToDarkImage()
        {
            foreach (var item in _buttonImage)
            {
                if (item.Key == null) return;

                item.Value.Button.Image = item.Value.DarkImage;            
            }

            foreach (var item in _labelImage)
            {
                if (item.Key == null) return;

                item.Value.Label.Image = item.Value.DarkImage;
            }
        }

        public void ChangeToLightImage()
        {
            foreach (var item in _buttonImage)
            {
                if (item.Key == null) return;

                item.Value.Button.Image = item.Value.LightImage;
            }

            foreach (var item in _labelImage)
            {
                if (item.Key == null) return;

                item.Value.Label.Image = item.Value.LightImage;
            }
        }
    }
}
