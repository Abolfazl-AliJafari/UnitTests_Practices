using System;
using Application.TestData;

namespace Application.Test
{
	public class ValidationHelperTest
	{
		public ValidationHelperTest()
		{
		}


        [Theory]
        //Get Inputs Incode
        [InlineData("09053611296", true)]
        [InlineData("0905361126", false)]
        [InlineData("09053sdv6", false)]
        //
        public void ValidateMobilePhone(string mobile, bool output)
        {
            ValidationHelper validationHelper = new ValidationHelper();
            var result = validationHelper.ValidateMobilePhone(mobile);

            Assert.Equal(output, result);
        }


        [Theory]
        //Get Inputs from external source
        [ClassData(typeof(ClassData))]
        //
        //Create Category for tests
        [Trait("Services","User")]
        //
        public void ValidateMobilePhone_ClassData(string mobile, bool output)
        {
            ValidationHelper validationHelper = new ValidationHelper();
            var result = validationHelper.ValidateMobilePhone(mobile);

            Assert.Equal(output, result);
        }
    }
}

