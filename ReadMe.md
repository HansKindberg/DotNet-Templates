# DotNet-Templates













## BACKUP
		<!--<ItemGroup>
			--><!-- https://gist.github.com/robatwilliams/6512233 --><!--
			<Projects Include="$([System.IO.Directory]::GetDirectories('content'))" />
		</ItemGroup>
		
			<Message Importance="high" Text="%(Projects.Identity)" />
			--><!--
		--><!--
		--><!--
			https://www.jrdodds.com/blog/2021/8/23/msbuild-metadata-doesnt-support-string-instance-methods
			<HasSuffix>$([System.String]::Copy('%(Filename)').Endswith('$(suffix)'))</HasSuffix>
		--><!--
		<Copy Condition="$([System.String]::Copy('%(Projects.Identity)').EndsWith('-Pages'))" DestinationFolder="%(Projects.Identity)" SourceFiles="Common/.editorconfig;Common/.gitignore;Common/Directory.Build.props;Common/Directory.Build.targets;Common/NuGet.config;Common/ReadMe.md" />
		<TransformTask Condition="$([System-->.String]::Copy('%(Projects.Identity)').EndsWith('Arne'))" Destination="%(Projects.Identity)/.template.config/template.json" Source="Common/.template.config/Solution.Template.json" Transform="%(Projects.Identity)/.template.config/Transform.Template.json" />



















A Template-package (NuGet) for creating items/projects/solutions in dotnet / Visual Studio. For the moment this Template-package only consists of multi-project / solution templates.

For the moment, because of an issue, the templates are not enabled in Visual Studio.

## 1 Using the templates

### 1.1 Install

	dotnet new install HansKindberg-DotNet-Templates

### 1.2 Uninstall

	dotnet new uninstall HansKindberg-DotNet-Templates

### 1.3 Issue

Creating solutions with the templates gives a ".vs" folder in the root. Don't know why. This is for the moment removed with a **postAction**. It should be possible to fix it in another way. But for the moment...











### 1.4 Run

Small, Medium, Large etc. explanation.

The prefix **HK** is for **Hans Kindberg**, my initials.

#### 1.4.1 HK-AspNet-Razor-Large

	dotnet new hk-aspnet-razor-l --name Example-Site

or

	dotnet new HK-AspNet-Razor-Large --name Example-Site

#### 1.4.2 HK-AspNet-Razor-Medium

	dotnet new hk-aspnet-razor-m --name Example-Site

or

	dotnet new HK-AspNet-Razor-Medium --name Example-Site

#### 1.4.3 HK-AspNet-Razor-Small

	dotnet new hk-aspnet-razor-s --name Example-Site

or

	dotnet new HK-AspNet-Razor-Small --name Example-Site

#### 1.4.4 HK-NuGet-Package-Large

	dotnet new hk-nuget-package-l --name Example.NuGetPackage

or

	dotnet new HK-NuGet-Package-Large --name Example.NuGetPackage

#### 1.4.5 HK-NuGet-Package-Medium

	dotnet new hk-nuget-package-m --name Example.NuGetPackage

or

	dotnet new HK-NuGet-Package-Medium --name Example.NuGetPackage

#### 1.4.6 HK-NuGet-Package-Small

	dotnet new hk-nuget-package-s --name Example.NuGetPackage

or

	dotnet new HK-NuGet-Package-Small --name Example.NuGetPackage










<!-- aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
#### 1.4.1 NuGet-Package-Large

	dotnet new hk-nuget-package-l --name MyCompany.NuGetPackage --allow-scripts yes

#### 1.4.2 NuGet-Package-Medium

	dotnet new hk-nuget-package-m --name MyCompany.NuGetPackage --allow-scripts yes

#### 1.4.3 NuGet-Package-Small

	dotnet new hk-nuget-package-s --name MyCompany.NuGetPackage --allow-scripts yes
aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa -->










dotnet new blazorbffoidc -n YourCompany.Bff --HttpsPortCustom 44348





Use the -n or --name parameter to change the name of the output created. This string is also used to substitute the namespace name in the .cs file for the project.







## 2 Solution structure

### 2.1 HK-AspNet-Razor-Large

### 2.2 HK-AspNet-Razor-Medium

### 2.3 HK-AspNet-Razor-Small

### 2.4 HK-NuGet-Package-Large

### 2.5 HK-NuGet-Package-Medium

### 2.6 HK-NuGet-Package-Small



















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

Install:

	dotnet new install Blazor.BFF.OpenIDConnect.Template.3.0.0.nupkg

Uninstall:

	dotnet new uninstall Blazor.BFF.OpenIDConnect.Template.3.0.0.nupkg

#### 3.2.2 Local folder

Install:

	dotnet new install <PATH>

Uninstall:

	dotnet new uninstall <PATH>

Where `<PATH>` is the path to the folder containing .template.config.
















### 3.3 Links

- [Package authoring best practices](https://learn.microsoft.com/en-us/nuget/create-packages/package-authoring-best-practices)






## 4 Thanks Damien Bowden

His article/works led me the way to build "solution"-templates:

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