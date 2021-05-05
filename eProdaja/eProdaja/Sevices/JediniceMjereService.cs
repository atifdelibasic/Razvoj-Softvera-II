using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Sevices
{
    public class JediniceMjereService : BaseReadService<Model.JediniceMjere, Database.JediniceMjere, object>, IJedinicaMjereService
    {
        public JediniceMjereService(eProdajaContext context, IMapper mapper)
            :base(context, mapper)
        {
        }
      
    }
}
