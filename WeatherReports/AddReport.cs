﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherReports
{
	class AddReport
	{
		private string city;
		private string date;
		private string minTemp;
		private string maxTemp;
		private string precipitation;
		private string humidity;
		private string windSpeed;

		public AddReport(string city, string date, string minTemp, string maxTemp, string precipitation, string humidity, string windSpeed)
		{
			this.City = city;
			this.Date = date;
			this.MinTemp = minTemp;
			this.MaxTemp = maxTemp;
			this.Precipitation = precipitation;
			this.Humidity = humidity;
			this.WindSpeed = windSpeed;
		}

		public string City { get => city; set => city = value; }
		public string Date { get => date; set => date = value; }
		public string MinTemp { get => minTemp; set => minTemp = value; }
		public string MaxTemp { get => maxTemp; set => maxTemp = value; }
		public string Precipitation { get => precipitation; set => precipitation = value; }
		public string Humidity { get => humidity; set => humidity = value; }
		public string WindSpeed { get => windSpeed; set => windSpeed = value; }
	}
}
