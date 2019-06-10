# Net-core-backend using Interface
.Net Core Web API back end using Interface  for React Blog / Angular Blog front end in my Repositories

Install visual studio 
open project in Visual Studio
Simply run the application 
#Install Entity Frame work
--------------------------
Go to Solution Explorer Right click on project folder right click and go to Manage new get packages
go to browse and search following 

install entityframework core Sql server 2.14 
install entityframework core Tools      2.14
2.14 is more stable or you can use 2.2 

# NuGet Command : Install Web API Cors
-------------------------------
Install-Package Microsoft.AspNet.WebApi.Cors 

# NuGet Command : Fix Version Compactability of Cors and Http
---------------------------------------------------
Update-Package Microsoft.AspNet.WebApi -reinstall
Install-Package Microsoft.AspNet.WebApi.Core

#To create Database 
---------------
go to tools then
New get Package manager then
Package manager console  and -Start Typing--

Add-migration initial create -then hit enter ,and then start typing--
update-database -then hit enter ,
--------this will create databse   and tables for you 
