using GameSalesCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Abstract
{
	public interface ISaleService
	{
		void Sale(Sale sale, Game game, User user, Campaign campaign);
	}
}
