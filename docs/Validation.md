# Validation

Provide valuable, actionable feedback with [Bootstrap Validation](https://getbootstrap.com/docs/4.0/components/forms/#validation) to your users with HTML5 form validation. Use the Bocons Tag Helper in combination with the default ASP.NET Core Validation mechanism to validate your forms easy and simple.

## Requirements

To enable the client-side validation in ASP.NET MVC Core in combination with Bocons, you have to load the following packages from [Bower](https://bower.io/):

*   `bootstrap`
*   `jquery`
*   `jquery-validation`
*   `jquery-validation-unobtrusive`
*   `jquery-validation-unobtrusive-bootstrap`

The easiest way to load these packages is to modify the `bower.json`. This file can be found in your project root path.

```json
{
    "dependencies": {
        "bootstrap": "v4.0.0-beta",
        "jquery": "3.2.1",
        "jquery-validation": "1.17.0",
        "jquery-validation-unobtrusive": "3.2.6",
        "jquery-validation-unobtrusive-bootstrap": "2.0.0"
    }
}
```

After embedding the packages into your solution, add a reference to each file within the `/Shared/_Layout.cshtml` page:

```markup
<script src="~/lib/jquery/dist/jquery.slim.min.js"></script>
<script src="~/lib/jquery-validation/dist/jquery.validate.js"></script>
<script src="~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"></script>
<script src="~/lib/jquery-validation-unobtrusive-bootstrap/dist/unobtrusive-bootstrap.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.11.0/umd/popper.min.js"></script>
<script src="~/lib/bootstrap/dist/js/bootstrap.min.js"></script>
```

## Data Binding Validation

All Bocons form controls supports the default [ASP.NET Core Validation](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/validation). It's possible to validate the form on client-side with [jQuery Validation](https://jqueryvalidation.org/) or after a postback on server-side.

For a **client-side** validation use data annotations in your view model and bind the properties to the form controls within your view. Bocons now renders the validation errors automatically in Bootstrap compatible styles.

A **server-side** validation will execute in the controller logic after a postback. Use the `ModelState` to check if the form data is valid or to add further validation errors.

***Please note:*** It is indispensable to check the [Form Configuration](https://www.brecons.net/Documentation/Bocons/Validation#form-configuration) attributes before using Bocons Validation.

### View Model

```csharp
public class RegisterViewModel
{
    [Display(Name = "Name")]
    [LocalizedRequired]
    public string Name { get; set; }

    [Display(Name = "Email Address")]
    [LocalizedRequired]
    [LocalizedEmailAddress]
    public string Email { get; set; }
	
    [Display(Name = "Country")]
    public int Country { get; set; }
	
    public List<SelectListItem> Countries { get; set; } = new List<SelectListItem>();
}
```

### Controller

```csharp
public IActionResult Register()
{
    return View(new RegisterViewModel());
}

[HttpPost]
public IActionResult Register(RegisterViewModel model)
{
    // Server-side validation
    if (model.Country == 0) ModelState.AddModelError("Country", "Please choose a country.");
    
    // On validation errors go back to view
    if (!ModelState.IsValid) return View(model);
	
    return RedirectToAction("Success");
}
```

### View

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/validation_01.PNG" width="1278" alt="View with Validation">

```markup
@model MyCompany.MyApplication.Models.RegisterViewModel
    
<form asp-action="Register" bc-validation="true">
    <form-group>
        <input type="text" asp-for="Name" />
    </form-group>
    <form-group>
        <input type="email" asp-for="Email" />
    </form-group>
    <form-group>
        <select asp-for="Country" asp-items="Model.Countries"></select>
    </form-group>
    <button type="submit">Submit</button>
</form>
```

## Form Configuration `<form>`

### Validation

If the `bc-validation` attribute is set to `true`, for each control within the form a validation message will rendered. With this setting it is not longer necessary to set the `bc-validation` attribute on each form control individually.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/validation_02.PNG" width="515" alt="Input Field with Validation">

```markup
<form asp-action="Register" bc-validation="true">
    ...
</form>
```

***Please note:*** When the `bc-validation` attribute is set to `true` for a form, it is not longer necessary to place a `<span asp-validation-for="{Property}"></span>` container below the form control. Bocons do that automatically for you.