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
    public class ProizvodController : ControllerBase
    {
        public IProizvodService _proizvodService { get; set; }
        public ProizvodController(IProizvodService proizvodService)
        {
            _proizvodService = proizvodService;
        }
        [HttpGet]
        public IEnumerable<Proizvod> Get()
        {
            return _proizvodService.Get();
        }

        [HttpGet("{id}")]
        public Proizvod GetById(int id)
        {
            return _proizvodService.GetById(id);
        }

        [HttpPost]
        public Proizvod Insert(Proizvod proizvod)
        {
            return _proizvodService.Insert(proizvod);
        }

    }

    public class Proizvod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
