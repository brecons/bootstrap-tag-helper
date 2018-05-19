# Getting started

This article demonstrates how to include Bocons Tag Helpers into an ASP.NET Core Web Application.

## Create new ASP.NET Core Web Application

The first step is to create a new project in Visual Studio. Choose the ***Web*** rubric and subsequent the ***ASP.NET Core Web Application*** template. Adapt the project parameters like ***Name***, ***Location*** and ***Solution name*** and click ***OK***.

![New ASP.NET Core Web Application](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/getting-started_01.PNG)

In the following dialog choose the ***.NET Core*** Framework and the ***ASP.NET Core 2.0*** version as well as a project template. Optionally change the authentication and click ***OK***.

![Project Configuration](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/getting-started_02.PNG)

***Please note:*** If you choose a empty template you have to include Bootstrap manually with Bower Package Manager. For further informations check Update Bower Packages chapter.

## Install NuGet Packages

After successfully creating an new ASP.NET Core Web Application, right click on the project folder and choose ***Manage NuGet Packages...*** to open the NuGet Package Manager.

![Manage NuGet Packages](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/getting-started_03.PNG)

In NuGet Package Manager search for `Bocons` package, choose it and click ***Install***. All necessary bin files and dependencies for Bocons will be installed.

![Bocons NuGet Package](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/getting-started_03.PNG)

***Please note:*** Not every Bocons package is compatible with every Bootstrap version. For further information check the description of the selected package.

## Update Bower Packages

After installation a Bocons NuGet package it is necessary to load the compatible Bower packages of Bootstrap, jQuery, jQuery Validation and jQuery Validation Unobtrusive. For further informations which of these frameworks are compatible with your choosen Bocons package check the package description.

To update the Bower packages open the `bower.json` in the project root directory and set the correct versions of the required frameworks:

```json
{
    "name": "asp.net",
    "private": true,
    "dependencies": {
        "bootstrap": "v4.0.0-beta",
        "jquery": "3.2.1",
        "jquery-validation": "1.17.0",
        "jquery-validation-unobtrusive": "3.2.6"
    }
}
```

## Add Service Configuration

To ensure that Bocons runs correctly it is necessary to adapt the `Startup.cs`. Register inside the `ConfigureServices` method a singleton for the `IActionContextAccessor` and import the namespace `Microsoft.AspNetCore.Mvc.Infrastructure`.

```csharp
using Microsoft.AspNetCore.Mvc.Infrastructure

public void ConfigureServices(IServiceCollection services)
{
	// Add a singleton for IActionContextAccessor
    services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

    services.AddMvc();
}
```

## Modify View Imports

Lastly it is mandatory to modify `/Views/_ViewImports.cshtml` and enable the Bocons Tag Helpers for the web application views:

```markup
@using MyCompany.MyApplication
@using MyCompany.MyApplication.Models
@using BSolutions.Bocons.Enumerations
@using BSolutions.Brecons.Core.Enumerations
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
@addTagHelper *, BSolutions.Bocons
```

Please pay particular attention to line 3, 4 and 6 of the above sample and insert these into your `_ViewImports.cshtml` file. Thats all! Now you can build your project and use the Bocons Tag Helpers in every view.