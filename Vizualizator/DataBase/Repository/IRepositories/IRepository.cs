namespace Vizualizator.DataBase.Repository.IRepositories
{
    public interface IRepository<T> where T : class
    {
        T GetAll();
        T GetById(int id);
    }
}
