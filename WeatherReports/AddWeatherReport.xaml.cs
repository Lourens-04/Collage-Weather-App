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

namespace WeatherReports
{
	/// <summary>
	/// Interaction logic for AddWeatherReport.xaml
	/// </summary>
	public partial class AddWeatherReport : Window
	{
		private Boolean error = false;
		Reports dd = new Reports();
		string minTemp;
		string maxTemp;

		public AddWeatherReport()
		{
			InitializeComponent();
			txbDateInfo.Text = Convert.ToString(DateTime.Today.Date);
		}

		private void BtnAdd_Click(object sender, RoutedEventArgs e)
		{
			Error();
			if (error == false)
			{
				for (int i = 0; i < dd.WeaterForecast1.Count; i++)
				{
					if (dd.WeaterForecast1[i].City.Equals(txbCity.Text, StringComparison.InvariantCultureIgnoreCase))
					{
						txbCity.Text = dd.WeaterForecast1[i].City;
					}
				}

				dd.WeaterForecast1.Add(new AddReport(txbCity.Text, dpDate.Text,
									minTemp, maxTemp,
									txbPrecipitation.Text, txbHumidity.Text,
									txbWindSpeed.Text));
				MessageBox.Show("The city " + txbCity.Text + " weather forcast are sucsessfully captured on the date " + dpDate.Text);
			}
			else
			{
				error = false;
			}
			
		}

		private void BtnBack_Click(object sender, RoutedEventArgs e)
		{
			MainWindow main = new MainWindow();
			main.DataContext = main;
			this.Hide();
			main.ShowDialog();
		}
		private void SMinTemp_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (IsLoaded)
			{
				minTemp = sMinTemp.Value.ToString();
				txbMinTemp.Text = sMinTemp.Value.ToString();
			}
			else
			{
				error = true;
			}

		}

		private void SMaxTemp_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			if (IsLoaded)
			{
				maxTemp = sMaxTemp.Value.ToString();
				txbMaxTemp.Text = sMaxTemp.Value.ToString();
			}
			else
			{
				error = true;
			}

		}

		private void Window_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
		}

		private Boolean Error()
		{
			try
			{
				if (Convert.ToInt32(txbPrecipitation.Text) == Convert.ToInt32(txbPrecipitation.Text)
					&& Convert.ToInt32(txbHumidity.Text) == Convert.ToInt32(txbHumidity.Text)
					&& Convert.ToInt32(txbWindSpeed.Text) == Convert.ToInt32(txbWindSpeed.Text))
				{
					error = false;
				}

				try
				{
					if (Convert.ToInt32(txbCity.Text) > 0 || Convert.ToInt32(txbCity.Text) < 0)
					{
						error = true;
						MessageBox.Show("Please make sure that you enter the city correctly");
					}
				}
				catch (FormatException)
				{
					error = false;
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Please check your that your Precipitation, Humidity, Wind Speed are an interger value");
				error = true;
			}

			if (sMaxTemp.Value < sMinTemp.Value)
			{
				error = true;
				MessageBox.Show("Please check your tempreture because min tempreture can not be higher as max tempreture");
			}

			if (txbCity.Text.Equals("") || dpDate.Text.Equals("") ||
				txbPrecipitation.Text.Equals("") || txbHumidity.Text.Equals("") || txbWindSpeed.Text.Equals(""))
			{
				error = true;
				MessageBox.Show("Please check your that you enterd all the data correctly withou leaving an open space");
			}

			if (dpDate.SelectedDate < DateTime.Today)
			{
				error = true;
				MessageBox.Show("You can not enterd previous dates");
			}

			for (int i = 0; i < dd.WeaterForecast1.Count; i++)
			{
				if (dd.WeaterForecast1[i].City.Equals(txbCity.Text))
				{
					if (dd.WeaterForecast1[i].Date.Equals(dpDate.Text))
					{
						error = true;
						MessageBox.Show("The date enterd is already enterd in the system");
					}
				}
			}
			return error;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			txbCity.Text = "Durban";
			dpDate.Text = "3/31/2019";
			sMinTemp.Value = 18;
			sMaxTemp.Value = 24;
			txbPrecipitation.Text = "50";
			txbHumidity.Text = "50";
			txbWindSpeed.Text = "50";
		}
	}
}
