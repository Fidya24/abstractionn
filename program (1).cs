using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


 namespace AbstractClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
              Console.WriteLine("Nama\t\t: Fidya Gendis");
            Console.WriteLine("NIM\t\t: 19.11.2813");
            Console.WriteLine("Kelas\t\t: 19 IF 04");


            Console.WriteLine();

            Console.WriteLine("--- MOTOR ---");

            Console.WriteLine();

            ACOperatingSystem motor;

            motor = new Beat();
            motor.nama();
            motor.warna();
            motor.plat();

            Console.WriteLine();

            motor = new supra();
            motor.nama();
            motor.warna();
            motor.plat();



            Console.WriteLine();

            Console.WriteLine("--- Tari ---");

            Console.WriteLine();

            Tari tari;

            tari = new Gambyong ();
            tari.Asal();
            tari.jenis();

            Console.WriteLine();

            tari = new Dance();
            tari.Asal();
            tari.jenis();
        }
    }

    // Abstract Class 
    public abstract class ACOperatingSystem
    {
        public abstract void nama();
        public abstract void warna();
        public abstract void plat();
    }

    public class Beat : ACOperatingSystem
    {
        public override void nama()
        {
            Console.WriteLine("nama : Beat ");
        }

        public override void warna()
        {
            Console.WriteLine("warna : hitam");
        }

        public override void plat()
        {
            Console.WriteLine("plat : AB ");
        }
    }

    public class supra : ACOperatingSystem
    {
        public override void nama()
        {
            Console.WriteLine("nama : Supra ");
        }

        public override void warna()
        {
            Console.WriteLine("warna : putih ");
        }

        public override void plat()
        {
            Console.WriteLine("plat : AB ");
        }
    }
    // Interface Class Tari

    public interface Tari
    {
        void Asal();
        void jenis();
    }

    public class Gambyong : Tari
    {
        public void Asal()
        {
            Console.WriteLine(" Indonesia ");
        }

        public void jenis()
        {
            Console.WriteLine(" Jenis: Tradisional ");
        }

        public void asal()
        {
            throw new NotImplementedException();
        }
    }


    public class Dance : Tari
    {
        public void Asal()
        {
            Console.WriteLine(" Indonesia ");
        }
        public void jenis()
        {
            Console.WriteLine(" Jenis : Modern");
        }

        public void asal()
        {
            throw new NotImplementedException();
        }
    }

}                        