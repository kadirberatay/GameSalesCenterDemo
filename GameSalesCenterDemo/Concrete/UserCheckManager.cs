using GameSalesCenterDemo.Abstract;
using GameSalesCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Concrete
{
	public class UserCheckManager : IUserCheckService
	{
		public bool CheckIfRealPerson(User user)
		{
			return true;	
		}
	}
}
