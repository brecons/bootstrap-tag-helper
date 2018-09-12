# List Group

The [Bootstrap List Group](https://getbootstrap.com/docs/4.0/components/list-group/) is a flexible and powerful component for displaying a series of content. Modify and extend them to support just about any content within. And the best: fully supported by a Bocons Tag Helper.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/list-group_01.PNG" width="535" alt="Bocons List Group">

```markup
<list-group>
    <list-group-item>List Group Item 1</list-group-item>
    <list-group-item>List Group Item 2</list-group-item>
    <list-group-item>List Group Item 3</list-group-item>
    <list-group-item>List Group Item 4</list-group-item>
</list-group>
```

## Components

Components are tag helpers that are available within a `<list-group>`.

### List Group Item `<list-group-item>`

A `<list-group-item>` tag helper renders a simple text-based list group item.

### List Group Link `<list-group-link>`

With a `<list-group-link>` tag helper it is possible to render links as list group items. For example build compact list menus with these tag helper.

### List Group Button `<list-group-button>`

Use the `<list-group-button>` tag helper to create actionable list group items with hover, disabled, and active states.

## Item Configuration `<list-group-item>`

### Color

For proper styling of an list group item use the `bc-color` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/list-group_02.PNG" width="533" alt="List Group Item Color">

```markup
<list-group>
    <list-group-item bc-color="Primary">List Group Item 1</list-group-item>
    <list-group-item bc-color="Secondary">List Group Item 2</list-group-item>
    <list-group-item bc-color="Success">List Group Item 3</list-group-item>
    <list-group-item bc-color="Danger">List Group Item 4</list-group-item>
    <list-group-item bc-color="Warning">List Group Item 4</list-group-item>
    <list-group-item bc-color="Info">List Group Item 4</list-group-item>
    <list-group-item bc-color="Light">List Group Item 4</list-group-item>
    <list-group-item bc-color="Dark">List Group Item 4</list-group-item>
</list-group>
```

### Badge

Add badges to any list group item with the `bc-badge` attribute. You can also set a color for the badge with the `bc-badge-color` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/list-group_03.PNG" width="534" alt="List Group Item Badge">

```markup
<list-group>
    <list-group-item bc-badge="23">List Group Item 1</list-group-item>
    <list-group-item bc-badge="43" bc-badge-color="Primary">List Group Item 2</list-group-item>
</list-group>
```

## Link Configuration `<list-group-link>`

### Color

For proper styling of an list group link use the `bc-color` attribute.

### Badge

Add badges to any list group link with the `bc-badge` attribute. You can also set a color for the badge with the `bc-badge-color` attribute.

### Disable

Add the `bc-disable` attribute to make the group link appear disabled.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/list-group_04.PNG" width="410" alt="Disabled List Group Link">

```markup
<list-group>
    <list-group-item bc-disable="true">Cras justo odio</li>
    <list-group-item>Dapibus ac facilisis in</li>
    ...
</list-group>
```

### Active

Add the `bc-active` attribute to indicate the current active group link.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/list-group_05.PNG" width="415" alt="Active List Group Link">

```markup
<list-group>
    <list-group-item bc-active="true">Cras justo odio</li>
    <list-group-item>Dapibus ac facilisis in</li>
    ...
</list-group>
```

## Button Configuration `<list-group-button>`

The configuration of the `<list-group-button>` tag helper is similar to `<list-group-link>` tag helper. All Bocons attributes and the tag helper structure are the same. The only difference is that the `<list-group-button>` renders as a HTML `<button>`.