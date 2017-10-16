namespace Office
{
    /// <summary>
    /// Интерфес для вывода на принтер
    /// </summary>
    public interface IPrinter
    {
        ListOficeObjects<OfficeElement> Elements { get; set; }
        /// <summary>
        /// Показать на экране
        /// </summary>



    }
}
