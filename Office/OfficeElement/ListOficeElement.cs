using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Office
{
    public class ListOficeObjects<T> : List<T> where T : OfficeElement

    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <returns></returns>
        public int S<T1>() where T1 : OfficeElement
        {
            
            return this.Count(_ => _ is T1);
        }

        //public double P()
        //{

        //    return this.Sum(_ => _.S());
        //}
        public double S()
        {

            return this.Sum(_ => _.Price);
        }

        private object Where(object p)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Выгрузка списка объектов в файл
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        //public void Save(string fileName)
        //{

        //    try
        //    {
        //        using (BinaryWriter writerStream = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
        //        {
        //            foreach (OfficeElement s in this)
        //            {
        //                writerStream.Write(s.GetType().FullName);
        //                s.Save(writerStream);
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}

        ///// <summary>
        ///// Загрузка данных из файла
        ///// </summary>
        ///// <param name="fileName">Имя файла</param>
        //public void Load(string fileName)
        //{

        //    try
        //    {
        //        using (BinaryReader readerStream = new BinaryReader(File.Open(fileName, FileMode.Open)))
        //        {
        //            while (readerStream.PeekChar() > -1)
        //            {
        //                string fullName = readerStream.ReadString();

        //                Assembly asm = Assembly.GetExecutingAssembly();
        //                Type t = asm.GetType(fullName, true, true);

        //                T obj = (T)Activator.CreateInstance(t, true);
        //                obj.Load(readerStream);
        //                this.Add(obj);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}


    }
}

