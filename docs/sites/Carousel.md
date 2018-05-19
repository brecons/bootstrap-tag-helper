# Carousel

A slideshow component for cycling through elements—images or slides of text — like a carousel. Use the [Bootstrap Carousel](https://getbootstrap.com/docs/4.0/components/carousel/) with Bocons and it's Tag Helper.

![Carousel](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/carousel_01.PNG)

```markup
<carousel>
    <carousel-item bc-src="~/images/banner1.svg" bc-alt="Slide 1" bc-active="true"></carousel-item>
    <carousel-item bc-src="~/images/banner2.svg" bc-alt="Slide 2"></carousel-item>
    <carousel-item bc-src="~/images/banner3.svg" bc-alt="Slide 3"></carousel-item>
</carousel>
```

## Carousel Configuration `<carousel>`

### Controls

Add a previous and next control with `bc-controls` attribute.

![Carousel Controls](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/carousel_02.PNG)

```markup
<carousel bc-controls="true"> ... </carousel>
```

### Indicators

You can also add the indicators to the carousel by setting the `bc-indicators` attribute.

![Carousel Indicators](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/carousel_03.PNG)

```markup
<carousel bc-controls="true" bc-indicators="true"> ... </carousel>
```

### Crossfade

Add the `bc-fade` attribute to your carousel to animate slides with a fade transition instead of a slide.

```markup
<carousel bc-controls="true" bc-fade="true"> ... </carousel>
```

## Item Configuration `<carousel-item>`

### Source (Mandatory)

The `bc-src` attribute specifies the URL of the image file to display inside the carousel item.

### Active

With the `bc-active` attribute it is possible to define a start item after carousel load.

### Alternate Text

The `bc-alt` attribute specifies an alternate text for the carousel image, if the image cannot be displayed.

### Captions

Add captions to your slides easily by adding HTML markup within the `<carousel-item>`.

![Carousel Item Captions](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/carousel_04.PNG)

```markup
<carousel bc-controls="true" bc-indicators="true">
    <carousel-item bc-src="~/images/banner1.svg" bc-alt="Slide 1" bc-active="true">
        <h3>First Slide Label</h3>
        <p>
            Nulla vitae elit libero, a pharetra augue mollis interdum.
        </p>
    </carousel-item>
    <carousel-item bc-src="~/images/banner2.svg" bc-alt="Slide 2">
        <h3>Second Slide Label</h3>
        <p>
            Nulla vitae elit libero, a pharetra augue mollis interdum.
        </p>
    </carousel-item>
    <carousel-item bc-src="~/images/banner3.svg" bc-alt="Slide 3">
        <h3>Third Slide Label</h3>
        <p>
            Nulla vitae elit libero, a pharetra augue mollis interdum.
        </p>
    </carousel-item>
</carousel>
```