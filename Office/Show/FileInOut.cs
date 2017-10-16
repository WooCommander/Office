using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Office
{
    /// <summary>
    /// Класс для записи и считывания в файл
    /// </summary>
    class FileInOut : IFile
    {
        public ListOficeObjects<OfficeElement> Elements { get; set; }

        public void Load(string fileName)
        {
            try
            {
                using (BinaryReader readerStream = new BinaryReader(File.Open(fileName, FileMode.OpenOrCreate)))
                {

                    while (readerStream.PeekChar() > -1)
                    {
                        string fullName = readerStream.ReadString();

                        Assembly asm = Assembly.GetExecutingAssembly();
                        Type t = asm.GetType(fullName, true, true);

                        OfficeElement obj = (OfficeElement)Activator.CreateInstance(t, true);
                        obj.Load(readerStream);
                        if (obj.Parent == "")
                        {
                            Elements.Add(obj);
                        }
                        else
                            ((Computer)(Elements.Last<OfficeElement>())).ComplectList.Add(obj);
                    };
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void Save(string fileName)
        {
            try
            {
                using (BinaryWriter writerStream = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
                {
                    foreach (OfficeElement item in Elements)
                    {
                        item.Save(writerStream);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
