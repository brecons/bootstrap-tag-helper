# Image

Opting [Bootstrap Images](https://getbootstrap.com/docs/4.0/layout/grid/) into responsive behavior (so they never become larger than their parent elements) and add lightweight styles to them—all via Bocons Tag Helper attributes.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/images_01.PNG" width="786" alt="Bocons Image">

```markup
<img src="~/images/bootstrap-solid.svg" bc-responsive="true" />
```

## Image Configuration `<img />`

### Thumbnail

In addition to Bootstrap's [border-radius](https://getbootstrap.com/docs/4.0/utilities/borders/) utilities, you can use `bc-thumbnail` attribute to give an image a rounded 1px border appearance.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/images_02.PNG" width="213" alt="Thumbnailed Image">

```markup
<img src="~/images/bootstrap-solid.svg" bc-thumbnail="true" />
```

### Round

Round off the corners of an image by using the `bc-round` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/images_03.PNG" width="212" alt="Rounded Image">

```markup
<img src="~/images/bootstrap-solid.svg" bc-round="true" />
```

### Circle

Set the `bc-circle` attribute to render an image in a circle.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/images_04.PNG" width="220" alt="Circled Image">

```markup
<img src="~/images/bootstrap-solid.svg" bc-circle="true" />
```

### Responsive

Responsive images are scales with the parent element and will become larger. Set a images responsive with the `bc-responsive` attribute.