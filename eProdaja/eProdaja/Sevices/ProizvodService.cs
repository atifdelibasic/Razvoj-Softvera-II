using eProdaja.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Sevices
{
    public class ProizvodService: IProizvodService
    {
        static List<Proizvod> _proizvodi = new List<Proizvod>();

        static ProizvodService()
        {
            _proizvodi = new List<Proizvod>()
            {
                new Proizvod
                {
                    Id = 1,
                    Name = "Kanta"
                },
                new Proizvod
                {
                      Id = 2,
                    Name = "Laptop"
                },
                new Proizvod
                {
                      Id = 3,
                    Name = "Olovka"
                }
            };
        }
        public IEnumerable<Proizvod> Get()
        {
            return _proizvodi;
        }

        public Proizvod GetById(int id)
        {
            return _proizvodi.FirstOrDefault(x => x.Id == id);
        }
        public Proizvod Insert(Proizvod proizvod)
        {
            _proizvodi.Add(proizvod);
            return proizvod;
        }
    }
}
