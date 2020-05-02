# How To Setup This is Project 
 Minimum Visual Studio 15 is Required to run this Project. This Project is Created in Visual Studio 15 using C# as Front-End and Designing and SQL as Backend. This Project is Window Based. So this Project only runs in windows. Simple Flat UI Based with Moveable Borderless Form.


# Attributes Used
 ------------------------------------------------------------------------
 Sr) Attribute Name  -> Variable Name (C# TextBox) -> SQL Attribute Name
 ------------------------------------------------------------------------
 1)  Name            -> name                       -> Name          = varchar(50)
 2)  Address         -> address                    -> Address       = varchar(50)
 3)  CNIC            -> cnic                       -> CNIC          = varchar(20)
 4)  Class           -> className                  -> Class         = varchar(20)
 5)  Section         -> section                    -> Section       = varchar(10)
 6)  Roll Number     -> rollNumber                 -> Roll Number   = int
 7)  Date of Birth   -> dateOfBirth                -> Date of Birth = varchar(20)
 ------------------------------------------------------------------------
 
# Use Of Emergency Tab
 In case registration_form Table is not existed in the given Database. It case Create a Table in your Database name as registration_form.

# How To Setup 
 Connect To Database
  Tools > Connect To Database<br/>
 ![ConnectionToDatabase](https://github.com/DevOpsGH/Simple-Registration-ASP.Net-SQL/tree/master/Screenshots/ConnectToDatabase.png)<br/>
 
 TestConnection
  Select Server Name > Then Select Your Database Name > Press Test Connection to Test your Connection with your Database.<br/>
 ![TestConnection](https://github.com/DevOpsGH/Simple-Registration-ASP.Net-SQL/tree/master/Screenshots/ConnectionTest.png)<br/>
 
 Getting Your SQL Server Name<br/>
  Press On Data Connections on the leftSide and Go To Properties and Copy ConnectionString<br/>
 ![GetYourSqlName](https://github.com/DevOpsGH/Simple-Registration-ASP.Net-SQL/tree/master/Screenshots/HowToGetName.PNG)<br/>
 
 Replace Name With Your Database<br/>
 Replace This line :<br/>
  public string connectionName = "Data Source=MSSQLSERVER;Initial Catalog=Database_Lab;Integrated Security=True";<br/>
  In (addRecord.cs, searchRecord.cs, updateRecord.cs, emgergencyTab.cs)<br/>
 ![replaceName](https://github.com/DevOpsGH/Simple-Registration-ASP.Net-SQL/tree/master/Screenshots/LineToBeReplace.png)<br/>
 
# Demo Screenshot
 Form1<br/>
 ![Form1.cs](https://github.com/DevOpsGH/Simple-Registration-ASP.Net-SQL/tree/master/Screenshots/Form1.png)
 <br/>
 AddRecord<br/>
 ![Add Record](https://github.com/DevOpsGH/Simple-Registration-ASP.Net-SQL/tree/master/Screenshots/addRecord.PNG)
 <br/>
 SearchRecord<br/>
 ![Search Record](https://github.com/DevOpsGH/Simple-Registration-ASP.Net-SQL/tree/master/Screenshots/searchRecord.PNG)
 <br/>
 UpdateRecord<br/>
 ![Update Record](https://github.com/DevOpsGH/Simple-Registration-ASP.Net-SQL/tree/master/Screenshots/updateRecord.PNG)
 <br/>
 EmergencyTab<br/>
 ![Emergency Tab](https://github.com/DevOpsGH/Simple-Registration-ASP.Net-SQL/tree/master/Screenshots/emergencyTab.PNG)
 <br/>
 Help<br/>
 ![Help](https://github.com/DevOpsGH/Simple-Registration-ASP.Net-SQL/tree/master/Screenshots/helpMe.PNG)
 <br/>
 
