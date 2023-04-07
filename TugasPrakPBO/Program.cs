namespace TugasPrakPBO
{
    public class Processor
    {
        public string merk;
        public string tipe;
    }

    public class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "Ryzen";
        }
    }
    public class ATHLON : AMD
    {
        public ATHLON()
        {
            base.tipe = "ATHLON";
        }
    }
    public class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "Core i3";
        }
    }
    public class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Core i5";
        }
    }
    public class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Core i7";
        }
    }

    public class Vga
    {
        public string merk;
    }
    public class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    public class amd : Vga
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }

    public class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;
        
        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }
    public class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    public class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    public class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    public class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "ROG";
        }
        public void Ngoding()
        {
            Console.WriteLine("ctak ctak ctak, error lagii!!!");
        }
    }
    public class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    } 
    public class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game.");
        }
    } 
    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }
    public class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new Corei5();

            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new amd();
            laptop2.processor = new Ryzen();

            Predator predator = new Predator();
            predator.vga = new amd();
            predator.processor = new Corei7();

            ACER acer = new Predator();

            // Soal 1 Jalankan method LaptopDinyalakan() & LaptopDimatikan() pada laptop2
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            // Soal 2 Jalankan method Ngoding() pada laptop1
            laptop1.Ngoding();

            // Soal 3 Tampilkan spesifikasi laptop1
            Console.WriteLine($"Spesifikasi laptop 1 :{"\n"}- Merk VGA {laptop1.vga.merk}" +
                $"{"\n"}- Merk processor {laptop1.processor.merk}" +
                $"{"\n"}- Tipe processor {laptop1.processor.tipe}");

            // Soal 4 Jalankan method BermainGame() pada predator
            predator.BermainGame();

            // Soal 5 Jalankan method BermainGame() pada acer
            acer.BermainGame();
        }
    }
}