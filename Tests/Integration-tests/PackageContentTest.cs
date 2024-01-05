using Xunit;

namespace IntegrationTests
{
	public class PackageContentTest
	{
		#region Methods

		[Fact]
		public async Task A_First_Test_That_Later_Should_Be_Removed()
		{
			await Task.CompletedTask;

			Assert.Equal(1, 1);
		}

		#endregion
	}
}