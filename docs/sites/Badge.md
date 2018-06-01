# Badge

The [Bootstrap Badges](https://getbootstrap.com/docs/4.0/components/badge/) are small count and labeling components and fully supported by a Bocons Tag Helper.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/badge_01.PNG" width="423" alt="Bocons Badge">

```markup
<h1>Example Heading <badge>New</badge></h1>
```

## Badge Configuration <badge>

### Color

For proper styling of a badge use the `bc-color` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/badge_02.PNG" width="426" alt="Colored Badge">

```markup
<badge bc-color="Primary">Primary</badge>
<badge bc-color="Secondary">Secondary</badge>
<badge bc-color="Success">Success</badge>
<badge bc-color="Danger">Danger</badge>
<badge bc-color="Warning">Warning</badge>
<badge bc-color="Info">Info</badge>
<badge bc-color="Light">Light</badge>
<badge bc-color="Dark">Dark</badge>
```

### Pills

Use the `bc-pill` attribute to make badges more rounded.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/badge_03.PNG" width="470" alt="Pills">

```markup
<badge bc-pill="true" bc-color="Primary">Primary</badge>
<badge bc-pill="true" bc-color="Secondary">Secondary</badge>
<badge bc-pill="true" bc-color="Success">Success</badge>
<badge bc-pill="true" bc-color="Danger">Danger</badge>
<badge bc-pill="true" bc-color="Warning">Warning</badge>
<badge bc-pill="true" bc-color="Info">Info</badge>
<badge bc-pill="true" bc-color="Light">Light</badge>
<badge bc-pill="true" bc-color="Dark">Dark</badge>
```