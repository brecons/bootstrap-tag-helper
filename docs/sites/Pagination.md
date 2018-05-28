# Pagination

Indicate a series of related content across multiple pages with the [Bootstrap Pagination](https://getbootstrap.com/docs/4.0/components/pagination/) component. Build a Pagination component easy and fast with the Bocons Tag Helper.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/pagination_01.PNG" width="188" alt="Bootstrap Pagination">

```markup
<pagination>
    <pagination-item href="#">1</pagination-item>
    <pagination-item href="#">2</pagination-item>
    <pagination-item href="#">3</pagination-item>
</pagination>
```

## Pagination Configuration `<pagination>`

### Size

Define the size of the pagination with the `bc-size` attribute. Possible sizes are `Large`, `Default` and `Small`.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/pagination_02.PNG" width="320" alt="Pagination Sizing">

```markup
<pagination bc-size="Large"> ... </pagination>
<pagination> ... </pagination>
<pagination bc-size="Small"> ... </pagination>
```

### Previous Button

The previous button is the first item of a pagination and provide special options.

By default the previous button content is an icon (`«`). It is possible to modify the content with the `bc-previous-text` attribute.

Also it is possible to set a link reference to these button with the `bc-previous-href` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/pagination_03.PNG" width="414" alt="Pagination Previous Button">

```markup
<pagination bc-previous-text="Previous" bc-previous-href="javascript: app.previous();">
    ...
</pagination>
```

### Next Button

The next button is the last item of a pagination and provide special options.

By default the next button content is an icon (`»`). It is possible to modify the content with the `bc-next-text` attribute.

Also it is possible to set a link reference to these button with the `bc-next-href` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/pagination_04.PNG" width="414" alt="Pagination Next Button">

```markup
<pagination bc-next-text="Next" bc-next-href="javascript: app.next();">
    ...
</pagination>
```

### Alignment

Change the alignment of pagination with the `bc-alignment` attribute. Possible alignments are `Left` (default), `Center` and `Right`.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/pagination_05.PNG" width="682" alt="Pagination Alignment">

```markup
<pagination> ... </pagination>
<pagination bc-alignment="Center"> ... </pagination>
<pagination bc-alignment="Right"> ... </pagination>
```

### Title

If a page have more than one pagination, it's advisable to provide a descriptive title for the pagination to reflect its purpose. These title can be set via `bc-title` attribute and will rendered as a `aria-label`.

## Item Configuration `<pagination-item>`

### Active

Set the `bc-active` attribute to indicate the current page and highlight an item.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/pagination_06.PNG" width="315" alt="Active Pagination Item">

```markup
<pagination>
    <pagination-item href="#">1</pagination-item>
    <pagination-item href="#" bc-active="true">2</pagination-item>
    <pagination-item href="#">3</pagination-item>
</pagination>
```

### Disable

Use the `bc-disable` attribute to deactivate an item.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/pagination_07.PNG" width="309" alt="Disabled Pagination Item">

```markup
<pagination>
    <pagination-item href="#">1</pagination-item>
    <pagination-item href="#" bc-disable="true">2</pagination-item>
    <pagination-item href="#">3</pagination-item>
</pagination>
```