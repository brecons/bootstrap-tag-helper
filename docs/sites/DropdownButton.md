# Dropdown Button

The [Bootstrap Dropdown Buttons](https://getbootstrap.com/docs/4.0/components/dropdowns/) are contextual overlays for displaying lists of links and more. These complex controls can easy handled with Bocons Tag Helper.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/dropdown_01.PNG" width="769" alt="Bocons Dropdown Button">

```markup
<button-dropdown bc-title="Primary">
    <a href="#">Action</a>
    <a href="#" bc-disabled="true">Disabled Action</a>
    <a href="#">Another Action</a>
</button-dropdown>
<button-dropdown bc-title="Secondary" bc-color="Secondary">
    ...
</button-dropdown>
<button-dropdown bc-title="Success" bc-color="Success">
    ...
</button-dropdown>
<button-dropdown bc-title="Danger" bc-color="Danger">
    ...
</button-dropdown>
<button-dropdown bc-title="Warning" bc-color="Warning">
    ...
</button-dropdown>
<button-dropdown bc-title="Info" bc-color="Info">
    ...
</button-dropdown>
<button-dropdown bc-title="Light" bc-color="Light">
    ...
</button-dropdown>
<button-dropdown bc-title="Dark" bc-color="Dark">
    ...
</button-dropdown>
```

## Components

Components are tag helpers that are available within a `<button-dropdown>`.

### Menu Item `<a>`

The `<a>` tag represents an item within the dropdown menu. These regular HTML link tag is extended by a Bocons tag helper which provides further attributes.

### Divider `<divider />`

The `<divider>` tag helper helps you to seperate groups of related menu items.

### Header `<header>`

With the `<header>` tag helper it is possible to add a header to label sections of actions in any dropdown menu.

## Dropdown Button Configuration `<button-dropdown>`

### Title (Mandatory)

The `bc-title` attribute specifies a title for the button that triggers the dropdown menu.

### Variation

Trigger dropdown menus at the `Left`, `Right`, `Top`or `Bottom` (default) of the element by adding the `bc-variation` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/dropdown_02.PNG" width="714" alt="Dropdown Button Variation">

```markup
<button-dropdown bc-title="Button Dropdown"> ... </button-dropdown>
<button-dropdown bc-title="Button Dropup" bc-variation="Top"> ... </button-dropdown>
<button-dropdown bc-title="Button Dropleft" bc-variation="Left"> ... </button-dropdown>
<button-dropdown bc-title="Button Dropright" bc-variation="Right"> ... </button-dropdown>
```

### Color

Use the `bc-color` attribute to modify the styling of the dropdown button. Possible styles are `Primary` (default), `Secondary`, `Success`, `Danger`, `Warning`, `Info`, `Light` or `Dark`.

### Menu Alignment

By default, a dropdown menu is automatically positioned 100% from the top and along the left side of its button. Add the `bc-alignment-right` attribute to right align the dropdown menu.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/dropdown_03.PNG" width="290" alt="Dropdown Button Menu Alignment">

```markup
<button-dropdown bc-title="Dropdown Button with long Title" bc-alignment-right="true">
    ...
</button-dropdown>
```

### Size

Add the `bc-size` attribute to define a size for the dropdown button. Possible sizes are `Default`, `Large` or `Small`.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/dropdown_04.PNG" width="534" alt="Dropdown Button Sizing">

```markup
<button-dropdown bc-title="Large Dropdown" bc-size="Large">
    ...
</button-dropdown>

<button-dropdown bc-title="Normal Dropdown">
    ...
</button-dropdown>

<button-dropdown bc-title="Small Dropdown" bc-size="Small">
    ...
</button-dropdown>
```

### Split

The `bc-split` attribute seperates the dropdown menu trigger from the rest of the button. This make it possible to allocate an seperate action to the button.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/dropdown_05.PNG" width="332" alt="Splitted Dropdown Button">

```markup
<button-dropdown bc-title="Dropdown Button" bc-color="Dark" bc-split="true">
    ...
</button-dropdown>
```

## Menu Item Configuration `<a>`

### Disable

Add the `bc-disable` attribute to disable an menu item in the dropdown.