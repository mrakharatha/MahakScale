using System.Globalization;

namespace ConsoleApp3.ViewModels
{
	public class GetWeightResponseViewModel
	{
		public BaseResponseViewModel GetResult { get; set; }
		public GetWeightResponseViewModel()
		{
			GetResult = new BaseResponseViewModel();
		}

		//وزنی که ترازو ارسال می کند
		public int ScaleWeight { get; set; }

		//وزن ارسالی ترازو را تقسیم بر 1000 می کنیم تا مقدار واقعی وزن ترازو به دست آید که این مقدار در صفحه نمایش ترازو نیز قابل مشاهده است
		//در محاسبات خود همواره این متغیر را در نظر داشته باشید
		public double WeightDouble { get; set; }

		//آیا وزن ارسالی ترازو بر حسب گرم است یا کیلوگرم ؟
		public string WeightUnit { get; set; }

		//public string GetFinalWeightShow => WeightDouble.ToString(CultureInfo.InvariantCulture) + " " + WeightUnit;
		public string GetFinalWeightShow => WeightDouble.ToString(CultureInfo.InvariantCulture);
	}

}