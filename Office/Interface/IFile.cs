namespace Office
{
    /// <summary>
    /// Интерфейс работы с файлом
    /// </summary>
    public interface IFile
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
