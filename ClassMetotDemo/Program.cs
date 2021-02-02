using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Ali";
            musteri1.SurName = "Cengiz";
            musteri1.Number = 205014895;
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Merve";
            musteri2.SurName = "Ayşe";
            musteri2.Number = 205026598;
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Alparslan";
            musteri3.SurName = "Toksöz";
            musteri3.Number = 205041262;

            MusteriManager manager = new MusteriManager();
            manager.Add(musteri1);
            manager.Delete(musteri1);
            manager.List(musteri1);

            Musteri[] musteri = new Musteri[] { musteri1, musteri2 , musteri3};
            
            foreach (var cst in musteri)
            {
                Console.WriteLine("Registered musteri : " + cst.Id+ " "  + cst.Name +" " + cst.SurName);
            }

        }
    }
}
