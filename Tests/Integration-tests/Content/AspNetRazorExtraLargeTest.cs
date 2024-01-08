using Xunit;

namespace IntegrationTests.Content
{
	public class AspNetRazorExtraLargeTest : TemplateTest
	{
		#region Properties

		public override string BasePath => "content/AspNet-Razor-ExtraLarge";

		#endregion

		#region Methods

		[Fact]
		public async Task Content_Test()
		{
			await Task.CompletedTask;

			using(var packageArchiveReader = this.CreatePackageArchiveReader())
			{
				var files = packageArchiveReader.GetFiles(this.BasePath);
				Assert.Equal(50, files.Count());
			}
		}

		[Fact]
		public async Task EditorConfig_Test()
		{
			using(var packageArchiveReader = this.CreatePackageArchiveReader())
			{
				var entry = this.GetEntry(".editorconfig", packageArchiveReader);
				using(var stream = entry.Open())
				{
					using(var streamReader = new StreamReader(stream))
					{
						var content = await streamReader.ReadToEndAsync();

						Assert.Contains("dotnet_analyzer_diagnostic.severity = error", content);
					}
				}
			}
		}

		[Fact]
		public async Task GitIgnore_Test()
		{
			using(var packageArchiveReader = this.CreatePackageArchiveReader())
			{
				var entry = this.GetEntry(".gitignore", packageArchiveReader);
				using(var stream = entry.Open())
				{
					using(var streamReader = new StreamReader(stream))
					{
						var content = await streamReader.ReadToEndAsync();

						Assert.Contains("Source/Application/wwwroot/Scripts/*", content);
						Assert.Contains("!Source/Application/wwwroot/Scripts/.gitkeep", content);
						Assert.Contains("Source/Application/wwwroot/Style/*", content);
						Assert.Contains("!Source/Application/wwwroot/Style/.gitkeep", content);
					}
				}
			}
		}

		[Fact]
		public async Task NuGetConfig_Test()
		{
			using(var packageArchiveReader = this.CreatePackageArchiveReader())
			{
				var entry = this.GetEntry("NuGet.config", packageArchiveReader);
				using(var stream = entry.Open())
				{
					using(var streamReader = new StreamReader(stream))
					{
						var content = await streamReader.ReadToEndAsync();

						Assert.Contains("\t\t<add key=\"nuget.org\" protocolVersion=\"3\" value=\"https://api.nuget.org/v3/index.json\" />", content);
					}
				}
			}
		}

		[Fact]
		public async Task ReadMe_Test()
		{
			using(var packageArchiveReader = this.CreatePackageArchiveReader())
			{
				var entry = this.GetEntry("ReadMe.md", packageArchiveReader);
				using(var stream = entry.Open())
				{
					using(var streamReader = new StreamReader(stream))
					{
						var content = await streamReader.ReadToEndAsync();

						Assert.Equal(this.ReadMeHeading, content);
					}
				}
			}
		}

		#endregion
	}
}