using System.Data.OleDb;
using Vizualizator.DataBase.Entity;
using Vizualizator.DataBase.Repository.IRepositories;

namespace Vizualizator.DataBase.Repository.ImplementRepositories
{
    internal class ASUModuleRepository : IASUModuleRepository
    {
        private readonly OleDbConnection OleDb;

        public ASUModuleRepository(OleDbConnection oleDb)
        {
            OleDb = oleDb;
        }

        public List<ASUModule> GetAll()
        {
            if (OleDb == null)
            {
                MessageBox.Show("Нет подключения к БД");
                return new List<ASUModule>();
            }

            return default;


            
        }

        public List<ASUModule> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
