# Controls

The [Bootstrap Controls](https://getbootstrap.com/docs/4.0/components/forms/#form-controls) are a collection of default HTML form controls with appealing styles. Bocons Tag Helpers extends these beautiful controls and handles them in an easy and simple way.

<ul class="categorized-view">
    <li>
        <h5>HTML Controls</h5>
        <a asp-action="Controls" asp-route-control="text">Text</a>
        <a asp-action="Controls" asp-route-control="textarea">Textarea</a>
        <a asp-action="Controls" asp-route-control="checkbox">Checkbox List</a>
        <a asp-action="Controls" asp-route-control="radio">Radio List</a>
        <a asp-action="Controls" asp-route-control="select">Dropdown (Select)</a>
        <a asp-action="Controls" asp-route-control="static">Static</a>
        <a asp-action="Controls" asp-route-control="info">Label &amp; Help</a>
    </li>
    <li>
        <h5>Buttons</h5>
        <a asp-action="Controls" asp-route-control="button">Button</a>
        <a asp-action="Controls" asp-route-control="buttongroup">Button Group</a>
        <a asp-action="Controls" asp-route-control="dbutton">Dropdown Button</a>
    </li>
    <li>
        <h5>Editors</h5>
        <a asp-action="Controls" asp-route-control="summernote">Summernote</a>
        <a asp-action="Controls" asp-route-control="markdown">Markdown</a>
    </li>

    <li>
        <h5>Date &amp; Time</h5>
        <a asp-action="Controls" asp-route-control="datepicker">Datepicker</a>
    </li>
    <li>
        <h5>Miscellaneous</h5>
        <a asp-action="Controls" asp-route-control="dropzone">Dropzone</a>
        <a asp-action="Controls" asp-route-control="nouislider">noUiSlider</a>
    </li>
</ul>

## General Configuration

The following configuration attributes are available for all form controls respectively their tag helpers.

### Label

Define a label for form controls by adding the `bc-label` attribute or use the `<label>` tag helper within the `<form-group>`.

![Label for Controls](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/controls_06.PNG)

    <!-- Label via form control attribute -->
    <form-group>
        <input type="text" bc-label="E-mail address" />
    </form-group>

    <!-- Label via label tag helper -->
    <form-group>
        <label>E-mail address</label>
        <input type="text" />
    </form-group>

### Help

A block-level help text for form controls can be created by using the `bc-help` attribute or use the `<help>` tag helper within the `<form-group>`.

![Help for Controls](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/controls_07.PNG)

    <!-- Block-level help via form control attribute -->
    <form-group>
        <input type="text" bc-label="E-mail address" bc-help="Enter your correct e-mail address." />
    </form-group>

    <!-- Block-level help via help tag helper -->
    <form-group>
        <input type="text" bc-label="E-mail address" />
        <help>Enter your correct e-mail address.</help>
    </form-group>

### Size

Set the height of a form control by adding the `bc-size` attribute. Available sizes are `Default`, `Large` or `Small`.

![Control Sizing](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/controls_08.PNG)

    <form-group>
        <input type="password" placeholder="Enter password" bc-size="Large" />
    </form-group>
    <form-group>
        <input type="password" placeholder="Enter password" />
    </form-group>
    <form-group>
        <input type="password" placeholder="Enter password" bc-size="Small" />
    </form-group>

### Required

Mark a control as required with the `bc-required` attribute. This adds the HTML `required` attribute to the control markup und mark the control label as required with a star (*).

![Control Sizing](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/controls_09.PNG)

    <form-group>
        <input bc-label="E-mail address" bc-required="true" type="text" />
    </form-group>

### Validation

If a property is bound to the control (via `asp-for` attribute) and the `bc-validation` attribute is set to `true`, a validation message element will be displayed on invalid state. These element can be used from the validation mechanism of ASP.NET MVC.

***Please note:*** It is also possible to activate the validation messages for each form control by an form level attribute. For more info check the [Validation](https://www.brecons.net/Documentation/Bocons/Validation) page.