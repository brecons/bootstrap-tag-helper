# Form Layout

With [Bootstrap Form Layout](https://getbootstrap.com/docs/4.0/components/forms/#layout) it is possible to layout a form in different ways. Bocons Tag Helpers enables you to layout your forms for example in a horizontal or vertical layout.

## Vertical Form

In a vertical form each control and its corresponding label and help text will placed in a separate row.

![Vertical Form Layout](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/form-layout_01.PNG)

    <form>
        <form-group>
            <input type="text" bc-label="User name" bc-help="Usually your e-mail address." />
        </form-group>
        <form-group>
            <input type="password" bc-label="Password" />
        </form-group>
        <button type="submit">Log in</button>
    </form>

## Horizontal Form

In a horizontal form each control and its corresponding label placed in the same row. The help text will placed under the control.

![Horizontal Form Layout](https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/form-layout_02.PNG)

    <form bc-horizontal="true" bc-label-width-xl="4">
        <form-group>
            <input type="text" bc-label="User name" bc-help="Usually your e-mail address." />
        </form-group>
        <form-group>
            <input type="password" bc-label="Password" />
        </form-group>
        <button type="submit">Log in</button>
    </form>

## Form Configuration `<form>`

### Horizontal

Set the `bc-horizontal` attribute to `true` if you want a horizontal form layout.

***Please note:*** If you choose a horizontal form layout it is necessary to define at least one label width for your favorite [Responsive Breakpoint](https://getbootstrap.com/docs/4.0/layout/overview/#responsive-breakpoints). For further informations check the following chapter "Label Width".

### Label Width (Mandatory on Horizontal Layout)

Set at least one label width if you render your form horizontal. It's possible to set a label width for each [Responsive Breakpoint](https://getbootstrap.com/docs/4.0/layout/overview/#responsive-breakpoints). Choose the `bc-label-width-{breakpoint}` attribute to set a label width for a breakpoint. If you define only a label width for a large breakpoint (e.g. `bc-label-width-lg` or `bc-label-width-xl`), the labels get a full width on smaller breakpoints and the conclusion is a vertical form.

### Label Display

To hide control labels on all devices execept screen readers, set the `bc-labels-sr-only` to `true`.