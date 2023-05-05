namespace Vizualizator.Theme
{
    internal interface IThemeChanger<T> where T : class, new()
    {
        void ChangeToDark(T form);
        void ChangeToLight(T form);

    }
}
