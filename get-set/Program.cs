using System;

namespace get_set
{

    class ogrenci
    {
        public string Name;
        public string Surname;
        public ulong Number;
        public int YearOfBirth;
        public string Department;
        public int Visa;
        public int Final;
        



        public String department
        {
            get
            {
                return Department;
            }
            set
            {
                Department = value;
            }
        }

        public int visa
        {
            get
            {
                return (int)Visa;
            }
            set
            {
                if (value > 0 && value <= 100 )
                    Visa = value;
                else
                    Console.WriteLine("Vize değeri 0 ile 100 arasında olmalıdır...");
            }
        }

        public int final
        {
            get
            {
                return (int)Final;
            }
            set
            {
                if ((value > 0 && value <= 100))
                    Final = value;
                else
                    Console.WriteLine("Final değeri 0 ile 100 arasında olmalıdır...");
            }
        }

        public ulong  number
        {
            get
            {
                return Number;
            }
            set
            {
                if (value.ToString().Length == 9)
                    Number = value;
                else
                    Console.WriteLine("Okul numarasını eksik girdiniz...");
            }
        }

        public int Age()
        {
            return 2020 - YearOfBirth;
        }
        public Double Average()
        {
            return (Visa * 0.4) + (Final * 0.6);
        }
        public void Bilgi()
        {
            Console.WriteLine("İsim : {0}", Name);
            Console.WriteLine("Soyadı : {0}", Surname);
            Console.WriteLine("Okul Numarası : {0}", Number);
            Console.WriteLine("Bölüm : {0}", Department);
            Console.WriteLine("Yaşı : {0}", Age());
            Console.WriteLine("Ortalaması : {0}", Average());
            Console.WriteLine("Geçme Durumu : {0}", Durum());
            Console.WriteLine("#==============================#");
        }
        public Object Durum()
        {
            string p;
            if ((Visa + Final) / 2 >= 50)
            {
                p = "Geçti...";
            }
            else
            {
                p = "Kaldı...";
            }     
            return p;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ogrenci cagrierhan = new ogrenci();
            {
                cagrierhan.Name = "Çağrı";
                cagrierhan.Surname = "Erhan";
                cagrierhan.number = 221903047;
                cagrierhan.YearOfBirth = 1999;
                cagrierhan.department = "Teknik Bilimler";
                cagrierhan.visa = 99;
                cagrierhan.final = 100;
                cagrierhan.Age();
                cagrierhan.Bilgi();
            }
        }
    }
}
