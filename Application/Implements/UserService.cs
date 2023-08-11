using Application.Interfaces;
using Persistence.Entities;

namespace Application.Implements
{
	public class UserService  : IUserService
	{
		List<User> users = new List<User>()
		{
			new User(){ Email = "ale@gmail.com", Password = "123456"},
			new User(){ Email = "a@gmail.com", Password = "123456"}
		};

		public bool IsUser(string email, string password)=>
			users.Where(d=>d.Email == email && d.Password  == password).Count() > 0;
	}
}
