using Xunit;

namespace IntegrationTests.Content
{
	public class AspNetRazorExtraLargeTest
	{
		#region Methods

		[Fact]
		public async Task Test()
		{
			await Task.CompletedTask;

			Assert.True(true); // Global.ProjectDirectory.FullName);
		}

		#endregion
	}
}