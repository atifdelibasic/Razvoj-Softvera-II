using eProdaja.Database;
using eProdaja.Model.Requests;
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

        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Korisnici Insert([FromBody] KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
