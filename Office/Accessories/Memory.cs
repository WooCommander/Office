using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Memory : OfficeElement
    {
        private Memory() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="marka"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="sn"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
        public Memory(string marka, string model, int year, string sn,int value, string type, double price, DateTime garantiya, string parent) :base(marka,model,year,sn, price, garantiya,parent)
        {

            this.Value = value;
            this.Type = type;

        }
        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($" Размер:{Value,10} Тип:{Type}");
        //}
        /// <summary>
        /// Размер памяти
        /// 3000
        /// 2000
        /// 8000
        /// </summary>
        public int Value { get; private set; }

        /// <summary>
        /// Тип памяти
        /// ddr3
        /// ddr5
        /// ddr2
        /// </summary>
        public string Type { get; private set; }


        public override void Save(BinaryWriter stream)
        {
            base.Save(stream);

            stream.Write(Type);
            stream.Write(Value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public override void Load(BinaryReader stream)
        {
            base.Load(stream);

            this.Type = stream.ReadString();
            this.Value = stream.ReadInt32();
        }
        public override string ToString()
        {
            return "Память";
        }
    }
}
