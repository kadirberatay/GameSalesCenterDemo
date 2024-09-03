using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesCenterDemo.Adapters;
using GameSalesCenterDemo.Concrete;
using GameSalesCenterDemo.Entities;

namespace GameSalesCenterDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// UserManager ve EGovernmentServiceAdapter kullanılarak bir kullanıcı kaydı yapılır
			UserManager userManager = new UserManager(new EGovernmentServiceAdapter());
			var user = new User
			{
				Balance = 1000,
				DateOfBirth = new DateTime(1999, 11, 9),
				FirstName = "Kemal",
				Id = 1,
				LastName = "İleri",
				NationalityId = "28711942082"
			};
			userManager.Register(user);

			// CampaignManager kullanılarak bir kampanya eklenir
			CampaignManager campaignManager = new CampaignManager();
			var campaign = new Campaign
			{
				Id = 1,
				CampaignName = "FiftyDiscount",
				StartDate = new DateTime(2024, 09, 02),
				EndDate = new DateTime(2024, 11, 02)
			};
			campaignManager.AddCampaign(campaign);

			// GameManager kullanılarak bir oyun eklenir
			GameManager gameManager = new GameManager();
			var game = new Game
			{
				Id = 1,
				GameName = "Knight Online",
				GamePrice = 500,
				ReleaseDate = new DateTime(2003, 01, 01)
			};
			gameManager.Add(game);

			// SaleManager kullanılarak bir satış işlemi yapılır
			SaleManager saleManager = new SaleManager();
			saleManager.Sale(
				new Sale
				{
					Id = 1,
					Name = "First"/*,*/
					//Game = game,
					//User = user,
					//Campaign = campaign
				},
				game,
				user,
				campaign
			);

			Console.WriteLine(user.FirstName);
			Console.ReadLine();
		}
	}
}