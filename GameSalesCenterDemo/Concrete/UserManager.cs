using GameSalesCenterDemo.Abstract;
using GameSalesCenterDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesCenterDemo.Concrete
{
	public class UserManager : IUserService
	{
		private IUserCheckService _userCheckService;
		public UserManager(IUserCheckService userCheckService)
		{
			_userCheckService = userCheckService;
		}
		public void Delete(User user)
		{
			Console.WriteLine("User : " + user.FirstName + " " + user.LastName + " is deleted.");
		}
				
		public void Register(User user)
		{
			if (_userCheckService.CheckIfRealPerson(user))
			{
				Console.WriteLine("User : " + user.FirstName + " " + user.LastName + " is registered.");
			}
			
			else
			{
				throw new Exception("There is no such record or the information is incorrect.");
			}
		}

		public void Update(User user)
		{
			if (_userCheckService.CheckIfRealPerson(user))
			{
				Console.WriteLine("User : " + user.FirstName + " " + user.LastName + " is updated.");
			}

			else
			{
				throw new Exception("There is no such record or the information is incorrect.");
			}
		}
	}
}
