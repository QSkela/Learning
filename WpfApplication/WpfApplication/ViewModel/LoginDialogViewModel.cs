using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApplication.Command;

namespace WpfApplication.ViewModel
{
	public class LoginDialogViewModel
	{
		public string User { get; set; }
		public string Password { get; set; }

		private ICommand _loginCommand;

		public ICommand LoginCommand
		{
			get { return _loginCommand ?? (_loginCommand = new RelayCommand(x => Login(User, Password))); }
		}

		private void Login(string user, string password)
		{
			// ToDo: connect to db
		}
	}
}