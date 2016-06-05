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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Champions
{
	/// <summary>
	/// Interaction logic for Characteristic.xaml
	/// </summary>
	public partial class Characteristic : UserControl
	{
		public Characteristic()
		{
			InitializeComponent();
		}

		int lf, kd, ti;

		private void Value_LostFocus(object sender, RoutedEventArgs e)
		{
			lf++;
			Chacteristics.Text = lf.ToString();
		}

		private void Value_KeyDown(object sender, KeyEventArgs e)
		{
			kd++;
			Cost.Text = kd.ToString();
		}

		private void Value_TextInput(object sender, TextCompositionEventArgs e)
		{
			ti++;
			Base.Text = ti.ToString();
		}
	}
}
