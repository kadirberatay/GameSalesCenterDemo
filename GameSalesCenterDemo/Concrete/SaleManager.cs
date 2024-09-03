using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesCenterDemo.Abstract;
using GameSalesCenterDemo.Entities;

namespace GameSalesCenterDemo.Concrete
{
	class SaleManager:ISaleService
	{
		public void Sale(Sale sale, Game game, User user, Campaign campaign)
		{
			sale.Name = "First";
			sale.GameId = game.Id;
			sale.UserId = user.Id;

			Console.WriteLine($"Selling is {sale.Name} is ok.");
			Console.WriteLine($"Selling price : {(game.GamePrice*campaign.Discount)}");
		}
	}
}
