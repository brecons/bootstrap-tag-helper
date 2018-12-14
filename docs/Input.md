# Text Input

The text input will be specified with a `<input type="[text, password, email, number]" />` tag and provides a single-line text input field.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/input_01.PNG" width="330" alt="Bocons Input">

```markup
<input type="text" bc-label="Text Control" />
```

## Configuration

### Addons

Place an add-on on either side of an text input with the `bc-pre-addon` or `bc-post-addon` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/input_02.PNG" width="340" alt="Input Addons">

```markup
<form-group>
    <input type="text" bc-label="Email address" bc-pre-addon="@" />
</form-group>
<form-group>
    <input type="text" bc-label="Website" bc-post-addon=".com" />
</form-group>
<form-group>
    <input type="text" bc-label="Budget" bc-pre-addon="$" bc-post-addon=".00" />
</form-group>
```

### Static

If you want to have an readonly element in your form styled as plain text, use the `bc-static` attribute. These attribute remove the default form field styling and preserve the correct margin and padding.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/input_03.PNG" width="205" alt="Static Input">

```markup
<form-group>
    <input type="text" bc-label="Username: " value="timm.bremus" bc-static="true" />
</form-group>
```