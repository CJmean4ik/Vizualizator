using System.Data.OleDb;
using Vizualizator.DataBase.OleProvider.Interfaces;

namespace Vizualizator.DataBase.OleProvider
{
    /// <summary>
    /// Класс для подключения к БД
    /// </summary>
    public class OleDataBase : IOLEDataBaseConfig
    {
        public string FilePath{ get; set; }
        public string ConnectionString { get; set; }
        public OleDbConnection OleDb { get; set; }

        /// <summary>
        /// Создает строку подключения для OleDbConnection
        /// </summary>
        public void CreateConnectionString()
        {
            if (FilePath == "")
            {
                MessageBox.Show("Невозможно создать строку подключения из пустого пути!");
                return;
            }

            ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FilePath};";
        
        }

        /// <summary>
        /// Создает обьект подключения к БД
        /// </summary>
        public void CreateOleDbConnection()
        {
            if (OleDb == null)
            {
                if (ConnectionString == "")
                {
                    MessageBox.Show("Строка подключени является пустой");
                    return;
                }

                //Обьект подключения
                OleDb = new OleDbConnection(ConnectionString);
                return;
            }
        }

        /// <summary>
        /// Подключается к выбранной БД
        /// </summary>
        /// <returns></returns>
        public async Task OpenConnectAsync()
        {
            if (OleDb.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    await OleDb.OpenAsync();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n Не удалось подключиться, проверьте: существует ли такой файл");
                }
            }
        }

        /// <summary>
        /// Закрывает существующее подключения к БД
        /// </summary>
        /// <returns></returns>
        public async Task CloseConnectAsync()
        {
            try
            {
                if (OleDb == null)
                {
                    MessageBox.Show("\n Бд не подключена!");
                    return;
                }
                
                if (OleDb.State == System.Data.ConnectionState.Open)
                {
                    await OleDb.CloseAsync();
                    return;
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Не удалось отключиться от БД");
            }
            
        }

    }
}
