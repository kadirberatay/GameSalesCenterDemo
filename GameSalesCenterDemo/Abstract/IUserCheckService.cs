using GameSalesCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Abstract
{
	public interface IUserCheckService
	{
		bool CheckIfRealPerson(User user);
	}
}
