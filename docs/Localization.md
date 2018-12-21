# Localization

The Bocons Tag Helper supports multiple languages and are localized. This applies on the one hand to all texts and labels generated within a Tag Helper, but also to date and time outputs.

## Support

Currently the following languages are supported:

<table class="table table-bordered table-striped">
    <thead>
        <tr>
            <th>Language</th>
            <th>State</th>
            <th>Available since</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>English</td>
            <td><span class="label label-success">Supported</span></td>
            <td><span class="label label-info">Version 2.1.0</span></td>
        </tr>
        <tr>
            <td>German</td>
            <td><span class="label label-success">Supported</span></td>
            <td><span class="label label-info">Version 2.1.0</span></td>
        </tr>
    </tbody>
</table>

## Usage of Localization

To localize the Tag Helpers, Bocons uses the `CultureInfo` set in the <a href="https://docs.microsoft.com/de-de/dotnet/api/system.globalization.cultureinfo.currentculture?view=netcore-2.1">current thread</a>.

Use the following code snippet to modify the `CultureInfo` for the current thread:

```csharp
// Set current thread language to German
Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
```

<div class="alert alert-info" role="alert">
    <strong>Please note:</strong>
    For a complete list of all <code>CultureInfo</code> names, visit https://msdn.microsoft.com/en-us/library/hh441729.aspx.
</div>

The `CultureInfo` for your ASP.NET Core web application is best set in the `Startup.cs` within the `Configure` method:

```csharp
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    ...

    // Language
    var cultureInfo = new CultureInfo("de-DE");
    CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
    CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
}
```

<div class="alert alert-info" role="alert">
    <strong>Default Language:</strong>
    If Bocons can not find a suitable language file for the thread culture, the English language file will be used.
</div>