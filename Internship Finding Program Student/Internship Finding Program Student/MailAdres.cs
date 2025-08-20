using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_Finding_Program_Student
{
    class MailAdresileri
    {
        public string MailBaslık()
        {
            return "MAİL ADRESLERİ";
        }
        public string MailBaslıkING()
        {
            return "EMAIL ADDRESSES";
        }
    }
    class MailAdresler
    {
        public enum Cesit
        {
            Canoztr = 0,
            Emntmbl = 1,
            Talhktn = 2,
            Berkayylz = 3,
            Tarkksl = 4
        }

        public static string Mailler(Cesit cesit)
        {
            switch (cesit)
            {
                case Cesit.Canoztr:
                    return "canoztr@gmail.com";
                case Cesit.Emntmbl:
                    return "emntmbl@gmail.com";
                case Cesit.Talhktn:
                    return "talhktn@gmail.com";
                case Cesit.Berkayylz:
                    return "berkayylz@gmail.com";
                case Cesit.Tarkksl:
                    return "tarkksl@gmail.com";
                default:
                    return "Bilinmeyen";
            }
        }
    }

}
