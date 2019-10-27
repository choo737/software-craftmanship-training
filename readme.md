# Software Craftmanship Training
### A simple, comparison between the different level of code quality.

---
### Get started

* Clone the repository
* Launch CodeDemo.sln in Visual Studio

### Prerequisite

* Install dotnet core runtime

### Restore your packages

1. `cd CodeDemo1 && dotnet restore && cd ../CodeDemo2 && dotnet restore && cd ../DemoModel && dotnet restore && cd ..`
2. to the the application, cd into each folder and do `dotnet run`

### Try the "**Hard** to maintain" code
* Go to project **CodeDemo1**.
* Run the project.
* Try to complete the tasks below in *Program.cs*
 * Add a few products into Vehicle Product Group
 * Add a few products into Merdeka Package
 * Change Chinese New Year Package to products (Strawberry Jam, BMW, Table)

### Try the "**Easy** to maintain" code
* Go to project **CodeDemo2**.
* Run the project.
* Try to complete the tasks below in *Program.cs*
 * Add a few products into Vehicle Product Group
 * Add a few products into Merdeka Package
 * Change Chinese New Year Package to products (MyVI, Table, Fried Rice)