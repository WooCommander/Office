namespace Office
{
    /// <summary>
    /// Интерфейс работы с экраном монитора
    /// </summary>
    public interface IEcran
    {
        ListOficeObjects<OfficeElement> Elements { get; set; }
        
        void ShowOfficeElementsDefault();
        void ShowOfficeElementsShort();
        void ShowOfficeElementsAll();
        void ShowOfficeElementsFormat();
        void SortByName();
        void ShowSimpleBu();
        void ShowEndGarantiya();
        void ShowComputersAll();
        void ShowComputersShort();


    }
}
