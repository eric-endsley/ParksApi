# Parks API

#### An API storing information regarding U.S. state and national parks, 1/22/21

#### By Eric Endsley

## Description

## Setup

### Install .NET Core

1. This program is written in C# and requires the .NET Core to run. For PC users click [this link](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer) and follow the installation instructions. For Mac users click [this link](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) and follow the installation instructions.

2. Install dotnet script by entering the following command in your terminal: "dotnet tool install -g dotnet-script"

### Install MySQL

1. This program uses MySQL to store and manage data. Navigate to [this link](https://dev.mysql.com/downloads/file/?id=484919) and follow the installation instructions to install MySQL and MySQL Workbench.

2. Be sure to make note of the password you create during the installation process, you will need to use this later on in the setup.

### Clone The Repository

1.  Open the [Parks Api website](https://github.com/eric-endsley/ParksApi.git) by clicking the link or copy/pasting "https://github.com/eric-endsley/ParksApi.git" in the navigator bar of a web browser application.

2.  Click the green Code button in the upper-right part of the window and then EITHER:

3.  a. Copy the HTTPS URL for the repo and use it in the git clone command in git-bash or another git terminal by inputting: "git clone https://github.com/eric-endsley/ParksApi.git"<br>
    OR b. Click "Download Zip" and unzip the file to an accessible location on your machine.

4.  Right click on the project directory and open it with VS Code or another code editor.

### Setup MySQL Database with Entity

#### Option 1: Create Data Structure Code First From the Terminal:

1. Navigate to the appsettings.json file within the /ParksApi subdirectory. Locate the line of code that states "pwd=epicodus" and overwrite epicodus with the password you created during installation of MySQL

2. In your terminal, type the command "dotnet restore" followed by the command "dotnet ef database update". You have now created the data structure for this application.

#### Option 2: Import Data Structure Using MySQL Workbench GUI:

1. Open the program MySQL Workbench which you installed earlier and enter the password that you setup during installation.

2. Using the navigation bar select Server > Data Import.

3. When prompted, select the option to "Import From Self Contained File" and select the file "parks_Db_export.sql" in the Factory.Solution folder.

4. In the dropdown labelled "Default Target Schema:", select "eric_endsley" or whatever you named your database in appsettings.json. Select all of the schema objects. Then click the "Start Import" button. You have now imported the data structure.

### Open the Webpage!

1. In the terminal, type the command "dotnet run".

2. If your browser does not automatically open the page, open your preferred browser and enter "http://localhost:5000" in the navigation bar. If this does not work, look for the phrase "Now listening on:" written in your terminal a few lines after your "dotnet run" command. Navigate to the url written there.

## Technologies Used

C#, .NET Core 2.2, ASP.NET Core MVC, MySQL, Entity Framework Core, Razor, Bootstrap, VS Code

## Known Bugs

None

## Contact Information

To ask questions or report a bug, contact [Eric Endsley](mailto:eric.endsley4@gmail.com)

## Legal

This software is licensed under the MIT license.
