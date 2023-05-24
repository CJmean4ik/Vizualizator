using Vizualizator.Theme.Images;
using Vizualizator.Theme.Images.ImageBinder.Interfaces;
using Vizualizator.Theme.Paints;

namespace Vizualizator.Theme
{
    /// <summary>
    /// Класс предназначенный для измения темы переданой формы
    /// </summary>
    internal class FormThemeChanger : IThemeChanger<Control>, IImageThemeChanger
    {
        private readonly DarkPaint _darkPaint;
        private readonly LightPaint _lightPaint;

        private readonly Dictionary<string, ButtonImageContainer> _buttonImage;
        private readonly Dictionary<string, LabelImageContainer> _labelImage;

        public FormThemeChanger(IButtonImageBinder buttonImageBinder, ILabelImageBinder labelImageBinder) : this()
        {         
            _buttonImage = buttonImageBinder.GetSources();
            _labelImage = labelImageBinder.GetSources();
        }

        public FormThemeChanger()
        {
            _darkPaint = new DarkPaint();
            _lightPaint = new LightPaint();
        }

        /// <summary>
        /// Меняет цвет формы и её копонетов на чёрную тему 
        /// </summary>
        /// <param name="form">Комонент который поддаёться изменению темы</param>
        public void ChangeToDark(Control form)
        {
            if (form == null) return;

            foreach (var control in form.Controls)
            {
                if (control is Panel panel)
                {
                    ChangeThemePanelByColor(panel, _darkPaint.PanelDark, true);
                    continue;
                }
                if (control is Button button)
                {
                    ChangeThemeButtonByColor(button, _darkPaint.ButtonDark, _darkPaint.MouseOverLayDark, _darkPaint.TextDark);
                    continue;
                }
                if (control is Label label)
                {
                    ChangeThemeLabelByColor(label, _darkPaint.LabelDark, _darkPaint.TextDark);
                    continue;
                }
                if (control is GroupBox group)
                {
                    ChangeThemeGroupBoxByColor(group, _darkPaint.PanelDark, _darkPaint.TextDark,true);
                    continue;
                }
                if (control is DataGridView gridView)
                {
                    ChangeThemeDataGridViewByColor(gridView, _darkPaint.DarkColorsForDataGridView);
                    continue;
                }
                if (control is TextBox textBox)
                    ChangeThemeTextBoxByColor(textBox, _darkPaint.TextBoxDark, _darkPaint.TextDark);
            }
        }

        /// <summary>
        /// Заменяет изображения компонентов на тёмный аналог 
        /// </summary>
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

        /// <summary>
        /// Меняет цвет формы и её копонетов на светлую тему 
        /// </summary>
        /// <param name="form">Комонент который поддаёться изменению темы</param>
        public void ChangeToLight(Control form)
        {
            if (form == null) return;

            foreach (var control in form.Controls)
            {
                if (control is Panel panel)
                {
                    ChangeThemePanelByColor(panel, _lightPaint.PanelLight, false);
                    continue;
                }
                if (control is Button button)
                {
                    ChangeThemeButtonByColor(button, _lightPaint.ButtonLight, _lightPaint.MouseOverLayLight, _lightPaint.TextLight);
                    continue;
                }
                if (control is Label label)
                {
                    ChangeThemeLabelByColor(label, _lightPaint.LabelLight, _lightPaint.TextLight);
                    continue;
                }
                if (control is GroupBox group)
                {
                    ChangeThemeGroupBoxByColor(group, _lightPaint.PanelLight, _lightPaint.TextLight, false);
                    continue;
                }
                if (control is DataGridView gridView)
                {
                    ChangeThemeDataGridViewByColor(gridView, _lightPaint.LightColorsForDataGridView);
                    continue;
                }
                if (control is TextBox textBox)             
                    ChangeThemeTextBoxByColor(textBox, _lightPaint.LightColorsForDataGridView["BackgroundColor"], _lightPaint.TextLight);
                

            }



        }

        /// <summary>
        /// Заменяет изображения компонентов на светлый аналог
        /// </summary>
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

        #region Методы для изменения темы Компонетов

        //Методы, которые меняют тему компонента в зависимости от переданного цвета
        private void ChangeThemeButtonByColor(Button button, Color backColor, Color flatColor, Color foreColor)
        {
            string EMTY_STRING = "";

            button.BackColor = backColor;
            button.FlatAppearance.MouseOverBackColor = flatColor;

            if (button.Text != EMTY_STRING) button.ForeColor = foreColor;
        }
        private void ChangeThemeLabelByColor(Label label, Color backColor, Color foreColor)
        {
            int.TryParse((string)label.Tag, out int tag);

            bool skipThemeChanges = SkipThemeChangesForLabel(tag);
            if (skipThemeChanges) return;

            label.BackColor = backColor;
            label.ForeColor = foreColor;
        }
        private void ChangeThemeGroupBoxByColor(GroupBox groupBox, Color backColor, Color foreColor, bool isDark)
        {
            groupBox.BackColor = backColor;
            groupBox.ForeColor = foreColor;

            if (isDark)
            {
                ChangeToDark(groupBox);
                return;
            }
            ChangeToLight(groupBox);
            return;
        }
        private void ChangeThemeTextBoxByColor(TextBox textBox, Color backColor,Color foreColor)
        {
            textBox.BackColor = backColor;
            textBox.ForeColor = foreColor;
        }
        private void ChangeThemeDataGridViewByColor(DataGridView dataGridView, Dictionary<string, Color> colors)
        {
            ChangeCellsColor(dataGridView, colors);

            ChangeHeadersColor(dataGridView, colors);
        }
        private void ChangeCellsColor(DataGridView dataGridView, Dictionary<string, Color> colors)
        {
            dataGridView.BackgroundColor = colors["BackgroundColor"];
            dataGridView.DefaultCellStyle.BackColor = colors["BackColor"];
            dataGridView.DefaultCellStyle.ForeColor = colors["TextColor"];
            dataGridView.DefaultCellStyle.SelectionForeColor = colors["SelectionForeColor"];
            dataGridView.DefaultCellStyle.SelectionBackColor = colors["SelectionBackColor"];
        }
        private void ChangeHeadersColor(DataGridView dataGridView, Dictionary<string, Color> colors)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = colors["BackColor"];
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = colors["TextColor"];
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = colors["SelectionForeColor"];
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = colors["SelectionBackColor"];
        }
        private void ChangeThemePanelByColor(Panel panel, Color backColor, bool isDark)
        {
            int TAG_FOR_SKIP_PANEL = 1;
            int EMPTY_PANEL_CONTROLS = 0;

            int.TryParse((string)panel.Tag, out int tag);

            if (tag == TAG_FOR_SKIP_PANEL) return;
            panel.BackColor = backColor;

            if (panel.Controls.Count == EMPTY_PANEL_CONTROLS) return;

            if (isDark)
            {
                ChangeToDark(panel);
                return;
            }
            ChangeToLight(panel);
            return;

        }

        #endregion


        /// <summary>
        /// Пропускает изменения темы тектовых полей, которые соответсвуют заданным индексам
        /// </summary>
        /// <param name="tag">Тег текстового поля</param>
        /// <returns>Значение, указывающие не должен ли компонент поддаваться для изменения темы</returns>
        private bool SkipThemeChangesForLabel(int tag)
        {
            int TAG_LABEL_FLAME = 2;
            int TAG_LABEL_BREAKS = 3;
            int TAG_LABEL_SHORTCIRCUIT = 4;
            int TAG_LABLE_DISCONNECTOSU = 5;
            int TAG_LABLE_OFFOSU = 6;
            int TAG_LABLE_STATE = 7;

            bool skipThemeChanges =
              tag == TAG_LABEL_FLAME ||
              tag == TAG_LABEL_BREAKS ||
              tag == TAG_LABEL_SHORTCIRCUIT ||
              tag == TAG_LABLE_DISCONNECTOSU ||
              tag == TAG_LABLE_OFFOSU ||
              tag == TAG_LABLE_STATE ?
              true : false;

            return skipThemeChanges;
        }

    }
}
