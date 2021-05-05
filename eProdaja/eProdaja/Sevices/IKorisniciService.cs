using eProdaja.Database;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Sevices
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> Get();
        public Model.Korisnici GetById(int id);

        Model.Korisnici Insert(KorisniciInsertRequest request);
    }
}
