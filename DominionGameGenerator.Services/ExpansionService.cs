using System;
using System.Collections.Generic;
using System.Text;
using DominionGameGenerator.Data;
using DominionGameGenerator.Services.DataTransferObjects;
using AutoMapper;

namespace DominionGameGenerator.Services
{
    public class ExpansionService : IExpansionService
    {
        private readonly IMapper _mapper;
        private readonly IExpansionRepository _expansionRepository;

        public ExpansionService(IMapper mapper, IExpansionRepository expansionRepository)
        {
            _mapper = mapper;
            _expansionRepository = expansionRepository;
        }

        public IEnumerable<ExpansionDto> GetExpansions()
        {
            return _mapper.Map<IEnumerable<ExpansionDto>>(_expansionRepository.GetExpansions());
        }
    }

    public interface IExpansionService
    {
        IEnumerable<ExpansionDto> GetExpansions();
    }
}
