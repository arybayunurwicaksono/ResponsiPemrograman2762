using System;

namespace ResponsiPemrograman2762
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan orang = new Karyawan(19112762, 2000000, "Ary");
            Karyawan orang2 = new Karyawan(19110000, 3000000, "Bayu");

            Console.WriteLine("No. \t Nik/Nama \t\t Gaji Bulanan ");
            Console.WriteLine("1. \t {0} {1} \t\t {2}", orang.Nik, orang.Nama, orang.GajiBulanan);
            Console.WriteLine("2. \t {0} {1} \t\t {2}", orang2.Nik, orang2.Nama, orang2.GajiBulanan);

            Console.WriteLine("");

            Console.WriteLine("Asyiiik kenaikan gaji 10%");

            Console.WriteLine("");

            Console.WriteLine("No. \t Nik/Nama \t\t Gaji Bulanan ");
            Console.WriteLine("1. \t {0} {1} \t\t {2}", orang.Nik, orang.Nama, orang.GajiPlus);
            Console.WriteLine("2. \t {0} {1} \t\t {2}", orang2.Nik, orang2.Nama, orang2.GajiPlus);
        }
    }

    class Karyawan
    {

        public int Nik { get; set; }
        public int GajiBulanan { get; set; }
        public string Nama { get; set; }
        public int GajiPlus { get; set; }

        public Karyawan(int Nik, int inputanGaji, string Nama)
        {

            this.Nik = Nik;
            this.Nama = Nama;

            if (inputanGaji < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = inputanGaji;
            }

            double rumus = 0;
            rumus = 0.1 * GajiBulanan;
            GajiPlus = Convert.ToInt32(rumus) + GajiBulanan;

        }
    }
}


