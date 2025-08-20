namespace Internship_Finding_Program_Student
{
    class Hobiler
    {
        public object inghobi()
        {
            string hobi = "Choose Your Hobbies";
            return hobi;
        }

        public virtual object hobi()
        {
            string hobi = "Hobilerini Seç";
            return hobi;
        }
    }


    class Gym : Hobiler
    {
        public override object hobi()
        {
            string hobi = "Gym";
            return hobi;
        }

    }
    class Yuzmek : Hobiler
    {
        public override object hobi()
        {
            string hobi = "Yüzmek";
            return hobi;
        }

    }
    class Yuzmeking : Hobiler
    {
        public override object hobi()
        {
            string hobi = "Swimming";
            return hobi;
        }

    }
    class Kitap : Hobiler
    {
        public override object hobi()
        {
            string hobi = "Kitap Okumak";
            return hobi;
        }
    }
    class Kitaping : Hobiler
    {
        public override object hobi()
        {
            string hobi = "Reading books";
            return hobi;
        }
    }
    class Film : Hobiler
    {
        public override object hobi()
        {
            string hobi = "Film İzlemek";
            return hobi;
        }
    }
    class Filming : Hobiler
    {
        public override object hobi()
        {
            string hobi = "Watching Movies";
            return hobi;
        }
    }
    class Resim : Hobiler
    {
        public override object hobi()
        {
            string hobi = "Resim Çizmek";
            return hobi;
        }
    }
    class Resiming : Hobiler
    {
        public override object hobi()
        {
            string hobi = "Drawing a Picture";
            return hobi;
        }
    }
}
