  MyLiteShop
  
1. MyLiteShop - is a test project to employment opportunity in one company.
2. List of used technologies:
- ASP.Net Core;
- Microsoft Entity Framework Core;
- PostgreSQL;
- SwaggerUI;
3. How to set up?

You need to instal PostgreSQL. Create DataBase with a name, what you will use in a ConnectionString. After it you need to configure your ConnectionString in a [secret](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows#json-structure-flattening-in-visual-studio) file.

In the end you need to open a PowerShell and run command from folder with project: dotnet ef database update. 

After these manipulations you can use my project.
