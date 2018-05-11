# Checkbox List

The `<checkbox-list>` tag helper is a wrapper for checkbox input elements. For a correct rendering it is necessary to embedding all checkboxes into a checkbox list.

![Checkbox List](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/checkboxlist_01.PNG)

    <checkbox-list bc-label="Default Checkboxes">
        <input type="checkbox" bc-label="Default" />
        <input type="checkbox" bc-label="Disabled" disabled />
        <input type="checkbox" bc-label="Checked" checked />
    </checkbox-list>

## Configuration

### Inline

Checkboxes can rendered on the same horizontal row by adding the `bc-inline` attribute to the list wrapper.

![Inline Checkboxes](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/checkboxlist_02.PNG)

    <checkbox-list bc-inline="true">
        ...
    </checkbox-list>

### Label

To set an label for the list of checkboxes use the `bc-label` attribute.

![Label for Checkbox List](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/checkboxlist_03.PNG)

    <checkbox-list bc-label="Skills">
        ...
    </checkbox-list>