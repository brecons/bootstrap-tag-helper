# Jumbotron

A lightweight, flexible component for showcasing hero unit style content. Use the Bocons Tag Helper for [Bootstrap Jumbotron](https://getbootstrap.com/docs/4.0/components/jumbotron/) and extend the entire viewport to showcase key marketing messages on your site.

![Jumbotron](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/jumbotron_01.PNG)

    <jumbotron>
        <h1 class="display-3">Hello, world!</h1>
        <p class="lead">
            This is a simple hero unit, a simple jumbotron-style component
            for calling extra attention to featured content or information.
        </p>
        <hr class="my-4">
        <p>
            It uses utility classes for typography and spacing to space content
            out within the larger container.
        </p>
        <p class="lead">
            <a bc-button="true" bc-size="Large" href="#">Learn more</a>
        </p>
    </jumbotron>

## Jumbotron Configuration `<jumbotron>`

### Fluid

To make the jumbotron full width, and without rounded corners, use the `bc-fluid` attribute.

![Jumbotron](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/jumbotron_02.PNG)

    <jumbotron bc-fluid="true"> ... </jumbotron>