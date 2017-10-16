using System;
using System.IO;

namespace Office
{
    /// <summary>
    /// Принтер
    /// </summary>
    class Printer : OfficeElement
    {

        private Printer()
        {

        }
        public Printer(string marka, string model, int year, string sn, string type, double price, DateTime garantiya, string parent) : base(marka, model, year, sn,price,garantiya, parent)
        {
            this.Type = type;
        }
        /// <summary>
        /// тип принтера
        /// Матричный
        /// Лазерный
        /// Струйный
        /// 3d
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public override void Load(BinaryReader stream)
        {
            base.Load(stream);
            this.Type = stream.ReadString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public override void Save(BinaryWriter stream)
        {
            base.Save(stream);
            stream.Write(Type);
        }


        public override string ToString() {
            return "Принтер";
        }
    }
}
