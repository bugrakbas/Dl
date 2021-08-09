using System;

namespace Data
{
    public class Telefon : IUrun
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public void Aciklama()
        {
            Console.WriteLine("Id : " + Id + "\nName : " + Name + "\nBrand : " + Brand);
        }
            }
}
