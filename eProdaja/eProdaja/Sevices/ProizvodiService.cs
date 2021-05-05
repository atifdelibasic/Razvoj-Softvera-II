using AutoMapper;
using eProdaja.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Sevices
{
    public class ProizvodiService:BaseReadService<Model.Proizvodi, Database.Proizvodi, Model.ProizvodiSearchObject>, IProizvodiService
    {
        public ProizvodiService(Database.eProdajaContext context, IMapper mapper)
          : base(context, mapper)
        {

        }

        public override IEnumerable<Proizvodi> Get(ProizvodiSearchObject search = null)
        {
            var entity = _context.Set<Database.Proizvodi>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }

            if(search.JedinicaMjereId.HasValue)
            {
                entity = entity.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);
            }

            if (search.VrstaId.HasValue)
            {
                entity = entity.Where(x => x.VrstaId == search.VrstaId);
            }
            if(search?.IncludeJedinicaMjere == true)
            {
                entity = entity.Include("JedinicaMjere");
            }


            var list = entity.ToList();
            return _mapper.Map<List<Model.Proizvodi>>(list);
        }
    }
}
