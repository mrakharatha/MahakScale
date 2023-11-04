using MahakScale;
using NewDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp3.CommonTools;

namespace ConsoleApp3
{
	internal class Program
	{
		public static NewMahakScale MahakScale { get; set; }

		static void Main(string[] args)
		{
			var portComValue = int.Parse("3");
			var portCom = "COM" + portComValue;
			var baudRate = 9600;
			MahakScale = new NewMahakScale(false, string.Empty, 0, portCom, baudRate, false, false, true, false);

			//بررسی فعال بودن ترازوی دریافت شده
			if (MahakScale.mahakScales[portComValue] != null && MahakScale.mahakScales[portComValue].isActive)
			{
				Console.WriteLine("Communication with the scale was established");


				var getWeightScale = RenderScaleInstructions.GetWeight(portComValue, MahakScale);
				var result = getWeightScale.GetResult;

				if (result.Success)
				{
					Console.WriteLine(result.Message);
					Disconnect();
				}





			}
			else
			{
				Console.WriteLine("Communication with the scale could not be established");
			}

			Thread.Sleep(-1);

		}

		private static void Disconnect()
		{
			try
			{
				if (MahakScale == null) return;
				foreach (var item in MahakScale.mahakScales)
				{
					if (item == null) continue;
					item.Dispose();
					item.CloseConnection();
				}
				MahakScale.Dispose();
				MahakScale = null;
			}
			catch (Exception)
			{
				// ignored
			}
		}

	}
}
