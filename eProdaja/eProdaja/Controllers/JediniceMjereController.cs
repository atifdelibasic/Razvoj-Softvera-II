using eProdaja.Sevices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class JediniceMjereController : BaseReadController<Model.JediniceMjere, object>
    {
        public JediniceMjereController(IJedinicaMjereService service)
            :base(service)
        {
        }
    }
}
