using System;
using System.IO;

namespace Office
{
    /// <summary>
    /// Монитор
    /// </summary>
    class Monitor : OfficeElement
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
       private Monitor()
        {

        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="model"></param>
        /// <param name="marka"></param>
        /// <param name="year"></param>
        /// <param name="monitorT"> led, трубка</param>
        public Monitor(string marka, string model, int year, string sn,string monitorT, double price, DateTime garantiya, string parent) :base(  marka,  model,  year,  sn,  price,  garantiya, parent)
        {
            this.MonitorType = monitorT;

        }

        /// <summary>
        /// Тип монитора
        /// </summary>
        public string MonitorType { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public override void Load(BinaryReader stream)
        {
            base.Load(stream);
            this.MonitorType = stream.ReadString();
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="stream"></param>
        public override void Save(BinaryWriter stream)
        {
            base.Save(stream);
            stream.Write(MonitorType);
        }

        //public override void Print()
        //{
        //    base.Print();
        //    Console.WriteLine($" Тип монитора:{MonitorType}");
        //}

        public override string ToString()
        {
            return "Монитор";
        }
    }
}
