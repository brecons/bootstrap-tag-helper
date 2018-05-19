# Radio List

The `<radio-list>` tag helper is a wrapper for radio input elements. For a correct rendering it is necessary to embedding all radios into a radio list.

![Radio List](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/radiolist_01.PNG)

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

![Inline Radios](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/radiolist_02.PNG)

```markup
<radio-list bc-inline="true">
    ...
</radio-list>
```

### Label

To set an label for the list of radios use the `bc-label` attribute.

![Label for Radio List](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/radiolist_03.PNG)

```markup
<radio-list bc-label="Default Radiobuttons">
    <input type="radio" name="radio1" bc-label="Default" />
    <input type="radio" name="radio1" bc-label="Disabled" disabled />
    <input type="radio" name="radio1" bc-label="Checked" checked />
</radio-list>
```