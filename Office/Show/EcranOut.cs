using System;
using System.Collections.Generic;

namespace Office
{
    /// <summary>
    /// Класс для вывода на экран
    /// </summary>
    class EcranOut : IEcran
    {
        /// <summary>
        /// свойство записи чтения списка элементов
        /// </summary>
        public ListOficeObjects<OfficeElement> Elements { get; set; }

        public void ShowOfficeElementsDefault()
        {
            foreach (var item in Elements)
            {

                Console.WriteLine($"Название:{item.ToString(),20} SN:{item.SN,10} Марка:{item.Marka,10} Модель:{item.Model,10} Год:{item.Year,4}");

            }
        }

        public void ShowSimpleBu()
        {
            foreach (var item in Elements)
            {

                Console.WriteLine($"Название:{item.ToString() + "," + item.Marka + "," + item.Model,25} Цена:{item.Price,6}");

            }
            Console.WriteLine("_______________________________________________");
            Console.WriteLine($"\t\t\t\t итого: {Elements.S()}");
        }

        public void ShowOfficeElementsShort()
        {
            foreach (var item in Elements)
            {

               // string str1 = item.GetType().FullName;
                //Assembly asm = Assembly.GetExecutingAssembly();

                if (item is Printer)
                {
                    ShowPrint((Printer)item);
                }
                else
                    Console.WriteLine($"Название:{item.ToString(),20} Марка:{item.Marka,10} Модель:{item.Model,10}");

                //Type t = asm.GetType(str1, true, true);

                //T obj = (T)Activator.CreateInstance(t, true);
                //obj.;
                //this.Add(obj);
                Console.WriteLine($"Название:{item.ToString(),20} Марка:{item.Marka,10} Модель:{item.Model,10}");

            }
        }

        private void ShowPrint(Printer print)
        {
            Console.WriteLine($"Название:{print.ToString(),20} Марка:{print.Marka,10} Модель:{print.Model,10} Тип:{((Printer)print).Type}");

        }

        public void ShowOfficeElementsAll()
        {
            foreach (var item in Elements)
            {

                Console.WriteLine($"Название:{item.ToString(),20} SN:{item.SN,10} Марка:{item.Marka,10} Модель:{item.Model,10} Год:{item.Year,4}");

            }
        }

        public void ShowOfficeElementsFormat()
        {
            foreach (var item in Elements)
            {
                Console.WriteLine("_______________________________________________________________________________________");
                Console.WriteLine($"Название:{item.ToString(),20} SN:{item.SN,10} Марка:{item.Marka,10} Модель:{item.Model,10} Год:{item.Year,4}");

            }
            Console.WriteLine("_______________________________________________________________________________________");
        }

        public void SortByName()
        {
            NameComparer nc = new NameComparer();
            Elements.Sort(nc);
        }

        public void ShowEndGarantiya()
        {
            Console.WriteLine("Гарантия закончилась у:");
            Console.WriteLine("_______________________");
            foreach (var item in Elements)
            {

                if (item.Garantiya < DateTime.Today)
                {
                    Console.WriteLine($"  {item.ToString() + ","+ item.Marka + "," + item.Model,25}");
                }

            }
            Console.WriteLine("_______________________________________________________________________________________");
        }

        public void ShowComputersAll()
        {
            Console.WriteLine("Список компьютеров с комплектующими");
            Console.WriteLine("_______________________");
            foreach (var item in Elements)
            {
                
                if (item is Computer)
                {
                    Console.WriteLine($"  {item.Marka,10}");
                    foreach (var ii in ((Computer)item).ComplectList)
                    {
                        Console.WriteLine($"    {ii.ToString() + " " +ii.Marka +" "+ii.Model}");
                    }
                }
                
                
            }
        }

        public void ShowComputersShort()
        {
            Console.WriteLine("Список компьютеров без комплектующих");
            Console.WriteLine("_______________________");
            foreach (var item in Elements)
            {

                if (item is Computer)
                {
                    Console.WriteLine($"  {item.Marka,10}");
                }

            }
        }

        
        class NameComparer : IComparer<OfficeElement>
        {
            public int Compare(OfficeElement o1, OfficeElement o2)
            {


                if (String.Compare(o1.ToString(), o2.ToString()) > 0)
                {
                    return 1;
                }
                else if (String.Compare(o1.ToString(), o2.ToString()) < 0)
                {
                    return -1;
                }

                return 0;
            }
        }
    }
}
