using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    class Cpu : OfficeElement
    {
        private Cpu() { }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="marka"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="sn"></param>
        /// <param name="index"></param>
        public Cpu(string marka, string model, int year, string sn, string index, double price, DateTime garantiya, string parent) :base(marka,model,year,sn, price, garantiya, parent)
        {

            this.Index = index;
        }
        /// <summary>
        /// Индех процессора 
        /// I3
        /// I5
        /// I7
        /// </summary>
        public string Index { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public override void Load(BinaryReader stream)
        {
            base.Load(stream);

            this.Index = stream.ReadString();
            
        }

        public override void Save(BinaryWriter stream)
        {
            base.Save(stream);

            stream.Write(Index);

        }

        public override string ToString()
        {
            return "Процессор";
        }
    }
}
