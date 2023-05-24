namespace Vizualizator.DataBase.Entity
{
    /// <summary>
    /// Сущность, которая представляет таблицу "Описание_АСУ"
    /// </summary>
    internal class FullASUModule : ASUModule
    {
        public string Code { get; set; }
        public string NumberRecord { get; set; }
        public string FactoryNumber { get; set; }
        public string CommandASU { get; set; }
        public string NumberAutomatedControl{ get; set; }
        public string AddresManagerASU { get; set; }
        public string RelatedAddresASU { get; set; }
        public string NumberZone { get; set; }
        public string Timer { get; set; }
        public string TransitionLevel { get; set; }
        public string NumberImage { get; set; }
        public string CordinateASU { get; set; }


    }
}
