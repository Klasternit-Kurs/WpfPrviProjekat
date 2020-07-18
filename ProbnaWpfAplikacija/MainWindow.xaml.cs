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

namespace ProbnaWpfAplikacija
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public Osoba o = new Osoba();
		public Bla b = new Bla();

		public MainWindow()
		{
			//Nikada kod pre initialize
			InitializeComponent();
			stackZaOsobu.DataContext = o;
			DrugiStack.DataContext = b;
		}

		private void MetodaZaKlik(object sender, RoutedEventArgs e)
		{
		
		}

		private void ZatvaraSe(object sender, System.ComponentModel.CancelEventArgs e)
		{
			MessageBox.Show("Zatvara se!");
		}
	}

	public class Osoba
	{
		public string Ime { get; set; } = "Pera";
		public int Broj { get; set; }
	}
	public class Bla
	{
		public string Nesto { get; set; } = "Nesto";
	}
}
