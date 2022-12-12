# Asp.net 4.8 web form Identiy + Microsoft Azure AD Example


1. Create an Asp.net 4.8 web form template app following: https://learn.microsoft.com/en-us/aspnet/web-forms/overview/security/create-a-secure-aspnet-web-forms-app-with-user-registration-email-confirmation-and-password-reset#create-an-aspnet-web-forms-app

1. Create Azure App Registration following: https://learn.microsoft.com/en-us/azure/active-directory/develop/quickstart-register-app

1. Add following section in web.config *after* connectionStrings section and put the client id and client secert generate from step 2
```xml
	<appSettings>
		<add key="AzureADClientId" value="client id here"/>
		<add key="AzureADClientSecret" value="client secret here"/>
	</appSettings>
```

4. In Startup.Auth.cs file, uncomment and update with
```c#
// Uncomment the following lines to enable logging in with third party login providers
app.UseMicrosoftAccountAuthentication(
    clientId: WebConfigurationManager.AppSettings["AzureADClientId"],
    clientSecret: WebConfigurationManager.AppSettings["AzureADClientSecret"]);
```

At this point, you are ready to use your web form with local Asp.net Identity as well as Microsoft Azure ADs.

