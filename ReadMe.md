# DotNet-Templates

A Template-package (NuGet) for creating items/projects/solutions in dotnet / Visual Studio. For the moment this Template-package only consists of multi-project / solution templates.

For the moment, because of an issue, the templates are not enabled in Visual Studio.

The templates are not yet published on nuget.org.

## 1 Using the templates

### 1.1 Install

	dotnet new install HansKindberg-DotNet-Templates

or (if testing locally)

	dotnet new install HansKindberg-DotNet-Templates --nuget-source "C:\Data\Projects\HansKindberg\DotNet-Templates\Source\Templates\bin\Debug"

or (if the package is in another nuget source)

	dotnet new install HansKindberg-DotNet-Templates --nuget-source "https://nuget.example.org/v3/index.json"

- [dotnet new install](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new-install)

### 1.2 Uninstall

	dotnet new uninstall HansKindberg-DotNet-Templates

### 1.3 Run

The prefix **HK** is for **Hans Kindberg**, my initials.

Small, Medium, Large and ExtraLarge is for "how much" the created solution will contain. See "2 Solution structure" below.

#### 1.3.1 HK-AspNet-Razor-ExtraLarge

	dotnet new hk-aspnet-razor-xl --name Example-Site

#### 1.3.2 HK-AspNet-Razor-Large

	dotnet new hk-aspnet-razor-l --name Example-Site

#### 1.3.3 HK-AspNet-Razor-Medium

	dotnet new hk-aspnet-razor-m --name Example-Site

#### 1.3.4 HK-AspNet-Razor-Small

	dotnet new hk-aspnet-razor-s --name Example-Site

#### 1.3.5 HK-Blazor-ExtraLarge

	dotnet new hk-blazor-xl --name Example-Blazor

#### 1.3.6 HK-Blazor-Large

	dotnet new hk-blazor-l --name Example-Blazor

#### 1.3.7 HK-Blazor-Medium

	dotnet new hk-blazor-m --name Example-Blazor

#### 1.3.8 HK-Blazor-Small

	dotnet new hk-blazor-s --name Example-Blazor

#### 1.3.9 HK-Blazor-Duende-ExtraLarge

	dotnet new hk-blazor-duende-xl --name Example-Blazor-Duende

#### 1.3.10 HK-Blazor-Duende-Large

	dotnet new hk-blazor-duende-l --name Example-Blazor-Duende

#### 1.3.11 HK-Blazor-Duende-Medium

	dotnet new hk-blazor-duende-m --name Example-Blazor-Duende

#### 1.3.12 HK-Blazor-Duende-Small

	dotnet new hk-blazor-duende-s --name Example-Blazor-Duende

#### 1.3.13 HK-NuGet-Package-ExtraLarge

	dotnet new hk-nuget-package-xl --name Example.NuGetPackage

#### 1.3.14 HK-NuGet-Package-Large

	dotnet new hk-nuget-package-l --name Example.NuGetPackage

#### 1.3.15 HK-NuGet-Package-Medium

	dotnet new hk-nuget-package-m --name Example.NuGetPackage

#### 1.3.16 HK-NuGet-Package-Small

	dotnet new hk-nuget-package-s --name Example.NuGetPackage

#### 1.3.17 HK-React-ExtraLarge

	dotnet new hk-react-xl --name Example-React

#### 1.3.18 HK-React-Large

	dotnet new hk-react-l --name Example-React

#### 1.3.19 HK-React-Medium

	dotnet new hk-react-m --name Example-React

#### 1.3.20 HK-React-Small

	dotnet new hk-react-s --name Example-React

#### 1.3.21 HK-React-Duende-ExtraLarge

	dotnet new hk-react-duende-xl --name Example-React-Duende

#### 1.3.22 HK-React-Duende-Large

	dotnet new hk-react-duende-l --name Example-React-Duende

#### 1.3.23 HK-React-Duende-Medium

	dotnet new hk-react-duende-m --name Example-React-Duende

#### 1.3.24 HK-React-Duende-Small

	dotnet new hk-react-duende-s --name Example-React-Duende

#### 1.3.25 HK-Service-ExtraLarge

	dotnet new hk-service-xl --name Example-Service

#### 1.3.26 HK-Service-Large

	dotnet new hk-service-l --name Example-Service

#### 1.3.27 HK-Service-Medium

	dotnet new hk-service-m --name Example-Service

#### 1.3.28 HK-Service-Small

	dotnet new hk-service-s --name Example-Service

## 2 Solution structure

The templates will create the following solution structure.

### 2.1 HK-AspNet-Razor-ExtraLarge

- .kubernetes
	- EgressNetworkPolicy.development-cluster.json
	- EgressNetworkPolicy.production-cluster.json
	- ReadMe.md
	- Template.yml
- Source
	- Application
		- ...
		- Application.csproj
		- appsettings.json
		- appsettings.Deploy.json
			- appsettings.Deploy.Production.json
			- appsettings.Deploy.Stage.json
			- appsettings.Deploy.Test.json
		- appsettings.Development.json
		- Dockerfile
		- ...
- Tests
	- Integration-tests
		- Integration-tests.csproj
	- Unit-tests
		- Unit-tests.csproj
	- .editorconfig
	- Directory.Build.props
	- Directory.Build.targets
- .dockerignore
- .editorconfig
- .gitignore
- Build.yml
- Deploy.yml
- Directory.Build.props
- Directory.Build.targets
- Name.sln (the --name parameter when you create it)
- NuGet.config
- Pipeline.yml
- ReadMe.md
- Variables.yml

### 2.2 HK-AspNet-Razor-Large

- Source
	- Application
		- ...
		- Application.csproj
		- appsettings.json
		- appsettings.Deploy.json
			- appsettings.Deploy.Production.json
			- appsettings.Deploy.Stage.json
			- appsettings.Deploy.Test.json
		- appsettings.Development.json
		- Dockerfile
		- ...
- Tests
	- Integration-tests
		- Integration-tests.csproj
	- Unit-tests
		- Unit-tests.csproj
	- .editorconfig
	- Directory.Build.props
	- Directory.Build.targets
- .dockerignore
- .editorconfig
- .gitignore
- Directory.Build.props
- Directory.Build.targets
- Name.sln (the --name parameter when you create it)
- NuGet.config
- ReadMe.md

### 2.3 HK-AspNet-Razor-Medium

- Source
	- Application
		- ...
		- Application.csproj
		- appsettings.json
		- appsettings.Deploy.json
			- appsettings.Deploy.Production.json
			- appsettings.Deploy.Stage.json
			- appsettings.Deploy.Test.json
		- appsettings.Development.json
		- Dockerfile
		- ...
- Tests
	- Integration-tests
		- Integration-tests.csproj
	- Unit-tests
		- Unit-tests.csproj
	- .editorconfig
- .dockerignore
- .editorconfig
- .gitignore
- Name.sln (the --name parameter when you create it)
- NuGet.config
- ReadMe.md

### 2.4 HK-AspNet-Razor-Small

- Source
	- Application
		- ...
		- Application.csproj
		- appsettings.json
		- appsettings.Deploy.json
			- appsettings.Deploy.Production.json
			- appsettings.Deploy.Stage.json
			- appsettings.Deploy.Test.json
		- appsettings.Development.json
		- Dockerfile
		- ...
- .dockerignore
- .editorconfig
- .gitignore
- Name.sln (the --name parameter when you create it)
- NuGet.config
- ReadMe.md

### 2.5 HK-Blazor-ExtraLarge

### 2.6 HK-Blazor-ExtraLarge

### 2.7 HK-Blazor-ExtraLarge

### 2.8 HK-Blazor-ExtraLarge

### 2.9 HK-Blazor-Duende-ExtraLarge

### 2.10 HK-Blazor-Duende-ExtraLarge

### 2.11 HK-Blazor-Duende-ExtraLarge

### 2.12 HK-Blazor-Duende-ExtraLarge

### 2.13 HK-NuGet-Package-ExtraLarge

- Source
	- Project
		- Project.csproj
		- ReadMe.md
- Tests
	- Integration-tests
		- Integration-tests.csproj
	- Unit-tests
		- Unit-tests.csproj
	- .editorconfig
	- Directory.Build.props
	- Directory.Build.targets
- .editorconfig
- .gitignore
- Build.yml
- Deploy.yml
- Directory.Build.props
- Directory.Build.targets
- Name.sln (the --name parameter when you create it)
- NuGet.config
- Pipeline.yml
- ReadMe.md
- Variables.yml

### 2.14 HK-NuGet-Package-Large

- Source
	- Project
		- Project.csproj
		- ReadMe.md
- Tests
	- Integration-tests
		- Integration-tests.csproj
	- Unit-tests
		- Unit-tests.csproj
	- .editorconfig
	- Directory.Build.props
	- Directory.Build.targets
- .editorconfig
- .gitignore
- Directory.Build.props
- Directory.Build.targets
- Name.sln (the --name parameter when you create it)
- NuGet.config
- ReadMe.md

### 2.15 HK-NuGet-Package-Medium

- Source
	- Project
		- Project.csproj
		- ReadMe.md
- Tests
	- Integration-tests
		- Integration-tests.csproj
	- Unit-tests
		- Unit-tests.csproj
	- .editorconfig
- .editorconfig
- .gitignore
- Name.sln (the --name parameter when you create it)
- NuGet.config
- ReadMe.md

### 2.16 HK-NuGet-Package-Small

- Source
	- Project
		- Project.csproj
		- ReadMe.md
- .editorconfig
- .gitignore
- Name.sln (the --name parameter when you create it)
- NuGet.config
- ReadMe.md

### 2.17 HK-React-ExtraLarge

### 2.18 HK-React-Large

### 2.19 HK-React-Medium

### 2.20 HK-React-Small

### 2.21 HK-React-Duende-ExtraLarge

### 2.22 HK-React-Duende-Large

### 2.23 HK-React-Duende-Medium

### 2.24 HK-React-Duende-Small

### 2.25 HK-Service-ExtraLarge

### 2.26 HK-Service-Large

### 2.27 HK-Service-Medium

### 2.28 HK-Service-Small

## 3 Development

I am using Visual Studio 2022 - 17.8.3 when starting this project.

This project/solution was initially created with:

	dotnet new templatepack -n "Templates"

To have "templatepack" you need to install [Microsoft.TemplateEngine.Authoring.Templates](https://www.nuget.org/packages/Microsoft.TemplateEngine.Authoring.Templates):

	dotnet new install Microsoft.TemplateEngine.Authoring.Templates

### 3.1 Adjustments

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

### 3.2 Install / uninstall

- [dotnet new install](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new-install)

How to install/uninstall during development.

#### 3.2.1 Locally built NuGet-package

cd to Source\Templates\bin\Debug.

Install:

	dotnet new install HansKindberg-DotNet-Templates.0.0.1-alpha.1.nupkg

Uninstall:

	dotnet new uninstall HansKindberg-DotNet-Templates

#### 3.2.2 Local folder

Install:

	dotnet new install <PATH>

Uninstall:

	dotnet new uninstall <PATH>

Where `<PATH>` is the path to the folder containing .template.config.

### 3.3 Try the templates

cd to your project directory.

	dotnet new hk-aspnet-razor-l --name hk-aspnet-razor-l

	dotnet new hk-aspnet-razor-m --name hk-aspnet-razor-m

	dotnet new hk-aspnet-razor-s --name hk-aspnet-razor-s

	dotnet new hk-aspnet-razor-xl --name hk-aspnet-razor-xl

	dotnet new hk-blazor-l --name hk-blazor-l

	dotnet new hk-blazor-m --name hk-blazor-m

	dotnet new hk-blazor-s --name hk-blazor-s

	dotnet new hk-blazor-xl --name hk-blazor-xl

	dotnet new hk-blazor-duende-l --name hk-blazor-duende-l

	dotnet new hk-blazor-duende-m --name hk-blazor-duende-m

	dotnet new hk-blazor-duende-s --name hk-blazor-duende-s

	dotnet new hk-blazor-duende-xl --name hk-blazor-duende-xl

	dotnet new hk-nuget-package-l --name hk.nuget.package.l

	dotnet new hk-nuget-package-m --name hk.nuget.package.m

	dotnet new hk-nuget-package-s --name hk.nuget.package.s

	dotnet new hk-nuget-package-xl --name hk.nuget.package.xl

	dotnet new hk-react-l --name hk-react-l

	dotnet new hk-react-m --name hk-react-m

	dotnet new hk-react-s --name hk-react-s

	dotnet new hk-react-xl --name hk-react-xl

	dotnet new hk-react-duende-l --name hk-react-duende-l

	dotnet new hk-react-duende-m --name hk-react-duende-m

	dotnet new hk-react-duende-s --name hk-react-duende-s

	dotnet new hk-react-duende-xl --name hk-react-duende-xl

	dotnet new hk-service-l --name hk-service-l

	dotnet new hk-service-m --name hk-service-m

	dotnet new hk-service-s --name hk-service-s

	dotnet new hk-service-xl --name hk-service-xl

### 3.4 Important

We have experienced problems when the solution-files included in the templates are not **UTF-8-BOM** encoded. If we make changes in the *.sln files we should verify that they are **UTF-8-BOM** encoded. If not, make them **UTF-8-BOM** encoded with Notepadd++ for example.

This seems to happen even if we have this in .editorconfig:

	[*.{cshtml,sln}]
	charset = utf-8-bom

### 3.5 Links

- [Package authoring best practices](https://learn.microsoft.com/en-us/nuget/create-packages/package-authoring-best-practices)

## 4 Thanks Damien Bowden

His article/work led me the way to build "solution"-templates:

- [CREATING DOTNET SOLUTION AND PROJECT TEMPLATES](https://damienbod.com/2022/08/15/creating-dotnet-solution-and-project-templates/)
- [NuGet – Blazor.BFF.OpenIDConnect.Template](https://www.nuget.org/packages/Blazor.BFF.OpenIDConnect.Template)
- [GitHub – Blazor.BFF.OpenIDConnect.Template](https://github.com/damienbod/Blazor.BFF.OpenIDConnect.Template)

## 5 Links

- https://github.com/sayedihashimi/template-sample
- https://github.com/dotnet/templating
- [Reference for template.json](https://github.com/dotnet/templating/wiki/Reference-for-template.json)
- [Reference for template.json - guids](https://github.com/dotnet/templating/wiki/Reference-for-template.json#guids)
- [Tutorial: Create a template package - Create a template package project](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-template-package?pivots=dotnet-8-0#create-a-template-package-project)
- [Visual Studio solution-structure for Docker-project with .editorconfig, Directory.Build.props and Directory.Build.targets](https://hanskindberg.wordpress.com/2023/12/21/visual-studio-solution-structure-for-docker-project-with-editorconfig-directory-build-props-and-directory-build-targets/)
- [Google: build visual studio template package](https://www.google.com/search?q=build+visual+studio+template+package)
- [Tutorial: Create a template package](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-template-package?pivots=dotnet-8-0)
- [Tutorial: Create a project template](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-project-template)
- https://github.com/dotnet/sdk/blob/main/template_feed/Microsoft.DotNet.Common.ProjectTemplates.9.0/Microsoft.DotNet.Common.ProjectTemplates.9.0.csproj
- [Google: template.json tags type solution](https://www.google.com/search?q=template.json+tags+type+solution)
- https://github.com/dotnet/templating/tree/main/dotnet-template-samples/content/05-multi-project
- [Create dotnet new template with multiple projects](https://medium.com/@stoyanshopov032/create-dotnet-new-template-with-multiple-projects-5df240ed81b4)
- [How to create your own templates for dotnet new](https://devblogs.microsoft.com/dotnet/how-to-create-your-own-templates-for-dotnet-new/)
- https://github.com/dotnet/dotnet-template-samples
- https://github.com/dotnet/dotnet-template-samples/tree/master/05-multi-project
- [Create Solution Template - group of projects #611](https://github.com/dotnet/templating/issues/611)
- [How does project system determine if the project is ASPNET or generic C#? #3079](https://github.com/dotnet/project-system/issues/3079)

## 6 BAKUP FOR A MOMENT - REMOVE LATER

### 1.3 Issue

Creating solutions with the templates gives a ".vs" folder in the root. Don't know why. This is for the moment removed with a **postAction**. It should be possible to fix it in another way. But for the moment...