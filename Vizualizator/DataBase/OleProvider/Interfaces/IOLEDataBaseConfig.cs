namespace Vizualizator.DataBase.OleProvider.Interfaces
{
    internal interface IOLEDataBaseConfig : IDataBaseConfig
    {
        public string FilePath { get; set; }
    }
}
