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
using System.Numerics;

namespace Champions
{
	/// <summary>
	/// Interaction logic for Characteristic.xaml
	/// </summary>
	public partial class Characteristic : UserControl
	{
		//Constructor
		public Characteristic()
		{
			InitializeComponent();
			DataContext = this;
		}


		//WPF Properties
		public string CharacteristicName
		{
			get { return (string)GetValue(CharacteristicName_Property); }
			set { SetValue(CharacteristicName_Property, value); }
		}
		public static readonly DependencyProperty CharacteristicName_Property = DependencyProperty.Register("MyProperty", typeof(string), typeof(Characteristic), new PropertyMetadata(""));

		public uint CostMultiplier
		{
			get { return (ushort)GetValue(MyPropertyProperty); }
			set { SetValue(MyPropertyProperty, value); }
		}
		public static readonly DependencyProperty CostMultiplier_Property = DependencyProperty.Register("CostMultiplier", typeof(uint), typeof(Characteristic), new PropertyMetadata(0));



		//external event handlers
		public event EventHandler<int> Update;


		// Internal event handlers
		private void LimitToNumbers(object sender, TextCompositionEventArgs e)
		{
			int dumpInt;
			e.Handled = !Standard.General.isDigitOnly(e.Text) || (((TextBox)sender).Text.Length == 0 && int.TryParse(e.Text, out dumpInt));
		}

		private void Value_Set(object sender, RoutedEventArgs e)
		{
			Pts.Text =
		}

		private void Pts_Set(object sender, RoutedEventArgs e)
		{

		}
	}
}
