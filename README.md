# _Parks Api_

#### By _**Rosario Ruvalcaba**_

#### _A C# .Net Web Api application that maintains and returns data of state and national parks._

## Technologies Used

* _C#_
* _.Net 5.0_
* _ASP .Net Core MVC_
* _MySQL Workbench_
* _Entity Core Framework_
* _Markdown_
* _Newtonsoft.json/Swagger_


## Description

_The Parks RESTful API has full CRUD functionality. The API will return park information such as Name, Date Established, Acrerage, etc. The Parks SQL database can be queried for parks with these various properties. Parks can be added, deleted, and edited either fully though PUT route, or partially via PATCH. Swagger is used to document endpoints._


## Setup/Installation Requirements

* _Clone repository from Github and save a copy on own computer. Then on your local copy, navigate to the top level of the directory._

* _If saving repository remotely, make an initial commit pushing ONLY your .gitignore file so sensitive information is not pushed._

* _Ensure you have C# and .NET installed by running the command [dotnet --version] in your terminal. If the response is not a version number, install .NET from Microsoft website._

* _Install MySQL Community Server MySQL Workbench per instruction provided below by Epicodus:_
  * _[https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql]_


* _Create file called appsettings.json in the main project directory (HairSalon)_
  * _Open file and add the following: { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE NAME HERE];uid=[USER ID HERE];pwd=[PASSWORD HERE];" } }_
  * _Substitute your own information for DATABASE NAME HERE, USER ID HERE, and PASSWORD HERE._

* _Navigate to the ParksApi directory in the project and run the command [dotnet restore, then dotnet build]._

* _Next run the command [dotnet ef database update] to re-create the database with all it's migrations in MySql._

* _While still in the ParksApi directory, run the command [dotnet run] to run the application using a localhost server._

* _You can now use Postman (http://localhost:5000/api/parks) or Swagger (https://localhost:5001/swagger/index.html) to use the API_

## Routes/Endpoints

* _Routes and required parameters can be viewed on Swagger once the application is running: https://localhost:5001/swagger/index.html_

* _Here's a screen shot showing the routes with a short summary of what they do_

![Alt text](/ParksApi/SwaggerScreenShot.jpg?raw=ture "Optional Title")


## Known Bugs

*_XLM comments are not conscise/clean looking in the controller file. Need to edit_*

*_Search by acreage is too strict -- client must enter correct and exact double so it must be edited to be more broad, perhaps to search for parks above or below a certain acreage, which is more realistic to what someone would be searching for._*

## License

MIT License

Copyright (c) _September_2022_ _Rosario Ruvalcaba Harwood_