# Eau Claire's Salon

#### By **Karl Starkweather**

#### Eau Claire's Salon is a basic website that keeps track of hair stylists and their customers

## Technologies Used

- C#
- ASP.Net Core
- ASP.NET MVC
- Entity Framework
- MySql Database

## Description

This application allows the user to enter stylists and customers, linking each customer to a stylist.

Database Structure

![Database Structure Image](/wwwroot/img/DatabaseImage.jpg)

## Setup/Installation Requirements

- Open the terminal on your local machine and navigate to where you want to clone the project
- Run the following command: 
    - git clone https://github.com/KarlStarkweather/HairSalon.Solution.git
- Follow the instruction here for configuring MySql:
    - Download and install: MySql Community
    - Download and install: MySql Workbench
- Follow these steps to import the table needed for the project:
    - Determine if the MySql server is running locally by typing the following into the command line mysql -uroot -p[The password you set up]
    - Open MySql Workbench. 
    - Once open select the Administration tab. 
    - Next select Data Import/Restore. This opens up the Data Import window with the Import from Disk tab open. 
    - Select the radio button for Import from Self-Contained File. 
    - Click the button with the three dots (if on windows) or two dots (if on mac) at the end of the path field. This will open a window to search for the sql dump file on your local disk. 
    - Navigate to the root directory of the cloned project
    - Select karl_starkweather.sql and click the open button. 
    - Next, press the New... button. This will open a window where you can choose the name of the imported schema. 
    - Choose a name appropriate to the project, e.g. HairSalon and click Okay. We'll need this name later when setting up the project to work with this schema. 
    - If on a mac, click the Start Import button. If on a windows machine, switch to the Import Progress tab on the Data Import page. Click the Import button. Finally, re-click on the Schemas tab. Right-click in the Schemas window, and select Refresh All. The imported schema should now be listed.
  \*Navigate back to the HairSalon/ directory and create a file named: appsettings.json. In this file, add the following configuration to set up the project to work with the schema you imported:
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[THE-NAME-YOU-CHOSE-WHEN-IMPORTING-THE-SCHEMA];uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }
- From the HairSalon main directory, run the following from the command line: 
    - dotnet build
- Then run the following to start the web server:
    - dotnet run 

## Known Bugs

-None

## Contact Me

Let us know if you run into any issues or have questions, ideas, or concerns:
stark13@usa.net

## License

Copyright (c) February 2022 Karl Starkweather.
[MIT License](https://opensource.org/licenses/MIT)