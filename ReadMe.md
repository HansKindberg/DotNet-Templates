# DotNet-Templates

A Template-package (NuGet) for creating items/projects/solutions in dotnet / Visual Studio. For the moment this Template-package only consists of multi-project / solution templates.

## 1 Development

I am using Visual Studio 2022 - 17.8.3 when starting this project.

This project/solution was initially created with:

	dotnet new templatepack -n "Templates"

To have "templatepack" you need to install [Microsoft.TemplateEngine.Authoring.Templates](https://www.nuget.org/packages/Microsoft.TemplateEngine.Authoring.Templates):

	dotnet new install Microsoft.TemplateEngine.Authoring.Templates

### 1.1 Adjustments

After creating the project with:

	dotnet new templatepack -n "Templates"

I had to do some adjustments:

	<Project Sdk="Microsoft.NET.Sdk">
		<PropertyGroup>
			...
			<GeneratePackageOnBuild>true</GeneratePackageOnBuild><!-- Added this row. -->
			...
			<SuppressDependenciesWhenPacking>true</SuppressDependenciesWhenPacking><!-- Added this row. -->
			...
		</PropertyGroup>
		...
		<ItemGroup>
			...
			<Content Include="content\**\*" Exclude="content\**\bin\**;content\**\obj\**">
				<PackagePath>content</PackagePath><!-- Added this row. -->
			</Content>
			...
		</ItemGroup>
		...
	</Project>

Got help by looking at:

- https://github.com/dotnet/sdk/blob/main/template_feed/Microsoft.DotNet.Common.ProjectTemplates.9.0/Microsoft.DotNet.Common.ProjectTemplates.9.0.csproj

### 1.2 Install / uninstall

- [dotnet new install](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new-install)

How to install/uninstall during development.

#### 1.2.1 Locally built NuGet-package

Install:

	dotnet new install Blazor.BFF.OpenIDConnect.Template.3.0.0.nupkg

Uninstall:

	dotnet new uninstall Blazor.BFF.OpenIDConnect.Template.3.0.0.nupkg

#### 1.2.2 Local folder

Install:

	dotnet new install <PATH>

Uninstall:

	dotnet new uninstall <PATH>

Where `<PATH>` is the path to the folder containing .template.config.
















### 1.3 Links

- [Package authoring best practices](https://learn.microsoft.com/en-us/nuget/create-packages/package-authoring-best-practices)






## 2 Thanks Damien Bowden

His article/works led me the way to build "solution"-templates:

- [CREATING DOTNET SOLUTION AND PROJECT TEMPLATES](https://damienbod.com/2022/08/15/creating-dotnet-solution-and-project-templates/)
- [NuGet – Blazor.BFF.OpenIDConnect.Template](https://www.nuget.org/packages/Blazor.BFF.OpenIDConnect.Template)
- [GitHub – Blazor.BFF.OpenIDConnect.Template](https://github.com/damienbod/Blazor.BFF.OpenIDConnect.Template)

## 3 Links

- [Tutorial: Create a template package - Create a template package project](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-template-package?pivots=dotnet-8-0#create-a-template-package-project)
- [Visual Studio solution-structure for Docker-project with .editorconfig, Directory.Build.props and Directory.Build.targets](https://hanskindberg.wordpress.com/2023/12/21/visual-studio-solution-structure-for-docker-project-with-editorconfig-directory-build-props-and-directory-build-targets/)