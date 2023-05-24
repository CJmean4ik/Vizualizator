using System.Data.OleDb;
using Vizualizator.DataBase.Entity;
using Vizualizator.DataBase.Repository.IRepositories;

namespace Vizualizator.DataBase.Repository.ImplementRepositories
{
    internal class ASUModuleRepository : IFullASUModuleRepository
    {
        private readonly OleDbConnection OleDb;
        public string DataBaseName { get; set; }
        public ASUModuleRepository(OleDbConnection oleDb)
        {
            OleDb = oleDb;
        }

        public List<FullASUModule> GetAll()
        {
            List<FullASUModule> asuModuleList = new List<FullASUModule>();

            if (OleDb == null)
            {
                MessageBox.Show("Нет подключения к БД");
                return asuModuleList;
            }

            try
            {
                string SQL_QUERY = $"SELECT * FROM Описание_АСУ";
                var sqlCommand = new OleDbCommand(SQL_QUERY, OleDb);

                OleDbDataReader oleDbDataReader = sqlCommand.ExecuteReader();

                while (oleDbDataReader.Read())
                {
                    var fullAsuModule = BindFullASUModule(oleDbDataReader);

                    if (fullAsuModule == null) return null;

                    asuModuleList.Add(fullAsuModule);
                }

                return asuModuleList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось считать данные с таблицы Описание_АСУ.Проверьте, к той ли вы БД подключены. Ошибка: {ex.Message}");
                return asuModuleList;
            }

        }

        private FullASUModule BindFullASUModule(OleDbDataReader reader)
        {
            FullASUModule aSUModule = new FullASUModule();
            try
            {
                aSUModule.Code = reader["Код"]?.ToString();
                aSUModule.NumberRecord = reader["Номер записи"]?.ToString();
                aSUModule.NumberLine = reader["Номер линии"]?.ToString();
                aSUModule.NumberPPK = reader["Внутренний номер в ППК"]?.ToString();
                aSUModule.FactoryNumber = reader["Заводской номер"]?.ToString();
                aSUModule.CommandASU = reader["Команда АСУ"]?.ToString();
                aSUModule.TypeASU = reader["Тип АСУ"]?.ToString();
                aSUModule.NumberAutomatedControl = reader["Номер линии управляющего АСУ"]?.ToString();
                aSUModule.AddresManagerASU = reader["Адрес управляющего АСУ"]?.ToString();
                aSUModule.RelatedAddresASU = reader["Адрес связанного  АСУ"]?.ToString();
                aSUModule.NumberZone = reader["Номер зоны"]?.ToString();
                aSUModule.Timer = reader["Таймер проверки связ АСУ"]?.ToString();
                aSUModule.TransitionLevel = reader["Уровень перехода пожар/норма"]?.ToString();
                aSUModule.DescriptionZone = reader["Описание зоны"]?.ToString();
                aSUModule.NumberImage = reader["Номер рисунка"]?.ToString();
                aSUModule.CordinateASU = reader["Координаты оборудования"]?.ToString();
                return aSUModule;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось достать данные из таблицы. Ошибка:" + ex.Message);
                return null;
            }
        }
        public List<FullASUModule> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
