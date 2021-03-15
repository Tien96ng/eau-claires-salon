# Eau Claire's Salon

#### MVC Web App to track the Salon's stylists and their clientele.

#### By Tien Nguyen

## Technologies Used

* _C# 9.0_
* _.NET 5.0_
* _MSTEST_
* _MySQL 8_
* _MySQL Workbench 8_
* _Razor_
* _Entity Framework_
* _Bootstrap 4.5.2_
* _HTML 5_
* _CSS 3_

## Description
_A MVC web application for "Eau Claire's Salon" is used as an operations tracking platform. The platform stores Stylists's that are hired at the Salon along with their specific clients. This platform works well by seperating the clients via Stylist specific. With the utilization of the Entity Framework and MySQL, the app is a one to many relationship that uses ORM to transfer data in the relational database tables in Objects with the MVC Models._

## Setup / Installation Requirements

<details>
<summary> ### Installing C# and .NET: <summary>

  **1a.** _WINDOWS: Download the [64-bit .NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer). Clicking these links will prompt a **.exe** file download from Microsoft_.\
  \
  **1b.** _MAC: Download this [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer). Clicking this link will prompt a **.pkg** file download from Microsoft_.\
  \
  **2.** _Open the file and follow the steps provided by the installer for your OS_.\
  \
  **3.** _Confirm the installation is successful by opening a new Windows PowerShell OR Max Terminal window and running the command dotnet --version_.
</details>

<details>
<summary> ### Installing MySQL and MySQL WorkBench ### </summary>

#### Windows Install ####
1. _WINDOWS: Download the [MySQL](https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi). Use the **No thanks**, just start my download link._


#### MacOS Install ####
1. _MAC: Download the [MySQL](https://dev.mysql.com/downloads/file/?id=484914). Clicking this link will prompt a **.dmg** file download from Microsoft._
2. _Follow along with the **Installer** until you reach the **Configuration** page._
3. _In the Configuation page, first **Use Legacy Password Encryption**._
4. _Set password to what you desire - **NOTE: Please remember your password**!_
5. _Click Finish._
6. _Open your terminal and enter the follow command: **echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile**_
7. _Type **source ~/.bash_profile** (or restart the terminal) in order to actually verify that MySQL was installed._
8. _Verify MySQL is installed by opening the terminal and enter in the command, replacing the placeholder with your password: **mysql -uroot -p[PASSWORD]**_
9. _Download and Install [MySQL WorkBench](https://dev.mysql.com/downloads/file/?id=484391) to Applications folder._

</details>

<details>
<summary> ### Local Environment Setup </summary>
1. _Clone the repo or download the ZIP file of the repo._
2. _Navigate to the main directory of the repo._
3. _Open the repo's main directory in the Code Editor of your choice._
4. _Run the **FIRST** command in your terminal within the repo's main directory (Example: /VendorOrderTracker/): __"dotnet restore"__._
5. _Run the **SECOND** command in your terminal within the repo's main directory (Example: /VendorOrderTracker/): __"dotnet build"__._
6. _Run the **THIRD** command in your terminal within the same main directory (Example: /VendorOrderTracker/): __"dotnet run"__._
7. _The App should now be running Localhost:5000._
8. _Open any web browser app and go to **http://localhost:5000/** to open your app._
8. _To stop the app during any moment, press the following combination of keys in your terminal: _**CTRL**_ + _**C**_._
</details>

## Known Bugs

* _None at the moment (3/12/2021)_

## Project Goals / Further Exploration
- _Add more properties for each Model._
- _Add the ability to update Vendor or Order details._
- _Add the ability for Pierre to note whether an order has been paid for or not._
_ _Add search functionality to your app._

## License
_This software is licensed under the MIT license_\
Copyright (c) 2021 __Tien Nguyen__

## Contact Information
_<Tien96ng@github.com>_