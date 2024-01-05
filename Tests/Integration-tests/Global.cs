using System.Diagnostics;
using System.Reflection;

namespace IntegrationTests
{
	public static class Global
	{
		#region Fields

		private static FileInfo? _nuGetPackageFile;
		private static string? _nuGetPackageName;
		private static string? _nuGetPackageVersion;
		private static readonly char[] _separators = ['\\', '/'];
		private static Assembly? _templatesAssembly;
		private static FileInfo? _templatesAssemblyFile;

		#endregion

		#region Properties

		public static FileInfo NuGetPackageFile
		{
			get
			{
				if(_nuGetPackageFile == null)
				{
					var replaceItems = new[] { string.Empty, "Tests", "Integration-tests", string.Empty };
					var replacementItems = new[] { string.Empty, "Source", "Templates", string.Empty };
					var replacements = _separators.ToDictionary(separator => string.Join(separator, replaceItems), separator => string.Join(separator, replacementItems));

					var directory = TemplatesAssemblyFile.Directory!.Parent!.FullName;
					foreach(var replacement in replacements)
					{
						directory = directory.Replace(replacement.Key, replacement.Value);
					}

					_nuGetPackageFile = new FileInfo(Path.Combine(directory, $"{NuGetPackageName}.{NuGetPackageVersion}.nupkg"));
				}

				return _nuGetPackageFile;
			}
		}

		public static string NuGetPackageName => _nuGetPackageName ??= TemplatesAssembly.GetName().Name!;
		public static string NuGetPackageVersion => _nuGetPackageVersion ??= FileVersionInfo.GetVersionInfo(TemplatesAssembly.Location).ProductVersion!;
		public static Assembly TemplatesAssembly => _templatesAssembly ??= typeof(Templates.Global).Assembly;
		public static FileInfo TemplatesAssemblyFile => _templatesAssemblyFile ??= new FileInfo(TemplatesAssembly.Location);

		#endregion
	}
}