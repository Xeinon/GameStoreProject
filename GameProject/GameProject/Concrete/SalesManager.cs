using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    class SalesManager : ISalesManager
    {
        public void Buy(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Id +">"+ gamer.FirstName +" "+ game.GameName +" "+"Oyununu satın aldı");
        }

        public void BuyCampaing(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.Id +">"+ gamer.FirstName +" "+ game.GameName +" "+"oyununu"+" "+ campaign.CampaignName +" "+ "ile %" + " " + campaign.CampaignRate + " " + "indirimle" +" "+ game.GamePrice*(100-campaign.CampaignRate)/100 + "TL'ye aldı");
        }
    }
}
