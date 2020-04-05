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
 Tools > Connect To Database
 ![ConnectionToDatabase](https://github.com/code-rez/Registration_Form/blob/master/Screenshots/ConnectToDatabase.png)
 
 TestConnection
 Select Server Name > Then Select Your Database Name > Press Test Connection to Test your Connection with your Database.
 ![TestConnection](https://github.com/code-rez/Registration_Form/blob/master/Screenshots/ConnectionTest.png)
 
 Replace Name With Your Database
 Replace This line :
  public string connectionName = "Data Source=MTALHA_001;Initial Catalog=Database_Lab;Integrated Security=True";
  In (addRecord.cs, searchRecord.cs, updateRecord.cs, emgergencyTab.cs)
 ![replaceName](https://github.com/code-rez/Registration_Form/blob/master/Screenshots/LineToBeReplace.png)

# Demo Screenshot
 Form1
 ![Form1.cs](https://github.com/code-rez/Registration_Form/blob/master/Screenshots/Form1.png)
 
 AddRecord
 ![Add Record](https://github.com/code-rez/Registration_Form/blob/master/Screenshots/addRecord.PNG)
 
 SearchRecord
 ![Search Record](https://github.com/code-rez/Registration_Form/blob/master/Screenshots/searchRecord.PNG)
 
 UpdateRecord
 ![Update Record](https://github.com/code-rez/Registration_Form/blob/master/Screenshots/updateRecord.PNG)
 
 EmergencyTab
 ![Emergency Tab](https://github.com/code-rez/Registration_Form/blob/master/Screenshots/emergencyTab.PNG)
 
 Help
 ![Help](https://github.com/code-rez/Registration_Form/blob/master/Screenshots/helpMe.PNG)
 
 
