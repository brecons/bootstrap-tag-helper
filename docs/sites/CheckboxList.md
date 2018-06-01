# Checkbox List

The `<checkbox-list>` tag helper is a wrapper for checkbox input elements. For a correct rendering it is necessary to embedding all checkboxes into a checkbox list.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/checkboxlist_01.PNG" width="197" alt="Bocons Checkbox List">

```markup
<checkbox-list bc-label="Default Checkboxes">
    <input type="checkbox" bc-label="Default" />
    <input type="checkbox" bc-label="Disabled" disabled />
    <input type="checkbox" bc-label="Checked" checked />
</checkbox-list>
```

## Configuration

### Inline

Checkboxes can rendered on the same horizontal row by adding the `bc-inline` attribute to the list wrapper.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/checkboxlist_02.PNG" width="274" alt="Inline Checkboxes">

```markup
<checkbox-list bc-inline="true">
    ...
</checkbox-list>
```

### Label

To set an label for the list of checkboxes use the `bc-label` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/checkboxlist_03.PNG" width="113" alt="Label for Checkbox List">

```markup
<checkbox-list bc-label="Skills">
    ...
</checkbox-list>
```