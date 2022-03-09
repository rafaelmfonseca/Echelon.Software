# Echelon Software

This is my attempt to study the new .NET Core Web API, also i'm using EFCore for persisting data in the database. <br>
To run the migrations, we need to tell the EFCore some paths(which project is the main one, the name of the DbContext's inherited class, etc): <br>
`dotnet ef migrations add InitDatabase -s Echelon.Api -p Echelon.Infrastructure -c AppDbContext --verbose` <br>