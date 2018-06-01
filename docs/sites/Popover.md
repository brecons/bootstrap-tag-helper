# Popover

A [Bootstrap Popover](https://getbootstrap.com/docs/4.0/components/popovers/) is a component to show additional informations for an element like those found in iOS. With the Bocons Tag Helper it is possible to add those informations to any element on your app.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/popover_01.PNG" width="302" alt="Bocons Popover">

```markup
<button type="button" bc-popover="Vivamus sagittis lacus vel augue laoreet rutrum faucibus." bc-popover-title="Popover on top" bc-popover-placement="Top">
    Button with Popover
</button>
```

## Popover Configuration

### Content (Mandatory) (Trigger Attribute)

The `bc-popover` attribute is available on each HTML element and specifies the popover content. After these attribute is set for an element further attributes are available to concretize the popover definition.

```markup
<button type="button" bc-popover="Text and content">Button with Popover</button>
```

### Title

You can set a title for the popover with the `bc-popover-title` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/popover_02.PNG" width="302" alt="Popover Title">

```markup
<button type="button" bc-popover="Vivamus sagittis lacus vel augue laoreet rutrum faucibus." bc-popover-title="Popover on top">
    Button with Popover
</button>
```

### Dismissible

Use the `bc-popover-dismissible` attribute and set a focus trigger to dismiss popovers on the next click that user makes.

### Delay

Define a delay for showing and hiding the popover with `bc-popover-delay` attribute. The value of these attribute are milliseconds.

```markup
<button type="button" bc-popover="Text and content" bc-popover-delay="1000">Button with Popover</button>
```

### Placement

With the `bc-popover-placement` can specified how to position a popover. Possible values are `Top` (default), `Bottom`, `Left` or `Right`.