using Data;
using Dl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bl
{
    public class TelefonManager
    {
       TelefonRepository telefonRepository = null;
        public TelefonManager()
        {
             telefonRepository = new TelefonRepository();
        }
        public void Delete(Telefon telefon) 
        { 
            telefonRepository.Delete(telefon); 
        }

        public void Update(Telefon telefon)
        {
             telefonRepository.Update(telefon);
        }

        public void Add(Telefon telefon)
        {
            telefonRepository.Add(telefon);
        }

        public List<Telefon> GetList()
        {
            return telefonRepository.GetAll();
        }
        public Telefon Get(int id)
        {
            
            return telefonRepository.Get(id);
            
        }
        public void WriteAll (Telefon telefon)
        {
            foreach (var item in telefonRepository.GetAll())
            {
                item.Aciklama();
            }
        }        
    }
}
