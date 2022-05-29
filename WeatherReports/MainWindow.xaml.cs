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
using System.Collections;

namespace WeatherReports
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Boolean check = false;
		private Boolean error = false;
		private Boolean checkdate = false;
		Reports dd = new Reports();
		Report newWindow2 = new Report();

		public MainWindow()
		{
			InitializeComponent();
			txbDate.Text = Convert.ToString(DateTime.Today.Date);
			lbCities.SelectionMode = SelectionMode.Multiple;
			if (dd.WeaterForecast1.Count == 0)
			{
				dd.Values();
			}
			if (dd.WeaterForecast1.Count > 0)
			{
				int i = 0;
				while (i < dd.WeaterForecast1.Count)
				{
					foreach (var item in lbCities.Items)
					{
						if (item.ToString() == dd.WeaterForecast1[i].City)
						{
							check = true;
							break;            
						}
					}
					if (check == false)
					{
						lbCities.Items.Add(dd.WeaterForecast1[i].City);
					}
					check = false;
					i++;
				}
			}	
		}

		private void BtnGenerate_Click(object sender, RoutedEventArgs e)
		{
			Error();
			if (error == false)
			{
				DateTime endDate = Convert.ToDateTime(dpDate2.Text);
				if (endDate.Day != 31)
				{
					checkdate = true;
				}
				int i = 0;
				while (i < lbCities.Items.Count)
				{
					DateTime startDate = Convert.ToDateTime(dpDate1.Text);
					DateTime startMounth = Convert.ToDateTime(dpDate1.Text);
					for (int j = 0; j < dd.WeaterForecast1.Count; j++)
					{
						DateTime compareDate = Convert.ToDateTime(dd.WeaterForecast1[j].Date);
						DateTime compareMounth = Convert.ToDateTime(dd.WeaterForecast1[j].Date);
						if (lbCities.SelectedItems[i].Equals(dd.WeaterForecast1[j].City))
						{
							if (startDate.Day == 31 && endDate.Day == 31)
							{
								for (int u = 0; u < dd.WeaterForecast1.Count; u++)
								{
									if (lbCities.SelectedItems[i].Equals(dd.WeaterForecast1[u].City))
									{
										if (dd.WeaterForecast1[u].Date.Equals(dpDate2.Text))
										{
											newWindow2.Display(dd.WeaterForecast1[u].City, dd.WeaterForecast1[u].Date,
											dd.WeaterForecast1[u].MinTemp, dd.WeaterForecast1[u].MaxTemp,
											dd.WeaterForecast1[u].Precipitation, dd.WeaterForecast1[u].Humidity,
											dd.WeaterForecast1[u].WindSpeed);
										}
									}
								}
								endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day - 30);
							}
							startMounth = Convert.ToDateTime(dpDate1.Text);
							startDate = Convert.ToDateTime(dpDate1.Text);
							while (startDate.Day <= endDate.Day)
							{
								if (startDate.Day == compareDate.Day)
								{
									if (startMounth.Month == compareMounth.Month)
									{
										newWindow2.Display(dd.WeaterForecast1[j].City, dd.WeaterForecast1[j].Date,
										dd.WeaterForecast1[j].MinTemp, dd.WeaterForecast1[j].MaxTemp,
										dd.WeaterForecast1[j].Precipitation, dd.WeaterForecast1[j].Humidity,
										dd.WeaterForecast1[j].WindSpeed);
									}
									else
									{
										startMounth.AddMonths(1);
									}
								}
								if (endDate.Day == 31)
								{
									endDate = new DateTime (endDate.Year, endDate.Month, endDate.Day - 1);
								}
								if (compareDate.Day == 30 && startDate.Day == 30 && checkdate == false)
								{
									for (int u = 0; u < dd.WeaterForecast1.Count; u++)
									{
										if (lbCities.SelectedItems[i].Equals(dd.WeaterForecast1[u].City))
										{
											if (dd.WeaterForecast1[u].Date.Equals(dpDate2.Text))
											{
												newWindow2.Display(dd.WeaterForecast1[u].City, dd.WeaterForecast1[u].Date,
												dd.WeaterForecast1[u].MinTemp, dd.WeaterForecast1[u].MaxTemp,
												dd.WeaterForecast1[u].Precipitation, dd.WeaterForecast1[u].Humidity,
												dd.WeaterForecast1[u].WindSpeed);
											}
										}
									}
								}
								startDate = startDate.AddDays(1);
							}
						}
					}
					if (lbCities.SelectedItems.Count < lbCities.Items.Count)
					{
						 int num;
						 num = lbCities.Items.Count - lbCities.SelectedItems.Count;
						 i = i + num;
					}
					i++;
				}
				newWindow2.DataContext = newWindow2;
				this.Hide();
				newWindow2.ShowDialog();
			}
			else
			{
				error = false;
			}
		}

		private void BtnAdd_Click(object sender, RoutedEventArgs e)
		{
			AddWeatherReport newWindow = new AddWeatherReport();
			newWindow.DataContext = this;
			this.Hide();
			newWindow.ShowDialog();
		}

		private Boolean Error()
		{
			try
			{
				DateTime checkStartDate = Convert.ToDateTime(dpDate1.Text);
				DateTime checkEndDate = Convert.ToDateTime(dpDate2.Text);

				if (checkStartDate.Day > checkEndDate.Day)
				{
					error = true;
					MessageBox.Show("Please insure that the dates you selected are correct");
				}

				if (checkStartDate.Month != checkEndDate.Month)
				{
					error = true;
					MessageBox.Show("Please insure that the dates you selected are within one month");
				}

				if (lbCities.SelectedIndex == -1)
				{
					error = true;
					MessageBox.Show("Please insure that you selected a city");
				}

				if (dpDate1.Text.Equals("") || dpDate2.Text.Equals(""))
				{
					error = true;
					MessageBox.Show("Please insure that you picked your dates to view the weather forecast");
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Please insure that you picked your dates to view the weather forecast");
			}

			return error;
		}

		private void WeatherReports_Closed(object sender, EventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
