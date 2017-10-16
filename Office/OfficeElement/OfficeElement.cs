using System;
using System.IO;

namespace Office
{
    /// <summary>
    /// Общий класс для всей офисной техники
    /// </summary>
    public abstract class OfficeElement
    {

        /// <summary>
        /// Марка 
        /// samsung
        /// cannon
        /// </summary>
        public string Marka { get; protected set; }

        /// <summary>
        /// model m2070
        /// model lbp-1120
        /// model lbp-2900
        /// 
        /// Модель
        /// 
        /// </summary>
        /// 
        public string Model { get; protected set; }

        /// <summary>
        /// sn zt6nhmbb600170p
        /// 
        /// </summary>
        public string SN { get; protected set; }

        /// <summary>
        /// 2014
        /// 2015
        /// 
        /// Год выпуска
        /// 
        /// </summary>
        public int Year { get; protected set; }

        /// <summary>
        /// дата окончания гарантии
        /// </summary>
        public DateTime Garantiya { get; protected set; }

        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; protected set; }
        
        public string Parent { get; protected set; }
        
        /// <summary>
        /// сохранить объект на диск
        /// </summary>
        /// <param name="stream"> Имя файла вместе с путем откуда загружать данные</param>
        public virtual void Save(BinaryWriter stream)
        {
            stream.Write(this.GetType().FullName);
            stream.Write(Marka);
            stream.Write(Model);
            stream.Write(Year);
            stream.Write(SN);
            stream.Write(Garantiya.ToString());
            stream.Write(Price);
            stream.Write(Parent);
        }

        /// <summary>
        /// Загрузить данные из файла
        /// </summary>
        /// <param name="stream"> Имя файла вместе с путем откуда загружать данные</param>
        public virtual void Load(BinaryReader stream)
        {
            this.Marka = stream.ReadString();
            this.Model = stream.ReadString();
            this.Year = stream.ReadInt32();
            this.SN = stream.ReadString();
            this.Garantiya = Convert.ToDateTime(stream.ReadString());
            this.Price = stream.ReadDouble();
            this.Parent = stream.ReadString();
        }

        public OfficeElement( string marka, string model, int year, string sn, double price, DateTime garantiya, string parent)
        {
            this.Model = model;
            this.Marka = marka;
            this.Year = year;
            this.SN = sn;
            this.Price = price;
            this.Garantiya = garantiya;
            this.Parent=parent;

        }
        //public OfficeElement(OptionParams param)
        //{

        //    this.Name = param.Name;
        //    this.Model = param.Model;
        //    this.Marka = param.Marka;
        //    this.Year = param.Year;
        //    this.SN = param.SN;
        //    this.Price = param.Price;
        //    this.Garantiya = param.Garantiya;

        //}

        public OfficeElement()
        {
            this.Model = "";
            this.Marka = "";
            this.Year = 0;
            this.SN = "";
            this.Price = 0;
            this.Garantiya = DateTime.Today;
            this.Parent = "";
        }

    }


    public class OptionParams
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public int Year { get; set; }
        public string SN { get; set; }
        public double Price { get; set; }
        public DateTime Garantiya { get; set; }

        public string Parent { get; set; }

    }
}
