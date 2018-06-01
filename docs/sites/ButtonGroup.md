# Button Group

The [Bootstrap Button Group](https://getbootstrap.com/docs/4.0/components/button-group/) groups a series of buttons together on a single line. The Bocons Tag Helper helps you to wrap a series of buttons and quickly leads you to results.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/button-group_01.PNG" width="196" alt="Bocons Button Group">

```markup
<button-group>
    <button>Left</button>
    <button>Middle</button>
    <button>Right</button>
</button-group>
```

## Button Group Configuration `<button-group>`

### Vertical

Make a set of buttons appear vertically stacked rather than horizontally by adding the `bc-vertical` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/button-group_02.PNG" width="85" alt="Vertical Button Group">

```markup
<button-group bc-vertical="true">
    <button>Top</button>
    <button>Middle</button>
    <button>Bottom</button>
</button-group>
```

### Size

Define a size of the button group with the `bc-size` attribute. Available sizes are `Default`, `Large` or `Small`.