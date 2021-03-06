# ASP.NET MVC3 Boilerplate #

A collection of addons and configurations I use in most projects. Inspired by HTML5 Boilerplate.

I'd love to see someone smarter then me take this over and make it awesome. I'm sure there are things I have in here that may not be best practices.

## Features ##

* HTML5 Boilerplate - http://html5boilerplate.com/
* Elmah - http://code.google.com/p/elmah/
* JSON Parser - https://github.com/douglascrockford/JSON-js
* Modernizr - http://www.modernizr.com/
* Ninject - http://ninject.org/
* Telerik MVC Extensions - http://www.telerik.com/products/aspnet-mvc.aspx
* Sql Server CE - http://nuget.org/Packages/Packages/Details/SqlServerCompact-4-0-8482-1
* EF Code First - http://nuget.org/Packages/Packages/Details/EFCodeFirst-0-8
* Bits from Tekpub MVC 2 Starter Site - http://mvcstarter.codeplex.com/
* Basic User Signup using simple POCO User object complete with change and forgot your password.
* Cache Extensions - http://stackoverflow.com/questions/445050/how-can-i-cache-objects-in-asp-net-mvc
* Phil Haack's Enumeration Extensions - http://haacked.com/archive/2010/06/10/checking-for-empty-enumerations.aspx
* BCrypt password hashing

## History ##

### 8/12/2011 ###
* Changed Hash routine to use BCrypt.
* Moved Upload Paths to SiteHelper and removed unnecessary namespace declarations to make it easier to more SiteSettings to its own assembly.
* Fixed minor bug with flash helper displaying both validation summary and flash message.

### 8/11/2011 ###
* Added "Forgot Password" feature that sends an email with a uniqure verification url that the user can visit to change their password.
* Updated all Nuget packages
* Changed to custom jQuery UI theme and updated to version 1.8.15
* Updated jQuery to 1.6.2
* Updated jQuery.Validate to 1.8.1
* Updated modernizr to 2.0.6
* Fixed bug in jquery.validate.unobtrusive.js so it works with new version of jQuery
* Updated HTML5 Boilerplate to 2.0
* Changed the HTML Helper DeleteLink to FormPostLink because it can be used to do more then just delete.
* Added FormPostButton HTML Helper.
* Fixed issue with custom MembershipProvider and how we were saving the UserId. We now save the username as the FormsAuth Username and store UserId in UserData.

### 8/9/2011 ###
* Added $.cancelAjaxIfRunning function.

### 7/31/2011 ###
* Updated Flash Message helpers to work without javascript.
* Added Z-index to flash message.

### 7/05/2011 ###
* Enabled Elmah error filtering by default.

### 6/19/2011 ###
* Added null check to CacheHelper.

### 5/13/2011 ###
* Replaced SquishIt with Telerik since Telerik seems to have better compression and it's more AppHarbor friendly.
* Added ImagePath Helper.

### 5/12/2011 ###
* Changed CSS to not cause issues with plupload.

### 5/10/2011 ###
* Fixed bug with displaying error messages on signup.

### 5/5/2011 ###
* Updated Valid Email check's Regex so it supports + signs.

### 4/5/2011 ###
* Fixed a couple bugs in UserMembershipProvider with returning the Email versus Username.
* Made Repository Classes static.
* Added CacheHelper so stuff like "Friendly name" would not be passed around in a cookie.
* Added Phil Haack's Enumeration Extensions

### 3/25/2011 ###
* Moved jQuery UI to root of content to fix issue with SquishIt and images path.

### 3/24/2011 ###
* Merged IUserSession functionality into IFormsAuthenticationService since they were pretty similar.

### 3/21/2011 ###
* Updated to use EntityFramework.4.1 Nuget package and dealt with this bug caused by doing so. http://stackoverflow.com/questions/5365376/system-nullreferenceexception-after-upgrade-to-ef-4-1
* Removed unnecessary using statements in Models.
* Updated UserRepository.CreatePasswordHash to not rely on System.Web namespace.
* Updated _Layout.cshtml to note how/why I modified HTML5 Boilerplate.

### 3/10/2011 ###

* Updated SessionController to use a proper custom MembershipProvider instead of the hack that was in there before.
* Updated all Nuget Packages to their latest versions.
* Updated HTML5 Boilerplate to v1.0rc
* Updated jQuery UI to 1.8.10
* Updated Modernizr to 1.7
* Fixed bugs in Flash helpers.
* Fixed other minor bugs.

## Road Map ##
* Add alternative login options like OpenId, Janrain, or Twitter?
* Create Nuget package?