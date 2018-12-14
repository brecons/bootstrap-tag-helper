# Figure

Displaying related images and text is very easy with [Bootstrap Figures](https://getbootstrap.com/docs/4.0/content/figures/). Even easier it will be with the Bocons Tag Helper which support all settings of Bootstrap Figures in a easy way.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/figures_01.PNG" width="420" alt="Bocons Figure">

```markup
<figure bc-image="~/images/figure.svg" bc-caption="A caption for the above image." />
```

## Figure Configuration `<figure />`

### Image <span class="badge info">Mandatory</span>

A image souce for the figure element can defined with the `bc-image` attribute.

### Caption <span class="badge info">Mandatory</span>

To set a caption for the displayed image use the `bc-caption` attribute.

### Alignment

Aligning the figure's capion is easy with the `bc-alignment` attribute. It is possible to align the caption on `Left` (default), `Center` and `Right`.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/figures_02.PNG" width="414" alt="Figure Caption Alignment">

```markup
<figure bc-image="~/images/figure.svg" bc-caption="A caption for the above image." bc-alignment="Right" />
```