using AutoMapper;
using eProdaja.Database;
using eProdaja.Filters;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Sevices
{
    public class KorisniciService : IKorisniciService
    {
        public eProdajaContext _context { get; set; }
        protected readonly IMapper _mapper;
        public KorisniciService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Korisnici> Get()
        {
            return _context.Korisnicis.ToList().Select(x=> _mapper.Map<Model.Korisnici>(x)).ToList();
        }

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnicis.Find(id);
            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            throw new UserException("Lozinka nije ispravna");
        }

        //private Model.Korisnici ToModel(Korisnici entity)
        //{
        //    return new Model.Korisnici
        //    {
        //        KorisnikId = entity.KorisnikId,
        //        Ime = entity.Ime,
        //        Prezime = entity.Prezime,
        //        KorisnickoIme = entity.KorisnickoIme,
        //        Email = entity.Email,
        //        Telefon = entity.Telefon
        //    };
        //}
    }
}
