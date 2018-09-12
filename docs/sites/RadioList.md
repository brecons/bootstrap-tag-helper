# Radio List

The `<radio-list>` tag helper is a wrapper for radio input elements. For a correct rendering it is necessary to embedding all radios into a radio list.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/radiolist_01.PNG" width="193" alt="Bocons Radio List">

```markup
<radio-list bc-label="Default Radiobuttons">
    <input type="radio" name="radio1" bc-label="Default" />
    <input type="radio" name="radio1" bc-label="Disabled" disabled />
    <input type="radio" name="radio1" bc-label="Checked" checked />
</radio-list>
```

## Configuration

### Inline

Radios can rendered on the same horizontal row by adding the `bc-inline` attribute to the list wrapper.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/radiolist_02.PNG" width="163" alt="Inline Radio List">

```markup
<radio-list bc-inline="true">
    ...
</radio-list>
```

### Label

To set an label for the list of radios use the `bc-label` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/radiolist_03.PNG" width="193" alt="Label for Radio List">

```markup
<radio-list bc-label="Default Radiobuttons">
    <input type="radio" name="radio1" bc-label="Default" />
    <input type="radio" name="radio1" bc-label="Disabled" disabled />
    <input type="radio" name="radio1" bc-label="Checked" checked />
</radio-list>
```