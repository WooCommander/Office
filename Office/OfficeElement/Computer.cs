using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Office
{
    class Computer: OfficeElement
    {
        private Computer()
        {
            ComplectList = new List<OfficeElement>();
            
        }

        public Computer( string marka, string model, int year, string sn, double price, DateTime garantiya, DateTime dateVvoda, string parent) :base(marka,model,year,sn,  price,  garantiya, parent)
        {
            this.DateVvoda = dateVvoda;
            ComplectList = new List<OfficeElement>();
        }
        public List<OfficeElement> ComplectList { get; set; }
        
        /// <summary>
        /// Дата ввода в эксплуатацию компьютера
        /// </summary>
        public DateTime DateVvoda { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public override void Load(BinaryReader stream)
        {
            base.Load(stream);
            this.DateVvoda = Convert.ToDateTime(stream.ReadString());

            foreach (var ii in this.ComplectList)
            {
                ii.Load(stream);
            }
        }

        public override void Save(BinaryWriter stream)
        {
            base.Save(stream);
            stream.Write(DateVvoda.ToString());
            foreach (var ii in this.ComplectList)
            {
                ii.Save(stream);
            }

        }

        public override string ToString()
        {
            return "Компьютер";
        }
    }
}
