<!-- HEADER -->
# TheDiscAppMVC Docs

<br/>
<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#setup">About</a></li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#database-schema">Database Schema</a></li>
    <li>
        <a href="#schemas">Schemas</a>
        <ul>
            <li><a href="#collections">Collections</a></li>
            <li><a href="#discs">Discs</a></li>
            <li><a href="#players">Players</a></li>
            <li><a href="#teams">Teams</a></li>
        </ul>
    </li>
    <li><a href="#resources">Resources</a></li>
  </ol>
</details>
<br/>

<!-- ABOUT -->
## About
TheDiscAppMVC is an ASP.NET web application that can be used to create your own database of all things disc golf. It was built out with an n-tier structure with full CRUD (Create, Read, Update, Delete) that include the following layers

 - Data
 - Model
 - Services 
 - Presentation (Controllers, Views, and Styles)
 
The application comes preset with five stock discs, players, teams, and collections. These can be expanded upon, edited, or deleted.

This application is still a working progress and will continually be having new features added to it. Patience would be appreciated as we continue this project.

Developed by [Zach Dearmin](https://github.com/zdearmin)

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- USAGE -->
## Usage
TheDiscAppMVC had been developed with ASP.Net Identity. All indexes can be viewed without registering an account. To edit, get details, or delete information, an account will be required.

This web application has been deployed to Azure Cloud Service. The base website url should resemble 
<p align="right">(<a href="#top">back to top</a>)</p>

<!-- DATABASE SCHEMA -->
## Database Schema
Below is an overview of the data tables:
- Collections
    - **Id** - `int` [PrimaryKey]
    - **Name** - `string` (max-char(50), min-char(2), not null)
    - **PlayerId** - `int` (not null)
    - **DiscId** - `int` (not null)
- Discs
    - **Id** - `int` [PrimaryKey]
    - **Name** - `string` (max-char(50), min-char(2), not null)
    - **Brand** - `int` (not null) - Represents enum type
    - **Stability** - `int` (not null) - Represents enum type
    - **DiscType** - `int` (not null) - Represents enum type
    - **Speed** - `int` (not null) - Represents enum type
    - **Glide** - `int` (not null) - Represents enum type
    - **Turn** - `int` (not null) - Represents enum type
    - **Fade** - `int` (not null) - Represents enum type
    - **Plastic** - `string` (null)
    - **OuterDiameter** - `float` (null)
    - **InnerDiameter** - `float` (null)
    - **RimWidth** - `float` (null)
    - **Height** - `float` (null)
    - **RimDepth** - `float` (null)
    - **MaxWeight** - `float` (null)
    - **RimConfiguration** - `float` (null)
    - **CollectionId** - `int` (null) - [ForeignKey] to Collections table
- Player
    - **Id** - `int` [PrimaryKey]
    - **Name** - 'string' (max-char(50), min-char(2), not null)
    - **PdgaNumber** - 'int' (null)
    - **PdgaRating** - 'int' (null)
    - **TeamId** - 'int' (not null) - [ForeignKey] to Teams table
    - **CollectionId** - 'int' (null) - [ForeignKey] to Collections table
- Teams
    - **Id** - `int` [PrimaryKey]
    - **Name** - `string` (max-char(50), min-char(2), not null)

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- RESOURCES -->
## Resources
Below is a list of resources I would like to give credit to as each one played a role in the development of this MVC.
- [PDGA](https://www.pdga.com/)
- [ASP.NET](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)
- [Visual Studio](https://visualstudio.microsoft.com/vs/)
- [GitHub](https://github.com/)
- [Trello](https://trello.com/)
- [dbdiagram](https://dbdiagram.io/home)
<p align="right">(<a href="#top">back to top</a>)</p>