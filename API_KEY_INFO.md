## API KEY INFO
The purpose of this document is to explain how to add these keys locally to run the application

### Creating & Adding to the Secret Store
Follow the steps below to add to the secret store.
1. Launch PowerShell Dev tab in Visual Studio.  
   *If it is not displayed, click View > Terminal or Ctrl+*
2. Navigate to the same directory as the .csproj file.  
   *Normally this is normally one level down from the root of the project directory.*
3. Next add the apikey to the secret store with each of these commands, run them one at a time:  
   
   <code>dotnet user-secrets set tmApiKey 641404d7aea85802758ccd6b0857f41a</code>
   
   <code>dotnet user-secrets set movieSearchApikey c4dad057</code>
