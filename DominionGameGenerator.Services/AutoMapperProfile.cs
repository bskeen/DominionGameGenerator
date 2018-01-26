using AutoMapper;
using DominionGameGenerator.Data.Models;
using DominionGameGenerator.Services.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DominionGameGenerator.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Expansion, ExpansionDto>();

            CreateMap<Card, CardDto>()
                .ForMember(x => x.ExpansionName, y => y.MapFrom(z => z.Expansion.Name))
                .ForMember(x => x.Types, y => y.MapFrom(z => z.CardTypes.Select(w => w.Name)))
                .ForMember(x => x.Categories, y => y.MapFrom(z => z.CardCategories.Select(w => w.Name)));
        }
    }
}
