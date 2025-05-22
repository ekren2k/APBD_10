to run the app, create an appsettings.json file with the following configuration:

```{
  "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "ConnectionStrings" : {
    "DefaultConnection" : "Your-absolutely-majestic-connection-string"
  }
}
```

the main reason why i decided to not split the project is that the project is not as complicated and large so far, therefore i follow YAGNI principles and if the project becomes larger, then i would think about splitting it into several projects
