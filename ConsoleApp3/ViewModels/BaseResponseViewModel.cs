using System;

namespace ConsoleApp3.ViewModels
{
	public class BaseResponseViewModel
	{
		public BaseResponseViewModel()
		{
			Message = string.Empty;
		}

		public bool Success { get; set; }
		public string Message { get; set; }
		public string ExMessage { get; set; }
		public Exception ExError { get; set; }
	}
}