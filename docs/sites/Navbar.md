# Navbar

The [Bootstrap Navbar](https://getbootstrap.com/docs/4.0/components/navbar/) is a powerful, responsive navigation header. Includes support for branding, navigation, and more, including support for our collapse plugin. Try the Bocons Tag Helper for this powerful component.

![Navbar](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/navbar_01.PNG)

    <navbar bc-brand-text="Navbar">
        <navbar-nav>
            <navbar-link href="/">Home</navbar-link>
            <navbar-link href="/" bc-active="true">Support</navbar-link>
            <navbar-link href="/">Profile</navbar-link>
        </navbar-nav>
        <navbar-form class="mx-4">
            <input class="form-control mr-sm-2" type="text" placeholder="Search" aria-label="Search" />
            <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
        </navbar-form>
    </navbar>

## Components

Components are tag helpers that are available within a `<navbar>`.

### Navigation `<navbar-nav>`

The `<navbar-nav>` tag helper is a container for navigation items and can contain `<navbar-link>` or `<navbar-dropdown>` elements.

### Link `<navbar-link>`

The `<navbar-link>` tag helper represents a link within the navigation. These tag helper can only be included into a `<navbar-nav>`.

### Dropdown `<navbar-dropdown>`

The `<navbar-dropdown>` tag helper is a container for a `<navbar-link>` collection. These tag helper can only be included into a `<navbar-nav>`.

### Form `<navbar-form>`

A form can included into a navbar with the `<navbar-form>` tag helper. Within these element all common HTML form controls can be used.

### Text `<navbar-text>`

The `<navbar-text>` tag helper allows you to insert plain text into the navigation.

## Navbar Configuration `<navbar>`

### Brand Text

A brand text can be added to the navbar with the `bc-brand-text` attribute. These text is displayed at the left side of the navbar.

![Navbar with Brand Text](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/navbar_02.PNG)

    <navbar bc-brand-text="Navbar">
        ...
    </navbar>

### Brand Link

If you have defined a brand text or image, it is also possible to provide it with a link. The link will be set via the `bc-brand-href` attribute.

    <navbar bc-brand-text="Navbar" bc-brand-href="/">
        ...
    </navbar>

***Please note:*** The `bc-brand-href` attribute is only valid in combination with the `bc-brand-text` or `bc-brand-image` attribute.

### Brand Image

Beside a text it is possible to render an image in the brand section of the navbar. This is possible with the `bc-brand-image` attribute. If you define at once a brand text, both elements will be displayed.

![Navbar with Brand Image](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/navbar_03.PNG)

    <navbar bc-brand-image="~/images/bootstrap.svg" bc-brand-text="Navbar" bc-brand-href="/">
        ...
    </navbar>

***Please note:*** If an brand image and a brand text are defined at once, the brand text will be also used for the brand image HTML alt attribute.

### Brand Link

If you have defined a brand text or image, it is also possible to provide it with a link. The link will be set via the `bc-brand-href` attribute.

    <navbar bc-brand-text="Navbar" bc-brand-href="/">
        ...
    </navbar>

***Please note:*** The `bc-brand-href` attribute is only valid in combination with the `bc-brand-text` or `bc-brand-image` attribute.

### Theme

Theming the navbar is possible via the `bc-theme` attribute. Possible themes are `Light` (default) and `Dark`.

![Navbar Theme](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/navbar_04.PNG)

    <navbar bc-brand-text="Navbar" bc-theme="Dark">
        ...
    </navbar>

***Please note:*** If the choosen theme is `Dark` and no background is defined, the tag helper automatically set the background color to `Dark`.

### Background

In combination with a navbar theme you can set a background color with `bc-background` attribute.

![Navbar Theme](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/navbar_05.PNG)

    <navbar bc-brand-text="Navbar" bc-theme="Dark" bc-background="Primary">
        ...
    </navbar>

## Link Configuration `<navbar-link>`

### Active

Set the `bc-active` attribute to indicate the current page and highlight an item.

### Disable

Use the `bc-disable` attribute to deactivate an item.

![Disabled Navbar Link](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/navbar_06.PNG)

    <navbar bc-brand-text="Navbar">
        <navbar-nav>
            <navbar-link href="/">Home</navbar-link>
            <navbar-link href="/">Features</navbar-link>
            <navbar-link href="/">Pricing</navbar-link>
            <navbar-link href="/" bc-disable="true">Disabled</navbar-link>
        </navbar-nav>
    </navbar>

## Dropdown Configuration `<navbar-dropdown>`

### Title (Mandatory)

Set a label for the dropdown menu item with the `bc-title` attribute.

![Navbar Dropdown with Title](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/navbar_07.PNG)

    <navbar bc-brand-text="Navbar">
        <navbar-nav>
            ...
        <navbar-dropdown bc-title="Dropdown link">
            <navbar-link href="/">Action</navbar-link>
            <navbar-link href="/">Another action</navbar-link>
            <navbar-link href="/">Something else here</navbar-link>
        </navbar-dropdown>
    </navbar>