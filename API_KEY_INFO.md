## API KEY INFO
*No api keys are to be stored in this document.*  
The purpose of this document is to explain how to store these keys securely using the secure store, as explained below.  

### Creating & Adding to the Secret Store
To prevent keys from being made public we are stiring our api key in the Visual Studio secret store. Follow the steps below to add to the secret store.
1. Launch PowerShell Dev tab in Visual Studio.  
   *If it is not displayed, click View > Terminal or Ctrl+*
2. Navigate to the same directory as the .csproj file.  
   *Normally this is normally one level down from the root of the project directory.*
4. Create the file to store the api key by entering the following:  
   <code>dotnet user-secrets init</code>
4. Next add the apikey to the secret store with the the api key:  
   <code>dotnet user-secrets set <name-key> <api-key></code>

### Obtaining API Keys
The team keeps the api keys stored under the RapidAPI team account. For access to the account work with the PM.
