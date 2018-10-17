# MadfooatcomAssignment
This is a Software Engineer Assignment for Madfooatcom Company-Jordan.

The Assignment Was Fully Implemented as requested.

The DataBase Back Up Can Be Found On:
/UserSubManagementSystem.BackEnd/DB/

The Current  ConnectionString for the Back-end is:

<add name="DefaultConnection" connectionString="data source=localhost\SQLEXPRESS; initial catalog=UserMSDB; integrated security=SSPI" providerName="System.Data.SqlClient" />

Please consider the follwoing notes:

1-the connectionString's Name should be always "DefaultConnection". Unless its changed from the UserMSDBContext.cs Class and rebuilt the Project.
2-the (base Back-end Url) is in the Web.config of the Fron-end project under the name: "BackEndBaseUrl".
3-A Database Sample is attachted On:/UserSubManagementSystem.BackEnd/DB/.
4- you may want to add multiple Start-up Projects.(back-end,fron-end) 



The Following assumption Were Taken:

1-Sender Code : Randomly Generated Number On each Request, that is submit on The server and/or responded to the Client.

2-Time Stamp:The Current Time Stamp On each Request, that is submit on The server and/or responded to the Client.

3- Sender Code and Time Stamp Are not mapped To the data base since the schema was Clear.

4-all requests are built by razor and C# as per requested, Personally, i would go with the JavaScript ajax calls to maintain  
 the intuitive experience.
 
5-Requests and Responses can be mapped as (Json,XML) And json was the Stander approach to Talk Between layers for this application.
