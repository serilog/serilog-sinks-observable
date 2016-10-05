# Serilog.Sinks.Observable [![Build status](https://ci.appveyor.com/api/projects/status/adgctkfvda8or6rv?svg=true)](https://ci.appveyor.com/project/serilog/serilog-sinks-observable) [![NuGet Version](http://img.shields.io/nuget/v/Serilog.Sinks.Observable.svg?style=flat)](https://www.nuget.org/packages/Serilog.Sinks.Observable/)

Write Serilog events to observers (Rx) through an `IObservable`.

### Getting started

Install the package from NuGet:

```
Install-Package Serilog.Sinks.Observable
```

Configure Serilog using `WriteTo.Observers`:

```csharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.Observers(events => events
        .Do(evt => { 
		    Console.WriteLine($"Observed event {evt}");
		})
        .Subscribe())
    .CreateLogger();

Log.Infomation("Hello, observers!");

Log.CloseAndFlush();
```

More information about using Serilog is available in the [Serilog Documentation](https://github.com/serilog/serilog/wiki).

Copyright &copy; 2016 Serilog Contributors - Provided under the [Apache License, Version 2.0](http://apache.org/licenses/LICENSE-2.0.html).
