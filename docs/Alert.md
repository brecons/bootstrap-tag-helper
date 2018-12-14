# Alert

Provide contextual feedback messages for typical user actions with a handful of available and flexible [Bootstrap Alert](https://getbootstrap.com/docs/4.0/components/alerts/) messages. The Bocons Tag Helper fully supports the Bootstrap Alert component.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/alert_01.PNG" width="737" alt="Bocons Alert">

```markup
<alert>
    This is a primary alert—check it out!
</alert>
```

## Alert Configuration `<alert>`

### Color

For proper styling of an alert use the `bc-color` attribute.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/alert_02.PNG" width="737" alt="Alert Colors">

```markup
<alert bc-color="Primary">
    This is a primary alert—check it out!
</alert>
<alert bc-color="Secondary">
    This is a secondary alert—check it out!
</alert>
<alert bc-color="Success">
    This is a success alert—check it out!
</alert>
<alert bc-color="Danger">
    This is a danger alert—check it out!
</alert>
<alert bc-color="Warning">
    This is a warning alert—check it out!
</alert>
<alert bc-color="Info">
    This is a info alert—check it out!
</alert>
<alert bc-color="Light">
    This is a light alert—check it out!
</alert>
<alert bc-color="Dark">
    This is a dark alert—check it out!
</alert>
```

### Dismissible

Use the `bc-dismissible` attribute to dismiss any alert inline.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/alert_03.PNG" width="738" alt="Dismissible Alert">

```markup
<alert bc-color="Warning" bc-dismissible="true">
    You should check in on some of those fields below.
</alert>
```

### Title

Use the `bc-title` attribute to add a title for the alert in addition to the content.

<img class="img-shadow img-responsive center-block" src="https://raw.githubusercontent.com/brecons/bootstrap-tag-helper/master/docs/images/alert_04.PNG" width="736" alt="Alert with Title">

```markup
<alert bc-color="Info" bc-title="Holy guacamole!">
    You should check in on some of those fields below.
</alert>
```