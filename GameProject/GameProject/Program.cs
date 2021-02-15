using System;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu eklendi.
            Gamer gamer1 = new Gamer()
            {
                Id = 123,
                FirstName = "Cengizhan",
                LastName = "Anar",
                DateOfBirth = 1990,
                TcNo = 1234,
            };
            //Oyun eklendi.
            Game game1 = new Game();
            game1.GameId = 123;
            game1.GameName = "Atmaca";
            game1.GamePrice = 10;
            //Kampanya eklendi.
            Campaign campaign = new Campaign();
            campaign.CampaignId = 123;
            campaign.CampaignName = "Campaign Of Summer";
            campaign.CampaignRate = 20;

            UserValidationManager userValidationManager = new UserValidationManager();

            GamerManager gamerManager = new GamerManager(userValidationManager);
            gamerManager.Add(gamer1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(gamer1, game1);
            salesManager.BuyCampaing(gamer1, game1,campaign);
            
        }
    }
}
