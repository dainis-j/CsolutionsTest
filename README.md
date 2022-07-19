# CsolutionsTest
## About
This repository contains a web app and API projects that use an SQLite database stored in the repository's root folder.

All necessary migrations have already been applied to the database, but if you are having issues, you may run `Update-Database` through Visual Studio's Package Manager Console. In that case, make sure your startup project is `CsolutionsTest` and the default project in Package Manager Console is `CsolutionsTest.Data`.

The projects use .NET 6, make sure you have the necessary tools to run them (VS2022 recommended).

## Web app

### How to launch
Run the `CsolutionsTest` project either from the Visual Studio solution or `dotnet run`.

## Web API

### How to launch
Run the `CsolutionsTest.Api` project either from the Visual Studio solution or `dotnet run`.

### Endpoints
The API only has one endpoint, `/audit`. It is opened automatically if you run the project through Visual Studio, and should display the JSON content in your browser.

You may provide date filters `from` and `to` to this endpoint, such as:
```
/audit?from=2022-07-19T16:24:02.4982912&to=2022-07-19T16:24:02.4982912
```
Make sure the dates are in valid format.