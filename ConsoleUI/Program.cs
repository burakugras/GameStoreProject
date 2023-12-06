using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Gamer burak = new Gamer() { FirstName = "Burak", LastName = "Uğraş", TcNo = "12345678901", BirthYear = 1985 };
        GamerManager gamerManager = new GamerManager(new EGovernmentVerificationService(), new EfGamerDal());
        //gamerManager.Add(burak);

        Game mario = new Game() { Name = "Mario", Price = 50, UnitsInStock = 100 };
        GameManager gameManager = new GameManager(new EfGameDal());
        //gameManager.Add(mario);

        Campaign winterSale = new Campaign() { Name = "Winter Sale Campaign", Discount = 10 };
        CampaignManager campaignManager=new CampaignManager(new EfCampaignDal());
        //campaignManager.Add(winterSale);

        SalesManager salesManager = new SalesManager();
        salesManager.SellGame(burak, mario);




        //InMemoryTest();

        */
    }

    //private static void InMemoryTest()
    //{
    //    Gamer user1 = new Gamer() { Id = 1, FirstName = "Burak", LastName = "Uğraş", BirthYear = 1990, TcNo = "12345678901" };

    //    IVerificationService verificationService = new EGovernmentVerificationService();
    //    IGamerDal gamerDal = new EfGamerDal();
    //    IGamerService gamerService = new GamerManager( gamerDal);
    //    gamerService.Add(user1);


    //    Game game1 = new Game() { Id = 1, Name = "Ori and Blind Forest", Price = 50, UnitsInStock = 100 };

    //    Game game2 = new Game() { Id = 2, Name = "Super Mario", Price = 40, UnitsInStock = 125/*, Offer = new Campaign { Discount = 10 }*/ };

    //    Campaign campaign1 = new Campaign() { Id = 1, Name = "Winter Sale", Discount = 20 };

    //    ICampaignService campaignService = new CampaignManager(new EfCampaignDal());
    //    campaignService.Add(campaign1);
    //    campaignService.Add(campaign1);
    //    //campaignService.DeleteCampaign(game2,campaign1); CAMPAIGN HAS BEEN DELETED FOR HERE


    //    IGameDal gameDal = new EfGameDal();
    //    IGameService gameService = new GameManager(gameDal);
    //    gameService.Add(game1);
    //    gameService.Add(game2);

    //    ISalesService salesManager = new SalesManager();
    //    salesManager.SellGame(user1, game1);
    //    salesManager.SellGame(user1, game2);
    //}
}