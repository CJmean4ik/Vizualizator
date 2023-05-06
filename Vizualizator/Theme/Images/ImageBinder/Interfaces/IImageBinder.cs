namespace Vizualizator.Theme.Images.ImageBinder.Interfaces
{
    public interface IImageBinder<out T, V> where T : class
    {
        public V Control { get; set; }
        T GetSources();
    }
}
