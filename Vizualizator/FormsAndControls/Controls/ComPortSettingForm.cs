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

        }

        /// <summary>
        /// Метод для измение темы данной формы
        /// </summary>
        /// <param name="isLightTheme"></param>
        public void ChangeTheme(bool isLightTheme)
        {
            if (isLightTheme)
            {
                themeChanger.ChangeToLight(this);
                return;
            }
            themeChanger.ChangeToDark(this);
        }

        /// <summary>
        /// Изменяет состояние формы при повторном её отображении
        /// </summary>
        /// <param name="isConnected"></param>
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

        /// <summary>
        /// Событие по закрытию этой формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {           
            this.Hide();
            Switcher.Invoke();
        }

        #region DraggingMethods
      
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
        #endregion


        /// <summary>
        /// Событие, которое обновляет список доступных COM-порт'ов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            cmbxComPorts.Items.Clear();
            cmbxComPorts.Items.AddRange(SerialPort.GetPortNames());

        }

        /// <summary>
        /// Событие, которе обрабатывает подключени к выбраному COM-порт'у
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnCom_Click(object sender, EventArgs e)
        {

            bool isComplete = InitialComPort();

            if (!isComplete) return;

            _comPortWorker.ConnectToPort(out bool isSuccessful);
            if (!isSuccessful) return;

            string displayStatus = $"Подключен к порту: {_comPortWorker.ComPort.PortName}";
            ChangeLabelState(Color.FromArgb(76, 175, 80), displayStatus);

            btnOnCom.Enabled = false;
            btnClose.Enabled = true;


        }

        /// <summary>
        /// Инициализирует обьект, который отвечает за работу с COM-порт'ом
        /// </summary>
        /// <returns></returns>
        private bool InitialComPort()
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

            if (!ComPortWorker.isInitialize)           
                return false;

            return true;
        }

        /// <summary>
        /// Отключается от порта 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOffCom_Click(object sender, EventArgs e)
        {
            _comPortWorker.DisconnectFromPort(out bool isSuccessful);

            if (!isSuccessful)
                return;

            btnOnCom.Enabled = true;
            ChangeLabelState(Color.FromArgb(255, 84, 84), $"Не подключен");

            btnClose.Enabled = false;
        }

        /// <summary>
        /// Изменяет цвет и контент строки, которая представляет состояние приложения
        /// </summary>
        /// <param name="color"></param>
        /// <param name="displayedStatus"></param>
        private void ChangeLabelState(Color color, string displayedStatus)
        {
            stateText.ForeColor = color;
            stateText.Text = displayedStatus;
        }

    }
}
