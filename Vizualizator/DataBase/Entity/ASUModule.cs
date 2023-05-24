namespace Vizualizator.DataBase.Entity
{
    /// <summary>
    /// Сущность которая представляет собою набор данных от ППК
    /// </summary>
    public class ASUModule
    {
        public string TypeASU { get; set; }
        public string NumberLine { get; set; }
        public string NumberPPK { get; set; }
        public string DescriptionZone { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
