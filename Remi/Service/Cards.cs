using System;
using System.Collections.Generic;

namespace CardsApi.Service
{
    public interface ICardsService
    {
        public Object GetCards(string email);
    }
}