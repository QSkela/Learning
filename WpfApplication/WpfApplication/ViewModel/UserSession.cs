using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication.ViewModel
{
	public class UserSession
	{
		private readonly string _password;

		private UserSession(string user, string password)
		{
			if (user == null) throw new ArgumentNullException(nameof(user));
			if (password == null) throw new ArgumentNullException(nameof(password));

			User = user;
			_password = password;
		}

		public string User { get; }

		public static UserSession CreateSession(string user, string password)
		{
			return new UserSession(user, password);
		}
	}
}
