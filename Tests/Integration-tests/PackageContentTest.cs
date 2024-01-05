using NuGet.Packaging;
using Xunit;

namespace IntegrationTests
{
	/// <summary>
	/// NuGet Client SDK - Read a package: https://learn.microsoft.com/en-us/nuget/reference/nuget-client-sdk#read-a-package
	/// </summary>
	public class PackageContentTest
	{
		#region Methods

		[Fact]
		public async Task NuGet_DependencyGroups_Test()
		{
			await Task.CompletedTask;

			using(var packageArchiveReader = new PackageArchiveReader(Global.NuGetPackageFile.FullName))
			{
				var dependencyGroups = packageArchiveReader.NuspecReader.GetDependencyGroups();
				Assert.Empty(dependencyGroups);
			}
		}

		[Fact]
		public async Task NuGet_Files_Test()
		{
			await Task.CompletedTask;

			using(var packageArchiveReader = new PackageArchiveReader(Global.NuGetPackageFile.FullName))
			{
				var files = packageArchiveReader.GetFiles();
				Assert.Equal(513, files.Count());
			}
		}

		[Fact]
		public async Task NuGet_PackageTypes_Test()
		{
			await Task.CompletedTask;

			using(var packageArchiveReader = new PackageArchiveReader(Global.NuGetPackageFile.FullName))
			{
				var packageTypes = packageArchiveReader.NuspecReader.GetPackageTypes();
				_ = Assert.Single(packageTypes);
				Assert.Equal("Template", actual: packageTypes[0].Name);
			}
		}

		[Fact]
		public async Task NuGet_Readme_Test()
		{
			await Task.CompletedTask;

			using(var packageArchiveReader = new PackageArchiveReader(Global.NuGetPackageFile.FullName))
			{
				Assert.Equal("ReadMe.md", packageArchiveReader.NuspecReader.GetReadme());
			}
		}

		[Fact]
		public async Task NuGet_Specification_Test()
		{
			await Task.CompletedTask;

			using(var packageArchiveReader = new PackageArchiveReader(Global.NuGetPackageFile.FullName))
			{
				var nuspecReader = packageArchiveReader.NuspecReader;
				Assert.Equal("Hans Kindberg", nuspecReader.GetAuthors());
				Assert.Equal("TODO: fill the package description here", nuspecReader.GetDescription());
				Assert.Equal(Global.NuGetPackageName, nuspecReader.GetId());
				Assert.Equal(Global.NuGetPackageVersion, nuspecReader.GetVersion().OriginalVersion);
			}
		}

		#endregion
	}
}