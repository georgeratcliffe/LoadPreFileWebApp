# LoadPreFileWebApp
The application demostrates how a .pre file containing rainfall data can be processed and it's contents inserted into a SQL Server table
Simply enter in the full path name of the file and click the button to begin processing. On completion the results will be inserted into 
the dbo.Results table. All process information is written to the dbo.ResultsLog table which is displayed to the user

Some notes
<ul>
  <li>This is just meant to be a very basic application intended to show how a full stack solution can forefill the requirements outlined in the JBA Software spec </li>
  <li>File selection cannot be done by <i> input type='file' </i> as it only captures only the file name - not the full path</li>
  <li>Server name and database needs to be set in appsettings.json file</li>
  <li>Required database objects reside in https://github.com/georgeratcliffe/LoadPreFileWebAppDatabase </li>
  <li>Database can be created manually or by EF migrations (in which the case dbo.ResultsLog will be created automatically)</li>
</ul>
