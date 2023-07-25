# Radzen Blazor Test Project
The aim of this project is to demonstrate a bug or indesidarated behavior in the RadzenDataGridHeaderCell component.

This bug happens after use the functionality of save and load user settings and applying default filter parameters.

In this particular case, we want the datagrid load the default settings if no user settings are set. After user has set personal settings, these settings
should be used. If user wants to clear the settings no default settings should be applied .

# Steps to reproduce the bug (DateTime filter)
* Start the webapp for the first time (or clean your local storage to restart the behavior). You should see a data grid filtered by date with only one record.
* Try to change the filter dates. Records get filtered normally.
* Reload the window, your last filters are applied correctly.
* Clear the filter in the date time column.
* BUG: Try to set a new date in the date time filter -> the UI is not responding.

# Versions
The Radzen.Blazor used in this project is 4.14.2


