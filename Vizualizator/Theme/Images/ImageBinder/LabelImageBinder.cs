using FormsAndControls.MainForm.Vizualizator;
using Vizualizator.Properties;
using Vizualizator.Theme.Images.ImageBinder.Interfaces;

namespace Vizualizator.Theme.Images.ImageBinder
{
    internal class LabelImageBinder : ILabelImageBinder
    {
        public frmMain Control { get; set; }

        public LabelImageBinder(frmMain control)
        {
            Control = control;
        }

        public Dictionary<string, LabelImageContainer> GetSources()
        {
            var labelImage = new Dictionary<string, LabelImageContainer>()
            {
                ["flame"] = new LabelImageContainer { DarkImage = Resources.flame_d, LightImage = Resources.flame_l, Label = Control.Flame },
                ["cliff"] = new LabelImageContainer { DarkImage = Resources.page_break_d, LightImage = Resources.page_break_l, Label = Control.Label8 },
                ["shortCircuit "] = new LabelImageContainer { DarkImage = Resources.bolt_d, LightImage = Resources.bolt_l, Label = Control.Label9 },
                ["disconnectOSU "] = new LabelImageContainer { DarkImage = Resources.wifi_slash_d, LightImage = Resources.wifi_slash_l, Label = Control.DisconnectOSU },
                ["offOSU "] = new LabelImageContainer { DarkImage = Resources.toggle_off_d, LightImage = Resources.toggle_off_l, Label = Control.OffOSU }
            };
            return labelImage;
        }

        
    }
}
