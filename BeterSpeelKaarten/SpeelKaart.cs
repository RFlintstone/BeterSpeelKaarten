namespace BeterSpeelKaarten
{
    public class SpeelKaart
    {
        //properties

        Symbool symbool;
        Personage personage;
        int waarde;
        bool isZichtbaar;
        private int i;
        private int soort;
        private bool v;
        private Personage boer;

        //constructor
        public SpeelKaart(int Waarde, Symbool Symbool, bool IsZichtbaar, Personage Personage)
        {
            waarde = Waarde;
            symbool = Symbool;
            isZichtbaar = IsZichtbaar;
            personage = Personage;
        }

        public SpeelKaart(int i, int soort, bool v)
        {
            this.i = i;
            this.soort = soort;
            this.v = v;
        }

        public SpeelKaart(int i, int soort, bool v, Personage boer) : this(i, soort, v)
        {
            this.boer = boer;
        }

        //Get set
        public int Waarde { get; set; }
        public Symbool Symbool { get; set; }
        public bool IsZichtbaar { get; set; }
        public Personage Personage { get; set; }

    }
}

//namespace BeterSpeelKaarten
//{
//    public class SpeelKaart
//    {
//        //properties
//        int waarde;
//        Symbool symbool;
//        bool isZichtbaar;
//        Personage personage;
//        private int i;
//        private int soort;
//        private bool v;
//        private Personage boer;
//        private Personage koningin;


//        //constructor
//        //public SpeelKaart(int waarde, Symbool symbool, bool isZichtbaar)
//        //{ }
//        public SpeelKaart(int i, int soort, bool v, Personage koningin)
//        {
//            this.i = i;
//            this.soort = soort;
//            this.v = v;
//            this.koningin = koningin;
//        }

//        //public Waarde = waarde;
//        //Symbool = symbool;
//        //IsZichtbaar = isZichtbaar;
//        //}

//        //public SpeelKaart(int waarde, Symbool symbool, bool isZichtbaar, Personage personage)
//        //{ }
//        //    public Waarde = waarde;
//        //    public Symbool = symbool;
//        //    public IsZichtbaar = isZichtbaar;
//        //    public Personage = personage;
//        //}

//        public SpeelKaart(int i, int soort, bool v, Personage boer)
//        {
//            this.i = i;
//            this.soort = soort;
//            this.v = v;
//            this.boer = boer;
//        }

//        public SpeelKaart(int i, int soort, bool v)
//        {
//            this.i = i;
//            this.soort = soort;
//            this.v = v;
//        }

//    //public bool IsZichtbaar { get; set; }
//    //public int Waarde { get; set; }

//        public int Waarde
//        {
//            get => waarde;
//            set => waarde = value;
//        }

//        public Symbool Symbool
//        {
//            get => symbool;
//            set => symbool = value;
//        }

//        public bool IsZichtbaar
//        {  
//            get => isZichtbaar;
//            set => isZichtbaar = value;
//        }

//        public Personage Personage
//        {
//            get => personage;
//            set => personage = value;
//        }
//    }
//}//End class


//    } //End namespace