using GameSalesCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Abstract
{
	public interface IUserService
	{
		void Register(User user);
		void Update(User user);
		void Delete(User user);
	}
}
