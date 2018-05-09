# Image

Opting [Bootstrap Images](https://getbootstrap.com/docs/4.0/layout/grid/) into responsive behavior (so they never become larger than their parent elements) and add lightweight styles to them—all via Bocons Tag Helper attributes.

![Image](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/images_01.PNG)

    <img src="~/images/bootstrap-solid.svg" bc-responsive="true" />

## Image Configuration `<img />`

### Thumbnail

In addition to Bootstrap's [border-radius](https://getbootstrap.com/docs/4.0/utilities/borders/) utilities, you can use `bc-thumbnail` attribute to give an image a rounded 1px border appearance.

![Thumbnailed Image](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/images_02.PNG)

    <img src="~/images/bootstrap-solid.svg" bc-thumbnail="true" />

### Round

Round off the corners of an image by using the `bc-round` attribute.

![Rounded Image](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/images_03.PNG)

    <img src="~/images/bootstrap-solid.svg" bc-round="true" />

### Circle

Set the `bc-circle` attribute to render an image in a circle.

![Circled Image](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/images_04.PNG)

    <img src="~/images/bootstrap-solid.svg" bc-circle="true" />

### Responsive

Responsive images are scales with the parent element and will become larger. Set a images responsive with the `bc-responsive` attribute.