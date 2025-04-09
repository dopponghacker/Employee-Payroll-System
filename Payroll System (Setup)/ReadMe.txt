How to connect the Database to Microsoft SQL Server Management Studio

1. Launch SSMS:

Click the Windows Start Menu and search for SQL Server Management Studio.

Click to open SSMS.


2. In the "Connect to Server" window, enter the following details:

Server type: Database Engine

Server name: 


3.Authentication:

If using Windows Authentication (default), select Windows Authentication.

- If using SQL Server Authentication, enter:

Username:  your database username.

Password: Your SQL Server password.

Click "Connect".

If successful, SSMS will open and display your SQL Server.


4. Attach an Existing Database (If You Already Have One)
If you have an existing database file (.mdf), follow these steps to attach it:

In SSMS, expand the Databases node.

Right-click on "Databases" ➝ Select Attach....

In the Attach Databases window, click Add.

Locate your .mdf file (e.g., C:\YourProject\Database\PayrollSystem.mdf) and click OK.

Click OK again to attach the database.



