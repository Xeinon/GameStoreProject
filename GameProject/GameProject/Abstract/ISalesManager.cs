using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface ISalesManager
    {
        void Buy(Gamer gamer, Game game);
        void BuyCampaing(Gamer gamer, Game game, Campaign campaign);
    }
}
