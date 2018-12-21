# Disable Brecons

By default, each tag helper of Brecons where applied to an HTML element. To prevent the Brecons tag helper rendering, use the `disable-brecons` attribute.

## Attribute

To disable the Brecons tag helper rendering for an HTML element, set the `disable-brecons` attribute to these element. The `disable-brecons` attribute is minimizable and needs no value.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/disable-brecons_01.png" width="173" alt="Comparison between a Mecons button and a regular button">

```markup
<!-- Brecons Rendering -->
<button type="button">Brecons Button</button>

<!-- Default HTML Rendering -->
<button type="button" disable-brecons>HTML Button</button>
```