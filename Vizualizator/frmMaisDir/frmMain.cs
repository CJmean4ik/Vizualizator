using Vizualizator.DataBase.OleProvider;
using Vizualizator.Theme;
using Vizualizator.Theme.Images.ImageBinder;

namespace Vizualizator
{
    public partial class frmMain : Form
    {
        private bool isMousePress;
        private Point _clickPoint;
        private Point _formStartPoint;
        private IThemeChanger<Control> themeChanger;
        private bool isLightTheme;
        public OleDataBase DataBase { get; set; }
        public frmMain()
        {
            InitializeComponent();
            themeChanger = new FormThemeChanger(new ButtonImageBinder(this), new LabelImageBinder(this));

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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private async void btnOnData_Click(object sender, EventArgs e)
        {
            await DataBase.CloseConnectAsync();
            stateText.ForeColor = Color.FromArgb(255, 128, 0);
            stateText.Text = "В ожидании";
            DataBase = null;
        }
    }
}