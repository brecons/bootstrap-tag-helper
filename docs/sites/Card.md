# Card

[Bootstrap Cards](https://getbootstrap.com/docs/4.0/components/card/) provide a flexible and extensible content container with multiple variants and options. All great advantages of this new component concentrated in a Bocons Tag Helper.

![Card](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/card_01.PNG)

```markup
<card>
    <card-image src="~/images/card.svg" bc-position="Top" />
    <card-body bc-title="Card title">
        <p>
            Some quick example text to build on the card
            title and make up the bulk of the card's content.
        </p>
        <a href="#" bc-button="true">Go somewhere</a>
    </card-body>
</card>
```

## Components

Components are tag helpers that are available within a `<card>`.

### Header `<card-header>`

A card header can optinally added with a `<card-header>` tag helper within an `<card>` element.

### Image `<card-image>`

The `<card-image>` tag helper places an image within an `<card>` to the top or bottom of the card.

### Body `<card-body>`

The `<card-body>` tag helper is the core of an `<card>` element and within you can define the content of the card. These tag helper is mandatory for a correct card rendering.

### Footer `<card-footer>`

A card footer can optinally added with a `<card-footer>` tag helper within an `<card>` element.

## Layouts

Cards can be arranged in different layout. The following section describes which layouts are available for cards.

### Group `<card-group>`

Use the `<card-group>` tag helper to render cards as a single, attached element with equal width and height columns.

![Card Groups](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/card_02.PNG)

```markup
<card-group>
    <card> ... </card>
    <card> ... </card>
    <card> ... </card>
</card-group>
```

### Deck `<card-deck>`

Use the `<card-deck>` tag helper to render cards as a single, not attached element with equal width and height columns.

![Card Deck](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/card_03.PNG)

```markup
<card-deck>
    <card> ... </card>
    <card> ... </card>
    <card> ... </card>
</card-deck>
```

### Column `<card-column>`

Cards can be organized into [Masonry](http://masonry.desandro.com/)-like columns with just CSS by wrapping them in `<card-column>` tag helper.

![Card Column](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/card_04.PNG)

```markup
<card-column>
    <card> ... </card>
    <card> ... </card>
    ...
</card-column>
```

## Card Configuration `<card>`

### Alignment

You can quickly change the text alignment of any card with the `bc-alignment` attribute.

![Card Alignment](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/card_05.PNG)

```markup
<card> ... </card>
<card bc-alignment="Center"> ... </card>
<card bc-alignment="Right"> ... </card>
```

### Color

Use the `bc-color` attribute to change the appearance of a card.

![Card Color](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/card_06.PNG)

```markup
<card bc-color="Success"> ... </card>
```

### Border

Use `bc-border` attribute to change just the border of a card.

***Please note:*** You can put a text color with `bc-color` attribute on `<card-body>` element for a unity look.

![Card Border](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/card_07.PNG)

## Image Configuration `<card-image>`

### Position (Mandatory)

The `bc-position` attribute is mandatory for each `<card-image>` tag helper and defines the position of the image within the card. Choose the value `Top` when the image is in the top of the card or choose `Bottom` for bottom image placement.

```markup
<card>
    <card-image src="~/images/card1.svg" bc-position="Top" />
    <card-body> ... </card-body>
</card>

<card>
    <card-body> ... </card-body>
    <card-image src="~/images/card1.svg" bc-position="Bottom" />
</card>
```

## Body Configuration `<card-body>`

### Title

To fit up a card with a eye-catching title use the `bc-title` attribute.

### Subtitle

With the `bc-subtitle` attribute is is possible to describe the card further.

![Card Body Subtitle](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/card_08.PNG)

```markup
<card>
    <card-body bc-title="Card Title" bc-subtitle="Card Sub Title">
        <p>
            Card body and content.
        </p>
    </card-body>
</card>
```

### Color

With the `bc-color` attribute it is possible to set the text color for the whole card body.

![Card Body Subtitle](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/card_09.PNG)

```markup
<card>
    <card-body bc-title="Card Title" bc-subtitle="Card Sub Title" bc-color="Danger">
        <p>
            Card body and content.
        </p>
    </card-body>
</card>
```