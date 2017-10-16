namespace Office
{
    /// <summary>
    /// Интерфейс работы базой данных
    /// </summary>
    public interface IDB
    {
        ListOficeObjects<OfficeElement> Elements { get; set; }
        /// <summary>
        /// Сохранить в файл
        /// </summary>
        void Save(string fileName);



        /// <summary>
        /// Загрузить из файла
        /// </summary>
        void Load(string fileName);




    }
}
