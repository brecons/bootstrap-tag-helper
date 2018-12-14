# Breadcrumb

The [Bootstrap Breadcrumb](https://getbootstrap.com/docs/4.0/components/breadcrumb/) indicate the current page's location within a navigational hierarchy that automatically adds separators via CSS. Easy-to-use with our Bocons Tag Helper for this beneficial component.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/breadcrumb_01.PNG" width="738" alt="Bocons Breadcrumb">

```markup
<breadcrumb>
	<breadcrumb-item bc-href="#">Home</breadcrumb-item>
	<breadcrumb-item bc-href="#">Library</breadcrumb-item>
	<breadcrumb-item bc-active="true">Data</breadcrumb-item>
</breadcrumb>
```

## Item Configuration `<breadcrumb-item>`

### Href

To set a breadcrumb item reference use the `bc-href` attribute.

### Active

To set an breadcrumb item into an active state use the `bc-active` attribute.