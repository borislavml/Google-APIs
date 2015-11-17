# Google-APIs
.NET Project for programmatic CRUD on the various Google APIs: AdWords API, Gmail API, WebMaster Tools API 

										GMAIL API

01. Docs
Official documentation -  https://developers.google.com/gmail/api/v1/reference/
Usefull Gmail serach querries - http://email.about.com/od/gmailtips/qt/et_find_mail.htm

02. Getting started
 Register your application for Gmail API in Google Developers Console(login withe the mail you'll be accessing from your code) - 
https://console.developers.google.com/flows/enableapi?apiid=gmail&pli=1
 Move the generated .json file with credentials to your working directory and rename it client_secret.json
Start the  vs GmailParser.sln an build it in order for .nuget packages and dependencies to be installed on your machine locally	
uncomment the code  in Program.cs on line 22 // gmailParser.AuthorizeApplication();
and run it once to authenticate your application for oAuth access to your gmail account 