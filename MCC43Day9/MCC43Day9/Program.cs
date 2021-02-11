using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCC43Day9
{
    class BangunDatar
    {
        public double luas;
        public double keliling;
        public virtual double hitungLuas(double s1, double s2)
        {
            return luas;
        }
        public virtual double hitungKeliling(double s1, double s2)
        {
            return keliling;
        }
    }
    class Persegi : BangunDatar
    {
        public override double hitungLuas(double s1, double s2)
        {
            luas = s1 * s2;
            return luas;
        }
        public override double hitungKeliling(double s1, double s2)
        {
            keliling = 2 * (s1 + s2);
            return keliling;
        }
    }
    class PersegiPanjang : BangunDatar
    {
        public override double hitungLuas(double s1, double s2)
        {
            luas = s1 * s2;
            return luas;
        }
        public override double hitungKeliling(double s1, double s2)
        {
            keliling = 2 * (s1 + s2);
            return keliling;
        }
    }
    class Segitiga : BangunDatar
    {
        public override double hitungLuas(double s1, double s2)
        {
            luas = (s1 * s2) * 0.5;
            return luas;
        }
        public override double hitungKeliling(double s1, double s2)
        {
            keliling = 3 * s2;
            return keliling;
        }
    }
    class Lingkaran : BangunDatar
    {
        public double phi = 3.14;
        public override double hitungLuas(double s1, double s2)
        {
            luas = (s1 * s1) * phi;
            return luas;
        }
        public override double hitungKeliling(double s1, double s2)
        {
            keliling = phi * s2;
            return keliling;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String exit;
            do
            {

                Console.WriteLine("Bangun ruang apa yang di hitung ?");
                Console.WriteLine("1. Persegi");
                Console.WriteLine("2. Persegi Panjang");
                Console.WriteLine("3. Segitiga sama sisi");
                Console.WriteLine("4. Lingkaran");
                Console.Write("Masukan nomor bangun :  ");
                int inputBangunDatar = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (inputBangunDatar)
                    {
                        case 1:
                            Console.WriteLine("Berapa panjang sisi persegi nya ?");
                            double Sisi = Convert.ToDouble(Console.ReadLine());
                            BangunDatar kotak = new Persegi();
                            Console.WriteLine("Luas persegi tersebut adalah " + kotak.hitungLuas(Sisi, Sisi));
                            Console.WriteLine("Keliling persegi tersebut adalah " + kotak.hitungKeliling(Sisi, Sisi));
                            break;
                        case 2:
                            Console.WriteLine("Berapa panjang sisi persegi nya ?");
                            double panjang = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Berapa lebar sisi persegi nya ?");
                            double lebar = Convert.ToDouble(Console.ReadLine());
                            BangunDatar kotakPanjang = new PersegiPanjang();
                            Console.WriteLine("Luas persegi tersebut adalah " + kotakPanjang.hitungLuas(panjang, lebar));
                            Console.WriteLine("Keliling persegi tersebut adalah " + kotakPanjang.hitungKeliling(panjang, lebar));
                            break;
                        case 3:
                            Console.WriteLine("Berapa tinggi segitiga nya ?");
                            double tinggi = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Berapa alas segitiga nya ?");
                            double alas = Convert.ToDouble(Console.ReadLine());
                            BangunDatar samsan = new Segitiga();
                            Console.WriteLine("Luas persegi tersebut adalah " + samsan.hitungLuas(tinggi, alas));
                            Console.WriteLine("Keliling persegi tersebut adalah " + samsan.hitungKeliling(tinggi, alas));
                            break;
                        case 4:
                            Console.WriteLine("Berapa jari-jari lingkaran nya ?");
                            double jari = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Berapa diameter lingkaran nya ?");
                            double diameter = Convert.ToDouble(Console.ReadLine());
                            BangunDatar bulat = new Lingkaran();
                            Console.WriteLine("Luas persegi tersebut adalah " + bulat.hitungLuas(jari, diameter));
                            Console.WriteLine("Keliling persegi tersebut adalah " + bulat.hitungKeliling(jari, diameter));
                            break;
                    }
                }
                catch
                {
                    Console.Write("input harus angka dan berupa angka 1-4  ");
                }
                Console.Write("apakah anda masih ingin menghitung ? Ya/Tidak  ");
                exit = Console.ReadLine();
            }
            while (exit == "ya" || exit == "Ya");
        }
    }
}
