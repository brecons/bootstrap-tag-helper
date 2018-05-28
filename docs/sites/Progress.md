# Progress

The [Bootstrap Progress](https://getbootstrap.com/docs/4.0/components/progress/) is a information bar to show a progress. Use the Bocons Tag Helper to build those components with all known features.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/progress_01.PNG" width="742" alt="Bootstrap Progress">

```markup
<progress bc-value="75" />
```

## Progress Configuration `<progress />`

### Value

Use the `bc-value` attribute to set a value for the progress.

### Label

Add a label to your progress bar and set the `bc-label` attribute to `true`.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/progress_02.PNG" width="742" alt="Progress Label">

```markup
<progress bc-value="25" bc-label="true" />
```

### Height

It's possible to adapt the height of a progress bar with the `bc-height` attribute. Allowed values for this attribute are integers. The unit for this value are pixels (px). The default height of a progress bar is `16`.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/progress_03.PNG" width="742" alt="Progress Height">

```markup
<progress bc-value="25" bc-height="1" />
<progress bc-value="25" bc-height="20" />
```

### Color

Use the `bc-color` attribute to set a color for the progress bar.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/progress_04.PNG" width="747" alt="Progress Color">

```markup
<progress bc-value="25" bc-color="Success" />
<progress bc-value="50" bc-color="Info" />
<progress bc-value="75" bc-color="Warning" />
<progress bc-value="100" bc-color="Danger" />
```

### Striped

Add the `bc-striped` attribute and set it to `true` to apply a stripe gradient over the progress bar's background color.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/progress_05.PNG" width="741" alt="Progress Stripes">

```markup
<progress bc-value="25" bc-color="Success" bc-striped="true"  />
<progress bc-value="50" bc-color="Info" bc-striped="true" />
<progress bc-value="75" bc-color="Warning" bc-striped="true"  />
<progress bc-value="100" bc-color="Danger" bc-striped="true"  />
```

### Animated

The striped gradient can also be animated by setting the `bc-animated` attribute.