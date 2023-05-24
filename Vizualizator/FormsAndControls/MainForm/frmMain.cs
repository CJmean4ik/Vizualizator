using System.Reflection;
using Vizualizator.DataBase.Entity;
using Vizualizator.DataBase.OleProvider;
using Vizualizator.DataBase.Repository.ImplementRepositories;
using Vizualizator.FormsAndControls.Controls;
using Vizualizator.Theme;
using Vizualizator.Theme.Images.ImageBinder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsAndControls.MainForm.Vizualizator
{
    public partial class frmMain : Form
    {
        private Point _clickPoint;
        private Point _formStartPoint;

        private FormThemeChanger themeChanger;
        private ComPortSettingForm _comPortSetting;
        private ASUModuleRepository asuModulerepository;
        public OleDataBase DataBase { get; set; }

        private bool isMousePress;
        private bool isLightTheme;
        private bool _isAddedData;

        public frmMain()
        {
            InitializeComponent();
            themeChanger = new FormThemeChanger(new ButtonImageBinder(this), new LabelImageBinder(this));
            _comPortSetting = new ComPortSettingForm(isLightTheme);
            _comPortSetting.Switcher = SwitchEnable;

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            convertDataPanel.Visible = false;
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

        /// <summary>
        /// Событие по закрытию главное формы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Событие по выборке БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSelectDB_Click(object sender, EventArgs e)
        {
            DataBase = new OleDataBase();

            selectDataBaseFile.ShowDialog();
            DataBase.FilePath = selectDataBaseFile.FileName;

            DataBase.CreateConnectionString();
            DataBase.CreateOleDbConnection();

            await DataBase.OpenConnectAsync();

            string displayedStatus = $"Подключен к {selectDataBaseFile.SafeFileName}";
            ChangeLabelState(Color.FromArgb(76, 175, 80), displayedStatus);

            asuModulerepository = new ASUModuleRepository(DataBase.OleDb);
        }

        /// <summary>
        /// Событие по изменение темы формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Событие по отключению от БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnOnData_Click(object sender, EventArgs e)
        {
            if (DataBase == null)
            {
                MessageBox.Show("\n Бд не подключена!");
                return;
            }
          
            await DataBase.CloseConnectAsync();

            ChangeLabelState(Color.FromArgb(255, 128, 0), "В ожидании");

            dataGridView2.Rows.Clear();

            DataBase = null;
        }

        /// <summary>
        /// Событие которое позволяет открыть форму для настройки подключения к COM-порту`у
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkWithComPort_Click(object sender, EventArgs e)
        {
            if (_comPortSetting == null) return;

            SwitchEnable();
            _comPortSetting.SwitcherStateForm(_comPortSetting._comPortWorker?.ComPort?.IsOpen);

            _comPortSetting.ChangeTheme(isLightTheme);

            _comPortSetting.Show();
        }

        /// <summary>
        /// Переключатель активности формы
        /// </summary>
        private void SwitchEnable()
        {
            if (this.Enabled == true)
            {
                this.Enabled = false;
                return;
            }
            this.Activate();
            this.Enabled = true;
        }

        /// <summary>
        /// Изменяет цвет и контент строки, которая представляет состояние приложения
        /// </summary>
        /// <param name="color"></param>
        /// <param name="displayedStatus"></param>
        private void ChangeLabelState(Color color, string displayedStatus)
        {
            stateText.ForeColor = color;
            stateText.Text = displayedStatus ;
        }

        /// <summary>
        /// Метод по отображению данных из БД на dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnConvertDB_Click(object sender, EventArgs e)
        {
            //Показать таблицу, если она уже была заполненой
            if (_isAddedData)
            {             
                ShowConvertDataPanel();
                return;
            }
            //Иначе заполнить её 
            try
            {
                if (asuModulerepository == null)
                {
                      MessageBox.Show("Репозиторий который должен был считать данные с таблицы, не был проинициализирован.\nПроверьте" +
                    "Подключение к БД ");
                    return;
                }            
                //Получаем список сущностей для отображения их в dataGridView
                var models = await Task.Run(() => asuModulerepository.GetAll());

                if (models == null)
                {
                    MessageBox.Show("Нет данных для заполения DataGridView (Таблица)");
                    return;
                }

                //Добавляем их всех в dataGridView
                dataGridView2.Rows.Add(models.Count);
                await Task.Run(() => InsertDataToCells(models));

                _isAddedData = true;
                ShowConvertDataPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        /// <summary>
        /// Метод, который вставляет данные из списка сущностей в dataGridView
        /// </summary>
        /// <param name="models"></param>
        private void InsertDataToCells(List<FullASUModule> models)
        {
            int COUT_ROWS = models.Count;
           
            for (int j = 0; j < COUT_ROWS; j++)
            {     
                dataGridView2.Rows[j].Cells[0].Value = models[j].Code;
                dataGridView2.Rows[j].Cells[1].Value = models[j].NumberRecord;
                dataGridView2.Rows[j].Cells[2].Value = models[j].NumberLine;
                dataGridView2.Rows[j].Cells[3].Value = models[j].NumberPPK;
                dataGridView2.Rows[j].Cells[4].Value = models[j].FactoryNumber;
                dataGridView2.Rows[j].Cells[5].Value = models[j].CommandASU;
                dataGridView2.Rows[j].Cells[6].Value = models[j].TypeASU;
                dataGridView2.Rows[j].Cells[7].Value = models[j].NumberAutomatedControl;
                dataGridView2.Rows[j].Cells[8].Value = models[j].AddresManagerASU;
                dataGridView2.Rows[j].Cells[9].Value = models[j].RelatedAddresASU;
                dataGridView2.Rows[j].Cells[10].Value = models[j].NumberZone;
                dataGridView2.Rows[j].Cells[11].Value = models[j].Timer;
                dataGridView2.Rows[j].Cells[12].Value = models[j].TransitionLevel;
                dataGridView2.Rows[j].Cells[13].Value = models[j].DescriptionZone;
                dataGridView2.Rows[j].Cells[14].Value = models[j].NumberImage;
                dataGridView2.Rows[j].Cells[15].Value = models[j].CordinateASU;
            }
  
        }

        /// <summary>
        /// Убирает панель, которая содержит dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            HideConvertDataPanel();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}