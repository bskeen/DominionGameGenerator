using System;
using System.Collections.Generic;
using System.Text;
using DominionGameGenerator.Data;
using DominionGameGenerator.Services.DataTransferObjects;
using AutoMapper;
using System.Linq;
using DominionGameGenerator.Common.Enums;
using DominionGameGenerator.Common;
using DominionGameGenerator.Data.Models;

namespace DominionGameGenerator.Services
{
    public class GameService : IGameService
    {
        private readonly ICardRepository _cardRepository;
        private readonly IMapper _mapper;

        public GameService(IMapper mapper, ICardRepository cardRepository)
        {
            _mapper = mapper;
            _cardRepository = cardRepository;
        }

        public GameDto GetGame(GameParametersDto parameters)
        {
            Random random = new Random();
            var gameCards = _cardRepository.GetCardsForGame(parameters.ExpansionIDs).OrderBy(x => random.NextDouble()).ToList();

            int numberOfEvents = (int)parameters.EventFrequency;

            if (parameters.EventFrequency == EventFrequencies.Random)
            {
                numberOfEvents = random.Next(3);
            }

            var kingdomCards = gameCards.Where(x => x.CardCategories.Any(y => y.Name == Constants.KINGDOM_CATEGORY)).ToList();
                                        

            var supplyCards = kingdomCards.Take(10)
                                          .OrderBy(x => x.Expansion.Name)
                                          .ThenBy(x => x.Name);
            Card baneCard = null;
            Card youngWitchCard = supplyCards.FirstOrDefault(x => x.Name == "Young Witch");

            if (youngWitchCard != null)
            {
                baneCard = kingdomCards.Skip(10)
                                       .FirstOrDefault(x => x.CoinCost == 2 || x.CoinCost == 3);

                youngWitchCard.DependentCards = new Card[]
                {
                    baneCard
                };
            }

            var eventsAndLandmarks = gameCards.Where(x => x.CardCategories.Any(y => y.Name == Constants.EVENT_CATEGORY))
                                              .Take(numberOfEvents)
                                              .OrderBy(x => x.Expansion.Name)
                                              .ThenBy(x => x.Name);

            double prosperityExpandedProbability = parameters.ProsperityExpandedPercentage / 100.0;
            bool includeProsperityExpandedCards = random.NextDouble() <= prosperityExpandedProbability;

            double darkAgesShelterProbability = parameters.DarkAgesShelterPercentage / 100.0;
            bool includeDarkAgesShelters = random.NextDouble() <= darkAgesShelterProbability;

            var result = new GameDto()
            {
                Cards = _mapper.Map<IEnumerable<CardDto>>(supplyCards),
                Events = _mapper.Map<IEnumerable<CardDto>>(eventsAndLandmarks.Where(x => x.CardTypes.Any(y => y.Name == Constants.EVENT_TYPE))),
                Landmarks = _mapper.Map<IEnumerable<CardDto>>(eventsAndLandmarks.Where(x => x.CardTypes.Any(y => y.Name == Constants.LANDMARK_TYPE))),
                IncludeProsperityExpandedCards = includeProsperityExpandedCards,
                IncludeDarkAgesShelters = includeDarkAgesShelters
            };

            return result;
        }
    }

    public interface IGameService
    {
        GameDto GetGame(GameParametersDto parameters);
    }
}
