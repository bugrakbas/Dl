using System;
using System.Collections.Generic;
using System.Linq;
using Data;

namespace Dl
{
    public class SaatRepository
    {
        List<Saat> Urunler = new List<Saat>();


        public void Update(Saat saat)
        {
            Saat s = Urunler.FirstOrDefault(s => s.Id == saat.Id);
            s.Name = saat.Name;
            s.Brand = saat.Brand;
        }
        public void Delete(Saat saat)
        {
            Saat s = Urunler.FirstOrDefault(s => s.Id == saat.Id);
            Urunler.Remove(s);
        }
        public void Add(Saat saat)
        {
            Urunler.Add(saat);
        }
        public Saat Get(int id)
        {
            return Urunler.FirstOrDefault(t => t.Id == id);
        }     
        public List<Saat> getAll()
        {
            return Urunler;
        }
    }
}
