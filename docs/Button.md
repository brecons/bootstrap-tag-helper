# Button

The [Bootstrap Buttons](https://getbootstrap.com/docs/4.0/components/buttons/) are elements for actions in forms, dialogs and more. With the Bocons Tag Helper it is very easy to use these Buttons and adjust them to your needs.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/button_01.PNG" width="641" alt="Bocons Button">

```markup
<button type="button" bc-color="Primary">Primary</button>
<button type="button" bc-color="Secondary">Secondary</button>
<button type="button" bc-color="Success">Success</button>
<button type="button" bc-color="Danger">Danger</button>
<button type="button" bc-color="Warning">Warning</button>
<button type="button" bc-color="Info">Info</button>
<button type="button" bc-color="Light">Light</button>
<button type="button" bc-color="Dark">Dark</button>
```

## Button Configuration `<button>`

### Color

Use the `bc-color` attribute to modify the styling of the button. Possible styles are `Primary` (default), `Secondary`, `Success`, `Danger`, `Warning`, `Info`, `Light` or `Dark`.

### Outline

In need of a button, but not the hefty background colors they bring? Set the `bc-outline` attribute to `true` to remove all background images and color on any button.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/button_02.PNG" width="650" alt="Outline Button">

```markup
<button type="button" bc-color="Primary" bc-outline="true">Primary</button>
<button type="button" bc-color="Secondary" bc-outline="true">Secondary</button>
<button type="button" bc-color="Success" bc-outline="true">Success</button>
<button type="button" bc-color="Danger" bc-outline="true">Danger</button>
<button type="button" bc-color="Warning" bc-outline="true">Warning</button>
<button type="button" bc-color="Info" bc-outline="true">Info</button>
<button type="button" bc-color="Light" bc-outline="true">Light</button>
<button type="button" bc-color="Dark" bc-outline="true">Dark</button>
```

### Size

Add the `bc-size` attribute to define a size for the button. Possible sizes are `Default`, `Large` or `Small`.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/button_03.PNG" width="404" alt="Button Sizing">

```markup
<button type="button" bc-size="Large">Large button</button>
<button type="button">Normal button</button>
<button type="button" bc-size="Small">Small button</button>
```

### Block

Create block level buttons - those that span the full width of a parent - by adding the `bc-block` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/button_04.PNG" width="739" alt="Block Button">

```markup
<button type="button" bc-block="true" bc-color="Primary">Block level button</button>
<button type="button" bc-block="true" bc-color="Secondary">Block level button</button>
```

### Active

Buttons will appear pressed (with a darker background, darker border, and inset shadow) when the `bc-active` attribute is set to `true`.

### Disable

Make buttons look inactive by adding the `bc-disable` attribute and set it to `true`.

## Link Configuration `<a>`

### Button <span class="badge info">Trigger Attribute</span>

You can also use the button attributes with `<a>` tags and render a link like a button. To do that it is important to set the trigger attribute `bc-button` for a link.

```markup
<a bc-button="true" bc-color="Primary">Primary</a>
```