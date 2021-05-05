using eProdaja.Sevices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class ProizvodiController : BaseReadController<Model.Proizvodi, Model.ProizvodiSearchObject>
    {
        public ProizvodiController(IProizvodiService service)
            :base(service)
        {

        }
    }
}
