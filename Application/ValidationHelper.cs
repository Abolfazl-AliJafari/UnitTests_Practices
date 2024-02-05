using System;
namespace Application
{
	public class ValidationHelper
	{
		public ValidationHelper()
		{
		}

		public bool ValidateMobilePhone(string mobile)
		{
			if (mobile.Length is not 11)
			{
				return false;
			}
			if(!long.TryParse(mobile,out long mobileConverted))
			{
				return false;
			}
			return true;

		}
	}
}

