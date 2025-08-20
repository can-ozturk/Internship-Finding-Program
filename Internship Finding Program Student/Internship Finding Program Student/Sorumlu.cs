using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_Finding_Program_Student
{

    abstract class Durumlar
    {
       
        public abstract string HesapDurumu();

      
        public string HesapDurumuBaslik()
        {
            return "Aktif / Pasif";
        }
        public string HesapDurumuBaslikING()
        {
            return "Active / Passive";
        }
        public string HesapKabulBaslik()
        {
            return "Kabul Durumu";
        }
        public string HesapKabulBaslikING()
        {
            return "Acceptance Status";
        }
    }

   
    class Aktif : Durumlar
    {
       
        public override string HesapDurumu()
        {
            return "Aktif";
        }

    }

    class Pasif : Durumlar
    {

        public override string HesapDurumu()
        {
            return "Pasif";
        }

    }


    class KabulEdilmedi : Durumlar
    {
      
        public override string HesapDurumu()
        {
            return "Kabul Edilmedi";
        }
    }
    class KabulDurumuYok : Durumlar
    {

        public override string HesapDurumu()
        {
            return "Kabul Durumu Yok";
        }
    }
    class KabulEdildi : Durumlar
    {

        public override string HesapDurumu()
        {
            return "Kabul Edildi";
        }
    }

}


