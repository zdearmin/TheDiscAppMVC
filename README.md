<!-- HEADER -->
# TheDiscAppMVC Docs

<br/>
<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#creators">Creators</a></li>
    <li><a href="#setup">Setup</a></li>
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

<!-- SETUP -->
## Setup
To start, you will need to clone the repository into your desired directory. Everything you need to access and run this MVC is included in this repository. You do not need any external dependencies.

To clone the repository, run this command in your terminal:
```
git clone https://github.com/zdearmin/TheDiscAppMVC.git
```


With your server running, you can execute the following command to create the database and tables. If your current working directory is the same as the folder with the `.git` file, your command should look like below:
```

```
<p align="right">(<a href="#top">back to top</a>)</p>

<!-- USAGE -->
## Usage

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- DATABASE SCHEMA -->
## Database Schema
Here is an overview of the tables:
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

<!-- SCHEMAS -->
## Schemas

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- COLLECTIONS -->
### **Collections**

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- DISCS -->
### **Discs**

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- PLAYERS -->
### **Players**

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- TEAMS -->
### **Teams**

<p align="right">(<a href="#top">back to top</a>)</p>

<!-- RESOURCES -->
## Resources
Below is a list of resources I would like to give credit to as each one played a role in the development of this MVC.
- [ASP.NET](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)
- [Visual Studio](https://visualstudio.microsoft.com/vs/)
- [GitHub](https://github.com/)
- [Trello](https://trello.com/)
- [dbdiagram](https://dbdiagram.io/home)
<p align="right">(<a href="#top">back to top</a>)</p>