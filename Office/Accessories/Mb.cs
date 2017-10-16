using System;
using System.IO;

namespace Office
{
    /// <summary>
    /// Материнская плата
    /// </summary>
    class MB : OfficeElement
    {
        private MB()
        {
        }
        public MB(string marka, string model,  int year, string sn, double price, DateTime garantiya, string parent) : base(marka, model, year, sn, price, garantiya, parent)
        {

        }

        public override void Save(BinaryWriter stream)
        {
            base.Save(stream);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public override void Load(BinaryReader stream)
        {
            base.Load(stream);
            

        }
        public override string ToString()
        {
            return "Мат.плата";
        }
    }
}
