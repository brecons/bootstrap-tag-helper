# Change Logs & Releases

In this page, you can find a record of all the changes made to Bocons such as bug fixes, new features, etc.

## Version 2.2.0 (Feb. 23, 2018)

The release of Bocons v2.2.0 provides full support for the first stable version of Bootstrap v4.0.0.

*   (changed) Full support for first stable Bootstrap v4.0.0

[Source and Download](https://www.nuget.org/packages/BSolutions.Bocons/2.2.0)

## Version 2.1.1 (Jan. 16, 2018)

Update to Bocons v2.1.1 with some bugfixes and full support for Bootstrap v4.0.0 Beta 3. The most important new features are the offset support for Grid System Columns and the centered position option for modal dialogs.

*   (changed) Full support for Bootstrap v4.0.0 Beta 3.
*   (changed) Tables - The `bc-inverse` is no longer available. It has been replaced with the `bc-theme` attribute.
*   (added) Grid System - New attributes `offset-{breakpoint}` to set column offsets.
*   (added) Modal - A new attribute `bc-position` is available for modal dialog positioning.
*   (fixed) Forms - The input group size was not rendered correctly.

[Source and Download](https://www.nuget.org/packages/BSolutions.Bocons/2.1.1)

## Version 2.1.0 (Oct. 05, 2017)

Update to Bocons v2.1.0 with many bugfixes and several attribute changes for a small kind of tag helpers. Furthermore we follow a new NuGet Strategy and Open Source Philosophy. This version is still compatible with Bootstrap v4.0.0.

*   (changed) All Tag Helpers - The `bc-style` attribute of all tag helpers is renamed to `bc-color`.
*   (changed) Modal - The `bc-header` attribute of an modal tag helper is renamed to `bc-title`.

[Source and Download](https://www.nuget.org/packages/BSolutions.Bocons/2.1.0)

## Version 2.0.1 (Sep. 26, 2017)

Update to Bocons v2.0.1 with many bugfixes and several attribute changes for a small kind of tag helpers. This version is still compatible with Bootstrap v4.0.0.

*   (changed) Dropdown Button - The bc-disabled attribute of an menu item is renamed to bc-disable.
*   (changed) Button - The bc-disabled attribute is renamed to bc-disable.
*   (changed) Navbar - The bc-disabled attribute is renamed to bc-disable.
*   (changed) Pagination - The bc-disabled attribute of an <pagination-item> is renamed to bc-disable.
*   (updated) Controls - If the bc-required attribute is set for a form control, the label gets marked with a star (*) and the HTML required attribute will added to the form control markup.
*   (fixed) Tables - Cells <td> with a contextual background bc-background get the wrong css class.
*   (fixed) Tables - Rows <tr> with a contextual background bc-background get the wrong css class.
*   (fixed) Images - Images with set bc-circle attribute get the wrong css class.
*   (fixed) Navbar - Links <navbar-link> with an bc-active attribute were not rendered.
*   (fixed) Navbar - The brand container were even rendered if no bc-brand-text or bc-brand-image is specified.

[Source and Download](https://www.nuget.org/packages/BSolutions.Bocons/2.0.1)

## Version 2.0.0 (Sep. 14, 2017)

Initial version of Bocons for Bootstrap v4.0.0.

*   (added) New Tag Helper for Grid System
*   (added) New Tag Helper for Media Object
*   (added) New Tag Helper for Images
*   (added) New Tag Helper for Tables
*   (added) New Tag Helper for Figures
*   (added) New Tag Helper for Alerts
*   (added) New Tag Helper for Badge
*   (added) New Tag Helper for Breadcrumb
*   (added) New Tag Helper for Buttons
*   (added) New Tag Helper for Button Group
*   (added) New Tag Helper for Card
*   (added) New Tag Helper for Carousel
*   (added) New Tag Helper for Dropdowns
*   (added) New Tag Helper for Forms
*   (added) New Tag Helper for Input Group
*   (added) New Tag Helper for Jumbotron
*   (added) New Tag Helper for List Group
*   (added) New Tag Helper for Modal
*   (added) New Tag Helper for Navs
*   (added) New Tag Helper for Pagination
*   (added) New Tag Helper for Popovers
*   (added) New Tag Helper for Progress
*   (added) New Tag Helper for Tooltips

[Source and Download](https://www.nuget.org/packages/BSolutions.Bocons/2.0.0)