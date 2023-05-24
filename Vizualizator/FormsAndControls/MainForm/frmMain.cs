using Vizualizator.DataBase.OleProvider;
using Vizualizator.FormsAndControls.Controls;
using Vizualizator.Theme;
using Vizualizator.Theme.Images.ImageBinder;

namespace FormsAndControls.MainForm.Vizualizator
{
    public partial class frmMain : Form
    {
        private Point _clickPoint;
        private Point _formStartPoint;

        private FormThemeChanger themeChanger;
        private ComPortSettingForm _comPortSetting;
        public OleDataBase DataBase { get; set; }

        private bool isMousePress;
        private bool isLightTheme;
        private bool _isConnected;

        public frmMain()
        {
            InitializeComponent();
            themeChanger = new FormThemeChanger(new ButtonImageBinder(this), new LabelImageBinder(this));
            _comPortSetting = new ComPortSettingForm(isLightTheme);
            _comPortSetting.Switcher = SwitchEnable;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        #region DraggingForm


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

        #endregion

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSelectDB_Click(object sender, EventArgs e)
        {
            DataBase = new OleDataBase();
            selectDataBaseFile.ShowDialog();
            DataBase.FilePath = selectDataBaseFile.FileName;
            DataBase.CreateConnectionString();

            DataBase.CreateOleDbConnection();

            await DataBase.OpenConnectAsync();
            stateText.ForeColor = Color.FromArgb(76, 175, 80);
            stateText.Text = $"Подключен к {selectDataBaseFile.SafeFileName}";
        }
        private void themeButton_Click(object sender, EventArgs e)
        {
            if (!isLightTheme)
            {
                themeChanger.ChangeToLight(this);
                themeChanger.ChangeToDarkImage();
                isLightTheme = true;
                return;
            }
            if (isLightTheme)
            {
                themeChanger.ChangeToDark(this);
                themeChanger.ChangeToLightImage();
                isLightTheme = false;
                return;
            }

        }
        private async void btnOnData_Click(object sender, EventArgs e)
        {
            if (DataBase == null)
            {
                MessageBox.Show("\n Бд не подключена!");
                return;
            }
            await DataBase.CloseConnectAsync();
            stateText.ForeColor = Color.FromArgb(255, 128, 0);
            stateText.Text = "В ожидании";
            DataBase = null;
        }
        private void btnWorkWithComPort_Click(object sender, EventArgs e)
        {
            if (_comPortSetting == null)

            _comPortSetting.SwitcherStateForm(_comPortSetting._comPortWorker?.ComPort?.IsOpen);

            _comPortSetting.ChangeTheme(isLightTheme);

            _comPortSetting.Show();
        }
        private void SwitchEnable()
        {
            if (this.Enabled == true)
            {
                this.Enabled = false;
                return;
            }
            this.Enabled = true;
        }
    }
}