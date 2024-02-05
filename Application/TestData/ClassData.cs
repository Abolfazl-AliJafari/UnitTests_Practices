using System;
using System.Collections;

namespace Application.TestData
{
	public class ClassData : IEnumerable<object[]>
	{
        public ClassData()
        {

        }
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "09053611296", true };
            yield return new object[] { "0905361126", false };
            yield return new object[] { "djvb3829r34", false };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

