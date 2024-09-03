using GameSalesCenterDemo.Abstract;
using GameSalesCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Concrete
{
	public class GameManager : IGameService
	{
		public void Add(Game game)
		{
			Console.WriteLine("Game : "+game.GameName + " " + "is added.");
		}

		public void Delete(Game game)
		{
			Console.WriteLine("Game : "+game.GameName + " " + "is deleted.");
		}

		public void Update(Game game)
		{
			Console.WriteLine("Game : "+game.GameName + " " + "is updated.");
		}
	}
}
