# Bootstrap Tag Helper ([Bocons](https://www.brecons.net/Product/Bocons))

## About Bocons
Bocons is a free tag helper library for Bootstrap (Version 4) - the world's most popular mobile-first and responsive front-end framework.
Bocons is one of a [Brecons](https://www.brecons.net) product and provides components and controls to use in a ASP.NET Core web application.

## Compatibility and Requirements
| Target Framework | Version | Target Framework Moniker (TFM) | Support |
| -------- | :----: | :----------: | :---------------: |
| .NET Standard | 2.0 | `netstandard2.0` | Supported |
| .NET Standard | 1.6 | `netstandard1.6` | Not Supported |
| .NET Core Application | 2.0 | `netcoreapp2.0` | Supported |
| .NET Core Application | 1.0 | `netcoreapp1.0` | Not Supported |

## Getting Started
The Bocons Tag Helper Library is published as a package in [NuGet](https://www.nuget.org/packages/BSolutions.Bocons). Only three essential steps are necessary for installation.

Find the full [Getting Started Guide](https://www.brecons.net/Documentation/Bocons/GettingStarted) here.

### Install NuGet Packages

Use the ***Package Manage Console*** of Visual Studio to install Bocons:

    PM> Install-Package BSolutions.Bocons

### Add Service Configuration

Register inside the `ConfigureServices` method of `Startup.cs` a singleton for the `IActionContextAccessor` and import the namespace `Microsoft.AspNetCore.Mvc.Infrastructure`.

    using Microsoft.AspNetCore.Mvc.Infrastructure

    public void ConfigureServices(IServiceCollection services)
    {
	    // Add a singleton for IActionContextAccessor
        services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

        services.AddMvc();
    }

### Modify View Imports

Modify `/Views/_ViewImports.cshtml` and enable the Bocons Tag Helpers for the web application views:

    @using MyCompany.MyApplication
    @using MyCompany.MyApplication.Models
    @using BSolutions.Bocons.Enumerations
    @using BSolutions.Brecons.Core.Enumerations
    @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
    @addTagHelper *, BSolutions.Bocons

## Documentation
For complete a Bocons documentation, please visit [https://www.brecons.net/Documentation/Bocons](https://www.brecons.net/Documentation/Bocons)

## Release Notes
For change logs and release notes, see the [online change logs at brecons.net](https://www.brecons.net/Documentation/Bocons/ChangeLog)

## License Information
This project has been released under the [Apache License Version 2.0](https://www.apache.org/licenses/LICENSE-2.0). This license applies
ONLY to the source of this repository and does not extend to any other Brecons distribution or variant.

> Copyright 2016 - 2017 Bremus Solutions

> Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at

> [http://www.apache.org/licenses/LICENSE-2.0](http://www.apache.org/licenses/LICENSE-2.0)

> Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.