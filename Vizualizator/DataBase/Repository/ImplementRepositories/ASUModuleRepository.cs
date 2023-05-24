using System.Data.OleDb;
using Vizualizator.DataBase.Entity;
using Vizualizator.DataBase.Repository.IRepositories;

namespace Vizualizator.DataBase.Repository.ImplementRepositories
{
    /// <summary>
    /// Класс-репозиторий. Содержит операцию по получению списка сущностей FullASUModule
    /// </summary>
    internal class ASUModuleRepository : IFullASUModuleRepository
    {
        private readonly OleDbConnection OleDb;
        public string DataBaseName { get; set; }
        public ASUModuleRepository(OleDbConnection oleDb)
        {
            OleDb = oleDb;
        }

        /// <summary>
        /// Возвращает все сущности типа FullASUModule которые содержат данные из подключенной БД
        /// </summary>
        /// <returns></returns>
        public List<FullASUModule> GetAll()
        {
            //Список сущностей типа FullASUModule
            List<FullASUModule> asuModuleList = new List<FullASUModule>();

            if (OleDb == null)
            {
                MessageBox.Show("Нет подключения к БД");
                return asuModuleList;
            }

            try
            {
                //Создаём строку запроса и обьект типа OleDbCommand для выполнения этой строки запроса 
                string SQL_QUERY = $"SELECT * FROM Описание_АСУ";
                var sqlCommand = new OleDbCommand(SQL_QUERY, OleDb);

                //Получаем обьект, который содержит полученые данные
                OleDbDataReader oleDbDataReader = sqlCommand.ExecuteReader();

                //Запускаем цикл по считыванию данных с нашего обьекта
                while (oleDbDataReader.Read())
                {
                    //Получаем заполненую сущность
                    var fullAsuModule = BindFullASUModule(oleDbDataReader);

                    if (fullAsuModule == null) return null;

                    //Добовляем в наш список
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

        /// <summary>
        /// Создает сущность типа FullASUModule, считывает необходимые данные по схеме и привязывает данные к сущности
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>Заполненая данными сущность</returns>
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
