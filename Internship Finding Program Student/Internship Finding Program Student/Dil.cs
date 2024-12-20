namespace Internship_Finding_Program_Student
{
    class Language
    {
        public string dil { get; set; } //Burada Kapsülleme kullandım.
        public override string ToString()
        {
            return dil = "Türkçe";
        }
    }
    class English : Language
    {
        public override string ToString()
        {
            return dil = "English";
        }
        //Main kısımda dil değitirmenin içerisine dillerin isimlerini yazdırmak için class kullandım
    }

}
