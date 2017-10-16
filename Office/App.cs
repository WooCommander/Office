using Office.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    public  class App
    {
        public ListOficeObjects<OfficeElement> Objects { get; set; }
        public IEcran Ecran { get; set; }
        public IFile File { get; set; }
        public IDB DBase { get; set; }
        
        public App(IEcran ecran)
        {
            Objects = new ListOficeObjects<OfficeElement>();
            Ecran = ecran;
            Ecran.Elements = Objects;
        }

        public App(IFile file)
        {
            Objects = new ListOficeObjects<OfficeElement>();
            File = file;
            File.Elements = Objects;
        }

        public App(IDB dBase)
        {
            Objects = new ListOficeObjects<OfficeElement>();
            DBase = dBase;
            DBase.Elements = Objects;
        }


    }
}
