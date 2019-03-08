# Account API sample app

this application is a .NET Core api application. it also leverages steeltoe. this app will run migrations to a local sqllite db on boot.

## Run Locally

* execute the below command in the repo root.
  
    `dotnet run`

* open a browser `https://localhost:5001/api/accounts`


## Build

`dotnet build`

## Run on PCF

* assuming you have already logged in to a pcf environment via the `cf-cli`. run the following command.

    `cf push dotnet-sample`
