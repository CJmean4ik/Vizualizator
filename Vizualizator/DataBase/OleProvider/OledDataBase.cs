using System.Data.OleDb;
using Vizualizator.DataBase.OleProvider.Interfaces;

namespace Vizualizator.DataBase.OleProvider
{
    public class OleDataBase : IOLEDataBaseConfig
    {
        public string FilePath{ get; set; }
        public string ConnectionString { get; set; }
        public OleDbConnection OleDb { get; set; }
        public void CreateConnectionString()
        {
            if (FilePath == "")
            {
                MessageBox.Show("Невозможно создать строку подключения из пустого пути!");
                return;
            }

            ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FilePath};";
        
        }
        public void CreateOleDbConnection()
        {
            if (OleDb == null)
            {
                if (ConnectionString == "")
                {
                    MessageBox.Show("Строка подключени является пустой");
                    return;
                }


                OleDb = new OleDbConnection(ConnectionString);
                return;
            }
        }
        public async Task OpenConnectAsync()
        {
            if (OleDb.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    await OleDb.OpenAsync();
                    return;

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message + "\n Не удалось подключиться, проверьте: существует ли такой файл");
                }
            }
        }
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
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message + "\n Не удалось отключиться от БД");
            }
            
        }

    }
}
