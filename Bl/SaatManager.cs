using Data;
using Dl;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bl
{
    
    public class SaatManager
    {
        SaatRepository saatRepository = null;
        public SaatManager()
        {
            saatRepository = new SaatRepository();
        }
        public void Delete (Saat saat)
        {
            saatRepository.Delete(saat);
        }
        public void Update (Saat saat)
        {
            saatRepository.Update(saat);
        }
        public void Add (Saat saat)
        {
            saatRepository.Add(saat);
        }
        
        public Saat Get (int id)
        {
            Saat s = saatRepository.Get(id);
            return s;
        }
        
        
        public List<Saat> GetList()
        {
            return saatRepository.getAll();
        }
        public void WriteAll()
        {
            foreach (var item in saatRepository.getAll())
            {
                item.Aciklama();
            }
        }





    }
}
