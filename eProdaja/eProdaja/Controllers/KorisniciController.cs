using eProdaja.Database;
using eProdaja.Sevices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController:  BaseController
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public IList<Model.Korisnici> Get()
        {
            return _service.Get();
        }
       
    }
}
