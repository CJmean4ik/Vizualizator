namespace Vizualizator.Theme
{
    public interface IThemeChanger<T> where T : class, new()
    {
        void ChangeToDark(T form);
        void ChangeToLight(T form);
    }

   
}
