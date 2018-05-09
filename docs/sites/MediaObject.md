# Media Object

Use the [Bootstrap Media Object](https://getbootstrap.com/docs/4.0/layout/media-object/) to construct highly repetitive components like blog comments, tweets, and the like.

The Bocons Tag Helper supports all features of the Bootstrap Media Object in a easy and intuitive way.

![Media Object](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/media-object_01.PNG)

    <media>
        <media-image src="~/images/bootstrap-solid.svg" height="64" class="mr-3" />
        <media-body bc-header="Media heading">
            Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque
            ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus
            viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla.
            Donec lacinia congue felis in faucibus.
        </media-body>
    </media>

## Nesting

Media objects can be infinitely nested, though we suggest you stop at some point. Place nested `<media>` within the `<media-body>` of a parent media object.

![Nested Media Objects](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/media-object_02.PNG)

    <media>
        <media-image src="~/images/bootstrap-solid.svg" class="mr-3" />
        <media-body bc-header="Media heading">
            ...

            <media class="mt-4">
                <media-image src="~/images/bootstrap-solid.svg" class="mr-3" />
                <media-body bc-header="Media heading">
                    ...
                </media-body>
            </media>
        </media-body>
    </media>