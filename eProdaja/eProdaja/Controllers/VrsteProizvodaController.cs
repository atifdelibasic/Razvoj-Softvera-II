using eProdaja.Sevices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class VrsteProizvodaController : BaseReadController<Model.VrsteProizvodum, object>
    {
        public VrsteProizvodaController(IVrsteProizvodumService service)
            : base(service)
        {

        }

    }
}
