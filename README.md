# MyLiteShop 

is a minimal WebApi test task for employment opportunity in one company. 

# Technologies

 - ASP.Net Core
 - Microsoft Entity Framework Core
 - PostgreSQL
 - SwaggerUI

# How to set up

1. You need to [install PostgreSQL](https://www.postgresql.org/). Create database with a name, that you will be using in a ConnectionString. 
2. After it you need to configure your ConnectionString in a [secrets.json](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows#json-structure-flattening-in-visual-studio) file. See example:
```json
{
  "ConnectionStrings": {
    "ShopConnection": "User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=myLiteShop;"
  }
}
```
3. In the end you need to open a PowerShell and run command from project folder: `dotnet ef database update`. 
4. After these manipulations you can use my project.
