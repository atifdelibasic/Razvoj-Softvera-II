using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Sevices
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> Get();
    }
}
