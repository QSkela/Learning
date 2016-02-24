using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApplication.ViewModel;

namespace WpfApplication
{
	/// <summary>
	/// Interaction logic for LoginDialog.xaml
	/// </summary>
	public partial class LoginDialog : Window
	{
		public LoginDialog()
		{
			InitializeComponent();

			DataContext = new LoginDialogViewModel();
		}

		private void ButtonOk_OnClick(object sender, RoutedEventArgs e)
		{
			DialogResult = true;
		}

		private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
		}
	}
}
