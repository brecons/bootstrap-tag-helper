# Table

Opt-in and styling of [Bootstrap Tables](https://getbootstrap.com/docs/4.0/content/tables/) with the easy-to-use Bocons Tag Helpers.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/tables_01.PNG" width="737" alt="Bocons Table">

```markup
<table>
    <thead>
        <tr>
            <th>#</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Username</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope="row">1</th>
            <td>Mark</td>
            <td>Otto</td>
            <td>@mdo</td>
        </tr>
        <tr>
            <th scope="row">2</th>
            <td>Jacob</td>
            <td>Thornton</td>
            <td>@fat</td>
        </tr>
        <tr>
            <th scope="row">3</th>
            <td>Larry</td>
            <td>the Bird</td>
            <td>@twitter</td>
        </tr>
    </tbody>
</table>
```

## Table Configuration `<table>`

### Theme

To change the theme of a table - with white, light or dark background - use the `bc-theme` attribute. Possible themes are `Default` (default), `Light` and `Dark`.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/tables_02.PNG" width="737" alt="Table Theme">

```markup
<table bc-theme="Dark"> ... </table>
```

### Striped

Use the `bc-striped` attribute to add zebra-striping to any table row.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/tables_03.PNG" width="736" alt="Striped Table">

```markup
<table bc-striped="true"> ... </table>
```

### Small

Add the `bc-small` attribute to make tables more compact by cutting cell padding in half.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/tables_04.PNG" width="737" alt="Small Table">

```markup
<table bc-small="true"> ... </table>
```

### Border

Add the `bc-border` attribute to specify the borders on all sides of the table and cells. Possible border styles are `Regular`(default) for only horizontal borders, `Bordered` for horizontal and vertical borders and `Borderless` for no borders.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/tables_05.PNG" width="1113" alt="Borders for Table">

```markup
<table>
    ...
</table>
<table bc-border="Bordered">
    ...
</table>
<table bc-border="Borderless">
    ...
</table>
```

### Responsive

Create responsive tables by setting the `bc-responsive` attribute to make them scroll horizontally on small devices. Possible values are `XSmall`, `Small`, `Medium`, `Large` or `XLarge`. The definition of the respective breakpoint determines when no scroll bar is displayed for the table.

```markup
<table bc-responsive="Breakpoint.Medium"> ... </table>
```

***Please note:*** Since the attribute can also have no value, the Enumeration must always be specified in its definition.

### Hover

Add the `bc-hover` attribute to enable a hover state on table rows.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/tables_10.PNG" width="749" alt="Hoverable Table">

```markup
<table bc-hover="true"> ... </table>
```

## Table Head Configuration `<thead>`

### Theme

Similar to themed tables, use the `bc-theme` attribute to make `<thead>` appear `Default` (default), `Dark` or `Light`.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/tables_06.PNG" width="739" alt="Table Head Theme">

```markup
<table>
    <thead bc-theme="Dark"> ... </thead>
    <tbody> ... </tbody>
</table>

<table>
    <thead bc-theme="Light"> ... </thead>
    <tbody> ... </tbody>
</table>
```

## Row Configuration `<tr>`

### Background

Use the `bc-background` attribute to color table rows.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/tables_07.PNG" width="535" alt="Table Row Background">

```markup
<table>
    <thead> ... </thead>
    <tbody>
        <tr bc-background="Primary"> ... </tr>
        <tr bc-background="Secondary"> ... </tr>
        <tr bc-background="Success"> ... </tr>
        <tr bc-background="Danger"> ... </tr>
        <tr bc-background="Warning"> ... </tr>
        <tr bc-background="Info"> ... </tr>
        <tr bc-background="Light"> ... </tr>
        <tr bc-background="Dark"> ... </tr>
    </tbody>
</table>
```

## Cell Configuration `<th>` `<td>`

### Background

Use the `bc-background` attribute to color table cells.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/tables_08.PNG" width="541" alt="Table Cell Background">

```markup
<table>
    <thead> ... </thead>
    <tbody>
        <tr>
            <th bc-background="Info" scope="row">Info</th>
            <td bc-background="Primary">Primary</td>
            <td bc-background="Secondary">Secondary</td>
            <td bc-background="Success">Success</td>
        </tr>
        <tr>
            <th bc-background="Info" scope="row">Info</th>
            <td bc-background="Danger">Danger</td>
            <td bc-background="Warning">Warning</td>
            <td bc-background="Info">Info</td>
        </tr>
        <tr>
            <th bc-background="Info" scope="row">Info</th>
            <td bc-background="Light">Light</td>
            <td bc-background="Dark">Dark</td>
            <td bc-background="White">White</td>
        </tr>
    </tbody>
</table>
```