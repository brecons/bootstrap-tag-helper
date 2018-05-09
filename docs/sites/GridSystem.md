# Grid System

Use the powerful mobile-first flexbox [Bootstrap Grid System](https://getbootstrap.com/docs/4.0/layout/grid/) to build layouts of all shapes and sizes thanks to a twelve column system, five default responsive tiers, Sass variables and mixins, and dozens of predefined classes.

Bootstrap’s grid system uses a series of containers, rows, and columns to layout and align content. It’s built with flexbox and is fully responsive. All Bootstrap Grid System features are covered from the Bocons Tag Helper!

## Introduction

The following example shows the basic usage of the Bocons Grid System and represents a first starting point.

![Grid System](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/grid-system_01.PNG)

	<container>
		<row>
			<column>1 of 2</column>
			<column>2 of 2</column>
		</row>
		<row>
			<column>1 of 3</column>
			<column>2 of 3</column>
			<column>3 of 3</column>
		</row>
	</container>

## Container Configuration `<container>`

### Fluid

Use the `bc-fluid` attribute for a full width container, spanning the entire width of the viewport.

	<container bc-fluid="true">
		...
	</container>