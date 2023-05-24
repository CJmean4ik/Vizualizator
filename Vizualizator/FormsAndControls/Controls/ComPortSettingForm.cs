using System.IO.Ports;
using Vizualizator.COM;
using Vizualizator.Theme;

namespace Vizualizator.FormsAndControls.Controls
{
    public partial class ComPortSettingForm : Form
    {
        public Action Switcher { get; set; }
        public ComPortWorker _comPortWorker { get; set; }      

        private bool isMousePress;

        private Point _clickPoint;
        private Point _formStartPoint;

        private FormThemeChanger themeChanger;

        public ComPortSettingForm() => InitializeComponent();



        public ComPortSettingForm(bool isLightTheme) : this()
        {
            themeChanger = new FormThemeChanger();
        }

        private void ComPortSettingForm_Load(object sender, EventArgs e)
        {
            cmbxComPorts.Items.AddRange(SerialPort.GetPortNames());
            btnClose.Enabled = false;
            Switcher.Invoke();
        }
        public void ChangeTheme(bool isLightTheme)
        {
            if (isLightTheme)
            {
                themeChanger.ChangeToLight(this);
                return;
            }
            themeChanger.ChangeToDark(this);
        }

        public void SwitcherStateForm(bool? isConnected)
        {
            if (isConnected == true)
            {
                btnOnCom.Enabled = false;

                stateText.Text = $"Подключен к порту: {_comPortWorker.ComPort.PortName}";
                lblState.ForeColor = Color.FromArgb(76, 175, 80);

                cmbxComPorts.Text = _comPortWorker.ComPort.PortName;
                cmbxBaudRates.Text = _comPortWorker.ComPort.BaudRate.ToString();
                cmbxDataBits.Text = _comPortWorker.ComPort.DataBits.ToString();
                cmbxParity.Text = _comPortWorker.ComPort.Parity.ToString();
                cmbxStopBits.Text = _comPortWorker.ComPort.StopBits.ToString();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Switcher.Invoke();
            this.Hide();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePress = false;
            _clickPoint = Point.Empty;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePress = true;
            _clickPoint = Cursor.Position;
            _formStartPoint = Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePress)
            {
                var cursorOffsetPoint = new Point(
                    Cursor.Position.X - _clickPoint.X,
                    Cursor.Position.Y - _clickPoint.Y);

                Location = new Point(
                    _formStartPoint.X + cursorOffsetPoint.X,
                    _formStartPoint.Y + cursorOffsetPoint.Y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbxComPorts.Items.Clear();
            cmbxComPorts.Items.AddRange(SerialPort.GetPortNames());

        }

        private void btnOnCom_Click(object sender, EventArgs e)
        {
            InitialComPort();

            if (!_comPortWorker.TryConnectToPort())
                return;


            lblState.Text = $"Подключен к порту: {_comPortWorker.ComPort.PortName}";
            lblState.ForeColor = Color.FromArgb(76, 175, 80);
            btnOnCom.Enabled = false;
            btnClose.Enabled = true;


        }
        private void InitialComPort()
        {
            _comPortWorker = new ComPortWorker
             (
               cmbxComPorts.Text,
               !int.TryParse(cmbxBaudRates.Text, out int baudRate)
               ? 9600
               : baudRate,

               !int.TryParse(cmbxDataBits.Text, out int dataBits)
               ? 8
               : dataBits,

               !Enum.TryParse<Parity>(cmbxParity.Text, out Parity parity)
               ? Parity.None
               : parity,

               !Enum.TryParse<StopBits>(cmbxStopBits.Text, out StopBits stopBits)
               ? StopBits.One
               : stopBits

             );
        }

        private void btnOffCom_Click(object sender, EventArgs e)
        {
            if (!_comPortWorker.TryDisconnectFromPort())
                return;


            lblState.Text = $"Не подключен";
            lblState.ForeColor = Color.FromArgb(255, 84, 84);
            btnOnCom.Enabled = true;
            btnClose.Enabled = false;
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }
    }
}
