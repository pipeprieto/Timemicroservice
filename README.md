# Time Microservice
This is just a simple API web which was developed using ASP.NET Core MVC that returns an UTC Date format and an UNIX time format as string. The result is shown in a JSON format.

## How to use it?
The API use a GET method to retrieve data from the URL and it's queryparams, which in this case can be a null object or a string with a `yyyy-dd-mm` format. In case you sent an empty/null object the result is going to be the current date in UTC and UNIX format, also, if you sent a valid string the API will return the repective date on the mentioned formats.

## Example
URL with a valid string: <br/>
```
http://localhost:5186/Date?date=2015-25-12
```
<br/>
Response Body:
<br/>

```
{
  "utc": "25/01/2015 12:00:00 a. m.",
  "unix": "1422144000000"
}
```
URL with an empty string: <br/>
```
http://localhost:5186/Date?date=2015-25-12
```
<br/>
Response Body:
<br/>

```
{
  "utc": "19/07/2023 12:00:00 a. m.",
  "unix": "1689724800000"
}
```
## Build
Use the command `dotnet build` in visual studio code integrated terminal to compile the app.

## Run the API
Use the command `dotnet run` in visual studio code integrated terminal to run the app on your localhost.

## Swagger DOCS
visit `http://localhost:{PORT}/swagger/index.html` to read the documentation.
