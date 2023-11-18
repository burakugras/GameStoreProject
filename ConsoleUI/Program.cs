using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Abstracts;
using Entities.Concretes;

internal class Program
{
    private static void Main(string[] args)
    {
        Gamer user1 = new Gamer() { Id = 1, FirstName = "Burak", LastName = "Uğraş", BirthYear = 1990, TcNo = "12345678901" };

        IVerificationService verificationService = new EGovernmentVerificationService();
        IGamerDal gamerDal = new GamerDal();
        IGamerService gamerService = new GamerManager(verificationService, gamerDal);
        gamerService.Add(user1);


        Product game1 = new Game() { Id = 1, ProductName = "Ori and Blind Forest", Price = 50, UnitInStock = 100 };
        IGameDal gameDal = new GameDal();
        IGameService gameService = new GameManager(gameDal);
        gameService.Add(game1);

        ISalesService salesManager = new SalesManager();
        salesManager.SellGame(user1, game1);



    }
}