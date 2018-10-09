# Change Logs & Releases

In this page, you can find a record of all the changes made to Bocons such as bug fixes, new features, etc.

## Version 2.4.0 <small class="release-date">Oct. 09, 2018</small>

This release of Bocons supports Bootstrap 4.1.3 and comes with many extensions, bugfixes and a new documentation published on GitHub.

<ul class="changelog">
    <li class="ch-added">Input: Support for Bootstrap Buttons with <code><input type="button" /></code> Tag Helper.</li>
    <li class="ch-added">Add support for Target Framework <code>netstandard1.6</code>.</li>
    <li class="ch-changed">Table: The attribute <code>bc-bordered</code> has been replaced by the <code>bc-border</code> attribute.</li>
</ul>

<a href="https://www.nuget.org/packages/BSolutions.Bocons/2.4.0" class="btn btn-info">
    <i class="fa fa-link"></i> Source and Download
</a>

## Version 2.3.0 <small class="release-date">Jun. 01, 2018</small>

This release of Bocons supports Bootstrap 4.1.1 and comes with many extensions, bugfixes and a new documentation published on GitHub.

<ul class="changelog">
    <li class="ch-added">New Tag Helper for Range Input Control.</li>
    <li class="ch-added">Tables - Support for responsive table breakpoints with new <code>bc-responsive</code> attribute.</li>
    <li class="ch-added">Tables - Add borderless variant for tables with new <code>bc-borderless</code> attribute.</li>
    <li class="ch-added">Dropdown Button - Add support for plain text content in Dropdown Button with new <code>&lt;text&gt;</code> Tag Helper.</li>
    <li class="ch-added">Dropdown Button - Add support for dropdown variation (directions) with new <code>bc-variation</code> attribute.</li>
    <li class="ch-added">Carousel - Add crossfade support with new <code>bc-fade</code> attribute.</li>
    <li class="ch-changed">New documentation published on GitHub.</li>
</ul>

<a href="https://www.nuget.org/packages/BSolutions.Bocons/2.3.0" class="btn btn-info">
    <i class="fa fa-link"></i> Source and Download
</a>

## Version 2.2.0 <small class="release-date">Feb. 23, 2018</small>

The release of Bocons v2.2.0 provides full support for the first stable version of Bootstrap v4.0.0.

<ul class="changelog">
    <li class="ch-changed">Full support for first stable Bootstrap v4.0.0</li>
</ul>

<a href="https://www.nuget.org/packages/BSolutions.Bocons/2.2.0" class="btn btn-info">
    <i class="fa fa-link"></i> Source and Download
</a>

## Version 2.1.1 <small class="release-date">Jan. 16, 2018</small>

Update to Bocons v2.1.1 with some bugfixes and full support for Bootstrap v4.0.0 Beta 3. The most important new features are the offset support for Grid System Columns and the centered position option for modal dialogs.

<ul class="changelog">
    <li class="ch-changed">Full support for Bootstrap v4.0.0 Beta 3.</li>
    <li class="ch-changed">Tables - The <code>bc-inverse</code> is no longer available. It has been replaced with the <code>bc-theme</code> attribute.</li>
    <li class="ch-added">Grid System - New attributes <code>offset-{breakpoint}</code> to set column offsets.</li>
    <li class="ch-added">Modal - A new attribute <code>bc-position</code> is available for modal dialog positioning.</li>
    <li class="ch-fixed">Forms - The input group size was not rendered correctly.</li>
</ul>

<a href="https://www.nuget.org/packages/BSolutions.Bocons/2.1.1" class="btn btn-info">
    <i class="fa fa-link"></i> Source and Download
</a>

## Version 2.1.0 <small class="release-date">Oct. 05, 2017</small>

Update to Bocons v2.1.0 with many bugfixes and several attribute changes for a small kind of tag helpers. Furthermore we follow a new NuGet Strategy and Open Source Philosophy. This version is still compatible with Bootstrap v4.0.0.

<ul class="changelog">
    <li class="ch-changed">All Tag Helpers - The <code>bc-style</code> attribute of all tag helpers is renamed to <code>bc-color</code>.</li>
    <li class="ch-changed">Modal - The <code>bc-header</code> attribute of an modal tag helper is renamed to <code>bc-title</code>.</li>
</ul>

<a href="https://www.nuget.org/packages/BSolutions.Bocons/2.1.0" class="btn btn-info">
    <i class="fa fa-link"></i> Source and Download
</a>

## Version 2.0.1 <small class="release-date">Sep. 26, 2017</small>

Update to Bocons v2.0.1 with many bugfixes and several attribute changes for a small kind of tag helpers. This version is still compatible with Bootstrap v4.0.0.

<ul class="changelog">
    <li class="ch-changed">Dropdown Button - The <code>bc-disabled</code> attribute of an menu item is renamed to <code>bc-disable</code>.</li>
    <li class="ch-changed">Button - The <code>bc-disabled</code> attribute is renamed to <code>bc-disable</code>.</li>
    <li class="ch-changed">Navbar - The <code>bc-disabled</code> attribute is renamed to <code>bc-disable</code>.</li>
    <li class="ch-changed">Pagination - The <code>bc-disabled</code> attribute of an <code>&lt;pagination-item&gt;</code> is renamed to <code>bc-disable</code>.</li>
    <li class="ch-updated">Controls - If the <code>bc-required</code> attribute is set for a form control, the label gets marked with a star (*) and the HTML required attribute will added to the form control markup.</li>
    <li class="ch-fixed">Tables - Cells <code>&lt;td&gt;</code> with a contextual background <code>bc-background</code> get the wrong css class.</li>
    <li class="ch-fixed">Tables - Rows <code>&lt;tr&gt;</code> with a contextual background <code>bc-background</code> get the wrong css class.</li>
    <li class="ch-fixed">Images - Images with set <code>bc-circle</code> attribute get the wrong css class.</li>
    <li class="ch-fixed">Navbar - Links <code>&lt;navbar-link&gt;</code> with an <code>bc-active</code> attribute were not rendered.</li>
    <li class="ch-fixed">Navbar - The brand container were even rendered if no <code>bc-brand-text</code> or <code>bc-brand-image</code> is specified.</li>
</ul>

<a href="https://www.nuget.org/packages/BSolutions.Bocons/2.0.1" class="btn btn-info">
    <i class="fa fa-link"></i> Source and Download
</a>

## Version 2.0.0 <small class="release-date">Sep. 14, 2017</small>

Initial version of Bocons for Bootstrap v4.0.0.

<ul class="changelog">
    <li class="ch-added">New Tag Helper for Grid System</li>
    <li class="ch-added">New Tag Helper for Media Object</li>
    <li class="ch-added">New Tag Helper for Images</li>
    <li class="ch-added">New Tag Helper for Tables</li>
    <li class="ch-added">New Tag Helper for Figures</li>
    <li class="ch-added">New Tag Helper for Alerts</li>
    <li class="ch-added">New Tag Helper for Badge</li>
    <li class="ch-added">New Tag Helper for Breadcrumb</li>
    <li class="ch-added">New Tag Helper for Buttons</li>
    <li class="ch-added">New Tag Helper for Button Group</li>
    <li class="ch-added">New Tag Helper for Card</li>
    <li class="ch-added">New Tag Helper for Carousel</li>
    <li class="ch-added">New Tag Helper for Dropdowns</li>
    <li class="ch-added">New Tag Helper for Forms</li>
    <li class="ch-added">New Tag Helper for Input Group</li>
    <li class="ch-added">New Tag Helper for Jumbotron</li>
    <li class="ch-added">New Tag Helper for List Group</li>
    <li class="ch-added">New Tag Helper for Modal</li>
    <li class="ch-added">New Tag Helper for Navs</li>
    <li class="ch-added">New Tag Helper for Pagination</li>
    <li class="ch-added">New Tag Helper for Popovers</li>
    <li class="ch-added">New Tag Helper for Progress</li>
    <li class="ch-added">New Tag Helper for Tooltips</li>
</ul>

<a href="https://www.nuget.org/packages/BSolutions.Bocons/2.0.0" class="btn btn-info">
    <i class="fa fa-link"></i> Source and Download
</a>