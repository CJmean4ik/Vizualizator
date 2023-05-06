using Vizualizator.Properties;
using Vizualizator.Theme.Images.ImageBinder.Interfaces;

namespace Vizualizator.Theme.Images.ImageBinder
{
    internal class ButtonImageBinder : IButtonImageBinder
    {
        public frmMain Control { get; set; }

        public ButtonImageBinder(frmMain control) => Control = control;
        

        public Dictionary<string, ButtonImageContainer> GetSources()
        {
            var btnImage = new Dictionary<string, ButtonImageContainer>
            {
                ["btnSelectDb"] = new ButtonImageContainer 
                { LightImage = Resources.download_l,
                    DarkImage = Resources.download_d,
                    Button = Control.BtnSelectDb
                },
                ["btnConvertDB"] = new ButtonImageContainer 
                { 
                    LightImage = Resources.refresh_l,
                    DarkImage = Resources.refresh_d,
                    Button = Control.BtnConvertDB
                },
                ["lightMode"] = new ButtonImageContainer 
                { 
                    LightImage = Resources.lightMode_l,
                    DarkImage = Resources.darkMode_l,
                    Button = Control.ThemeButton
                },
                ["darkMode"] = new ButtonImageContainer 
                { 
                    LightImage = Resources.darkMode_l,
                    DarkImage = Resources.darkMode_d,
                    Button = Control.ThemeButton
                }
            };
            return btnImage;
        }
    }
}
