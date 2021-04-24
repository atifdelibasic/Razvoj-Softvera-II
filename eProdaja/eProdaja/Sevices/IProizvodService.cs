using eProdaja.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Sevices
{
    public interface IProizvodService
    {
        public IEnumerable<Proizvod> Get();
        public Proizvod GetById(int id);
        public Proizvod Insert(Proizvod proizvod);
    }
}
