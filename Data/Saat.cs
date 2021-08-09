using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Saat : IUrun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public void Aciklama()
        {
            Console.WriteLine("Id : " + Id + "\n Name : " + Name + "\n Brand : " + Brand);

        }
    }
}

