using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
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
	/// Interaction logic for Report.xaml
	/// </summary>
	public partial class Report : Window
	{
		public Report()
		{
			InitializeComponent();
			txbDate.Text = Convert.ToString(DateTime.Today.Date);
			
		}

		public void Display(string city, string date, string minTemp, string maxTemp, string precipitation, string humidity, string windSpeed)
		{
			Display Data = new Display();
			if (Convert.ToInt32(precipitation) >= 80)
			{
				Data.Dcity = city;
				Data.Ddate = date;
				Data.DminTemp = minTemp + "°C";
				Data.DmaxTemp = maxTemp ;
				Data.Dprecipitation = precipitation + "%";
				Data.Dhumidity = humidity + "%";
				Data.DwindSpeed = windSpeed + "km/h";
				Data.Dimage = toBitmap(File.ReadAllBytes(System.IO.Path.GetFileName("Resources/Tunder.png")));
				dgData.Items.Add(Data);
			}
			else if (Convert.ToInt32(precipitation) >= 50 && Convert.ToInt32(precipitation) <= 79)
			{
				Data.Dcity = city;
				Data.Ddate = date;
				Data.DminTemp = minTemp + "°C";
				Data.DmaxTemp = maxTemp ;
				Data.Dprecipitation = precipitation + "%";
				Data.Dhumidity = humidity + "%";
				Data.DwindSpeed = windSpeed + "km/h";
				Data.Dimage = toBitmap(File.ReadAllBytes(System.IO.Path.GetFileName("Resources/Rainy.png")));
				dgData.Items.Add(Data);
			}
			else if (Convert.ToInt32(precipitation) >= 20 && Convert.ToInt32(precipitation) <= 49)
			{
				Data.Dcity = city;
				Data.Ddate = date;
				Data.DminTemp = minTemp + "°C";
				Data.DmaxTemp = maxTemp ;
				Data.Dprecipitation = precipitation + "%";
				Data.Dhumidity = humidity + "%";
				Data.DwindSpeed = windSpeed + "km/h";
				Data.Dimage = toBitmap(File.ReadAllBytes(System.IO.Path.GetFileName("Resources/Cloudy.png")));
				dgData.Items.Add(Data);
			}
			else if (Convert.ToInt32(precipitation) <= 19)
			{
				Data.Dcity = city;
				Data.Ddate = date;
				Data.DminTemp = minTemp + "°C";
				Data.DmaxTemp = maxTemp;
				Data.Dprecipitation = precipitation + "%";
				Data.Dhumidity = humidity + "%";
				Data.DwindSpeed = windSpeed + "km/h";
				Data.Dimage = toBitmap(File.ReadAllBytes(System.IO.Path.GetFileName("Resources/Sunny.png")));
				dgData.Items.Add(Data);
			}
			dgData.LoadingRow += DgData_LoadingRow;
		}

		public static BitmapImage toBitmap(Byte[] value)
		{
			if (value != null && value is byte[])
			{
				byte[] ByteArray = value as byte[];
				BitmapImage bmp = new BitmapImage();
				bmp.BeginInit();
				bmp.StreamSource = new MemoryStream(ByteArray);
				bmp.EndInit();
				return bmp;
			}
			return null;
		}

		private void BtnBack_Click(object sender, RoutedEventArgs e)
		{
			MainWindow main = new MainWindow();
			main.DataContext = main;
			this.Hide();
			main.ShowDialog();
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void DgData_LoadingRow(object sender, DataGridRowEventArgs e)
		{
			var row = e.Row;
			var Display = row.DataContext as Display;

			if (sender == dgData)
			{
				if (Convert.ToInt32(Display.DmaxTemp) >= 0 && Convert.ToInt32(Display.DmaxTemp) <= 18)
				{
					row.Background = new SolidColorBrush(Colors.LightBlue);
				}
				else if (Convert.ToInt32(Display.DmaxTemp) >= 19 && Convert.ToInt32(Display.DmaxTemp) <= 26)
				{
					row.Background = new SolidColorBrush(Colors.Yellow);
				}
				else if (Convert.ToInt32(Display.DmaxTemp) >= 27)
				{
					row.Background = new SolidColorBrush(Colors.OrangeRed);
				}
			}
		}
	}
}
