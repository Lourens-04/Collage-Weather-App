using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WeatherReports
{
	class Reports
	{
		public static IList<AddReport> WeaterForecast = new List<AddReport>();
		internal IList<AddReport> WeaterForecast1 { get => WeaterForecast; set => WeaterForecast = value; }

		public void Values()
		{
			WeaterForecast1.Add(new AddReport("Durban", "3/1/2019", "15", "20", "40", "20", "27"));
			WeaterForecast1.Add(new AddReport("Durban", "3/2/2019", "10", "25", "20", "40", "17"));
			WeaterForecast1.Add(new AddReport("Durban", "3/3/2019", "9", "15", "10", "54", "37"));
			WeaterForecast1.Add(new AddReport("Durban", "3/4/2019", "25", "30", "10", "10", "2"));
			WeaterForecast1.Add(new AddReport("Durban", "3/5/2019", "10", "15", "30", "4", "22"));
			WeaterForecast1.Add(new AddReport("Durban", "3/6/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Durban", "3/7/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Durban", "3/8/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/9/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/10/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/11/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Durban", "3/12/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Durban", "3/13/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/14/2019", "10", "15", "30", "4", "22"));
			WeaterForecast1.Add(new AddReport("Durban", "3/15/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Durban", "3/16/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Durban", "3/17/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/18/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/19/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/20/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Durban", "3/21/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Durban", "3/22/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/23/2019", "10", "15", "30", "4", "22"));
			WeaterForecast1.Add(new AddReport("Durban", "3/24/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Durban", "3/25/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Durban", "3/26/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/27/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/28/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/29/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/30/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Durban", "3/31/2019", "11", "28", "10", "22", "18"));

			WeaterForecast1.Add(new AddReport("Cape Town", "3/1/2019", "10", "15", "30", "4", "22"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/2/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/3/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/4/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/5/2019", "10", "15", "30", "4", "22"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/6/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/7/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/8/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/9/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/10/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/11/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/12/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/13/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/14/2019", "10", "15", "30", "4", "22"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/15/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/16/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/17/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/18/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/19/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/20/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/21/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/22/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/23/2019", "10", "15", "30", "4", "22"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/24/2019", "17", "20", "50", "67", "30"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/25/2019", "20", "23", "80", "24", "14"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/26/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/27/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/28/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/29/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/30/2019", "11", "28", "10", "22", "18"));
			WeaterForecast1.Add(new AddReport("Cape Town", "3/31/2019", "10", "15", "30", "4", "22"));


		}
	}
}
