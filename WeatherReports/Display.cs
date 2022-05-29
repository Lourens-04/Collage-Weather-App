using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WeatherReports
{
	class Display
	{
		private string dcity;
		private string ddate;
		private string dminTemp;
		private string dmaxTemp;
		private string dprecipitation;
		private string dhumidity;
		private string dwindSpeed;
		private BitmapImage dimage;


		public string Dcity { get => dcity; set => dcity = value; }
		public string Ddate { get => ddate; set => ddate = value; }
		public string DminTemp { get => dminTemp; set => dminTemp = value; }
		public string DmaxTemp { get => dmaxTemp; set => dmaxTemp = value; }
		public string Dprecipitation { get => dprecipitation; set => dprecipitation = value; }
		public string Dhumidity { get => dhumidity; set => dhumidity = value; }
		public string DwindSpeed { get => dwindSpeed; set => dwindSpeed = value; }
		public BitmapImage Dimage { get => dimage; set => dimage = value; }
	}
}
