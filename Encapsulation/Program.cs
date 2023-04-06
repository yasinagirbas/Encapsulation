namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isım = "yasin";
            ogrenci.Soyisim = "agırbaş";
            ogrenci.OgrenciNo = 3;
            ogrenci.Sinif = 4;
            ogrenci.OgrenciBilgilerGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgilerGetir();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isım
        {
            get { return isim; }
            set { isim = value; }

        }

        public string Soyisim
        {
            get => soyisim;
            set => soyisim = value;
        }

        public int OgrenciNo
        {
            get => ogrenciNo;
            set => ogrenciNo = value;
        }

        public int Sinif
        {
            get => sinif;
            set
            {
                if (value<1)
                {
                    Console.WriteLine("Sınif en az 1 olabilir");
                    sinif = 1;
                }
                else

                    sinif = value;
            }
        }

        public Ogrenci(string isim)
        {
            Isım = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;

        }

        public Ogrenci()
        {

        }

        public void OgrenciBilgilerGetir()
        {
            Console.WriteLine("************** Ogrenci bilgileri ************");
            Console.WriteLine("Ogrenci adı : {0} ", this.Isım);
            Console.WriteLine("Ogrenci Soyadı : {0} ", this.Soyisim);
            Console.WriteLine("Ogrenci No : {0} ", this.ogrenciNo);
            Console.WriteLine("Sınıf : {0} ", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.sinif = this.sinif+1;
        }
        public void SinifDusur()
        {
            this.sinif = this.sinif -1;
        }
    }
}


