# MyFirstMVC
This repository contains a my first MVC as well as publication to Azure


## Context
This is a basic Web App using ASP.NET application that includes publication to Azure


## Table of Contents
- [MyFirstMVC](#myfirstmvc)
- [Context](#context)
- [Table of Contents](#table-of-contents)


## Overview
Web App using ASP.NET  
Imagine, You’re the owner of a startup organization that facilitates the sale of comics online around your area. To get your product to market as quickly as possible, you decided to use Microsoft Azure App Service to host your web apps and APIs. The following tasks need to be completed:


### Task 1: Create a web app using ASP.NET In the Azure portal and deploy the web application to Web Apps- Using the information below:  
- Home page – which must show all other tabs such as Location, Favourites, About Us, and Latest News  
- All of your pages must have a footer with your name, student number, and the course you are enrolled in.  
Screenshot of the Output: 
<br><br>  <img src="assets/images/MFMVC1.png" alt="MyFirstMVC image 1">


Location Page  
This page displays the geographic location of Comic bookstores in an area around you. Use Geolocation to add a Google Map with a Marker to Your Website a minimum of 5 comic book stores are required on your map.  
Screenshot of the Output:
<br><br>  <img src="assets/images/MFMVC2.png" alt="MyFirstMVC image 2">


Other Pages  
1. Favorites: This page should display 4 of your favorite comics with a brief 
explanation. Use your design for the look and feel of the page. This information 
should be displayed once the Favorite button is clicked. 
Screenshot of the Output:
<br><br>  <img src="assets/images/MFMVC3a.png" alt="MyFirstMVC image 3a">
<br>  <img src="assets/images/MFMVC3b.png" alt="MyFirstMVC image 3b" width="605px">


2. About us: Include a brief explanation of your comic business. This information 
should be displayed once the About Us button is clicked.  
Screenshot of the Output:
<br><br>  <img src="assets/images/MFMVC4.png" alt="MyFirstMVC image 4">


3. Latest News: Link the website to an external page to show information on the 
new comic’s release. This information should be displayed once the Latest News 
button is clicked.  
Screenshot of the Output: 
<br><br>  <img src="assets/images/MFMVC5a.png" alt="MyFirstMVC image 5a">
<br>  <img src="assets/images/MFMVC5b.png" alt="MyFirstMVC image 5b" width="605px">
<br>  <img src="assets/images/MFMVC5c.png" alt="MyFirstMVC image 5c">


When you click on one of the ‘Learn More’ buttons, it will redirect you to an external page:
<br><br>  <img src="assets/images/MFMVC6.png" alt="MyFirstMVC image 6">


Like this:
<br><br>  <img src="assets/images/MFMVC7.png" alt="MyFirstMVC image 7">





Publishing to Azure: Using Microsoft Azure App Service to host your web apps and APIs. 
The steps and screenshots of the steps: 
As we can see, the web application is currently running on our ‘localhost’: 
<br><br>  <img src="assets/images/MFMVC8.png" alt="MyFirstMVC image 8">


1.1. So in order to host our Web Application in Microsoft Azure, the first thing 
would be to open up Visual Studio and open our Web Application MVC. 
<br><br>  <img src="assets/images/MFMVC9.png" alt="MyFirstMVC image 9">


1.2. Right click on the MVC Application: 
<br><br>  <img src="assets/images/MFMVC10.png" alt="MyFirstMVC image 10">


1.3. Click on ‘Publish…’: 
<br><br>  <img src="assets/images/MFMVC11.png" alt="MyFirstMVC image 11">


1.4. Select ‘Azure’ and click ‘Next’: 
<br><br>  <img src="assets/images/MFMVC12.png" alt="MyFirstMVC image 12">


1.5. Select ‘Azure App Service (Windows)’ and click ‘Next’: 
<br><br>  <img src="assets/images/MFMVC13.png" alt="MyFirstMVC image 13">


1.6. Choose the account to which you want to publish the Web Application to and if there is no Azure App Service already created, click on ‘+ Create new’: 
<br><br>  <img src="assets/images/MFMVC14.png" alt="MyFirstMVC image 14">


1.7. This is the window that creates the App Service in Azure. You can provide a name; and the resource group and hosting plan is created automatically. Then 
click ‘Create’: 
<br><br>  <img src="assets/images/MFMVC15.png" alt="MyFirstMVC image 15">


1.8. The App Service is now being created: 
<br><br>  <img src="assets/images/MFMVC16.png" alt="MyFirstMVC image 16">


1.9. Once the App Service has been created successfully click ‘Finish’: 
<br><br>  <img src="assets/images/MFMVC17.png" alt="MyFirstMVC image 17">


1.10. The Publish Profile has also been created successfully. Click ‘Close’: 
<br><br>  <img src="assets/images/MFMVC18.png" alt="MyFirstMVC image 18">



2.1. The Web Application MVC is now ready to publish. Click on ‘Publish’: 
<br><br>  <img src="assets/images/MFMVC19.png" alt="MyFirstMVC image 19">


2.2. The Web Application is now being published to Azure App Service: 
<br><br>  <img src="assets/images/MFMVC20.png" alt="MyFirstMVC image 20">


2.3. Once the Web Application has been published successfully, you can Copy the Link/Site URL to the clipboard: 
<br><br>  <img src="assets/images/MFMVC21.png" alt="MyFirstMVC image 21">


2.4. Paste the Link/Site URL in the URL of your browser and hit ‘Enter’: 
<br><br>  <img src="assets/images/MFMVC22.png" alt="MyFirstMVC image 22">


2.5. The Web Application has now been hosted successfully on Azure Web App Service and is live. The Web Application is no longer running on the ‘localhost’: 
<br><br>  <img src="assets/images/MFMVC23.png" alt="MyFirstMVC image 23">



3.1. Now sign in to your Azure Portal:
<br><br>  <img src="assets/images/MFMVC24.png" alt="MyFirstMVC image 24">


3.2. Click on ‘Resource Groups’: 
<br><br>  <img src="assets/images/MFMVC25.png" alt="MyFirstMVC image 25">


3.3. This is the Resource Group that contains the Web Application that we just published: 
<br><br>  <img src="assets/images/MFMVC26.png" alt="MyFirstMVC image 26">


3.4. Now on the top right-hand corner, click on the Cloud Shell icon. Once the Cloud Shell has opened up, type in this command: 
`Remove-AzResourceGroup -Name {name of the resource group}`: 
<br><br>  <img src="assets/images/MFMVC27.png" alt="MyFirstMVC image 27">


3.5. Type ‘Y’ to confirm removing/deleting the Resource Group then hit ‘Enter’: 
<br><br>  <img src="assets/images/MFMVC28.png" alt="MyFirstMVC image 28">


3.6. The Resource Group has now been removed/deleted successfully: 
<br><br>  <img src="assets/images/MFMVC29.png" alt="MyFirstMVC image 29">


3.8. You can also refresh the ‘Resource Groups’ page to confirm that the Resource Group has been removed/deleted successfully: 
<br><br>  <img src="assets/images/MFMVC30.png" alt="MyFirstMVC image 30">



4.1. Finally, you can click the ‘x’ icon to close all the active applications: 
<br><br>  <img src="assets/images/MFMVC31.png" alt="MyFirstMVC image 31">