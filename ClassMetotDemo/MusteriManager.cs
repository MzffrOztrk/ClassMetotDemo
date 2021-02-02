using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("\nYeni Müşteri Eklendi:" + "\nVerilen ID:" + musteri.Id + " \nİsim Soyisim:" + musteri.Name + " " + musteri.SurName + " " + " \nTelefon numarası:" + musteri.Number);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri:" + "\n" + musteri.Name + " " + musteri.SurName + "\nHaber ver:" + musteri.Number);
        }


        public void List(Musteri musteri)
        {
            Console.WriteLine("Kayıtlı Kişiler:" + "\nID Numarası:" + musteri.Id + "\nAdı Soyadı:" + musteri.Name + " " + musteri.SurName + "\nTelefon Numarası" + musteri.Number);
        }

    }
}
