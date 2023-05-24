using System;
using Vizualizator.Theme.Paints;

namespace Vizualizator.Theme
{
    internal class ComPortControlThemeChanger : IThemeChanger<Control>
    {
        private readonly DarkPaint _darkPaint;
        private readonly LightPaint _lightPaint;
        public ComPortControlThemeChanger()
        {
            _darkPaint = new DarkPaint();
            _lightPaint = new LightPaint();
        }
        public void ChangeToDark(Control form)
        {
            if (form == null) return;

        }

        public void ChangeToLight(Control form)
        {
            throw new NotImplementedException();
        }
    }
}
