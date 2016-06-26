using System;  
using System.Threading.Tasks;  
using Xunit;
using pclLibrary;

namespace pclLibraryTests
{
	public class MyClassTests
	{
		[Fact]
		public void GenerateShouldAddOldWithNew()
		{
			Assert.Equal("oldnew", pclLibrary.MyClass.Generate("old", "new"));
		}
	}
}