# Version

- <https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/language-versioning>

## Framework 버전 vs Langugage 버전

|                                  |                            |
| -------------------------------- | -------------------------- |
| C#   {csharp-version}            | `<LangVersion>`            |
| .NET {net-version}               | `<TargetFramework>`        |
| .NET Framework {old-net-version} | `<TargetFrameworkVersion>` |

## Language 버전

| [C# Version](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history)         |                                                                                                                                                                             |
| ------------------------------------------------------------------------------------------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [14](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-14)    | [whats-new](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-14)                                                                                            |
| [13](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-13)    | [whats-new](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13)                                                                                            |
| [12](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-12)    | [whats-new](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)                                                                                            |  |
| [11](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-11)    | [whats-new](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11)                                                                                            |
| [10](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-10)    | [whats-new](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10)                                                                                            |
| [9](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-9)      |                                                                                                                                                                             |
| [8.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-80)   |                                                                                                                                                                             |
| [7.3](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-73)   |                                                                                                                                                                             |
| [7.2](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-72)   |                                                                                                                                                                             |
| [7.1](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-71)   |                                                                                                                                                                             |
| [7.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-70)   |                                                                                                                                                                             |
| [6.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-60)   |                                                                                                                                                                             |
| [5.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-50)   |                                                                                                                                                                             |
| [4.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-40)   | [C# 4.0 - New C# Features in the .NET Framework 4](https://learn.microsoft.com/en-us/archive/msdn-magazine/2010/july/csharp-4-0-new-csharp-features-in-the-net-framework-4) |
| [3.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-30)   |                                                                                                                                                                             |
| [2.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-20)   | [What's New in the C# 2.0 Language and Compiler](https://learn.microsoft.com/en-us/previous-versions//7cz8t42e(v=vs.85)?redirectedfrom=MSDN)                                |
| [1.2](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-12-1) |                                                                                                                                                                             |
| [1.0](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history#c-version-10-1) |                                                                                                                                                                             |


## Framework 버전

| Target        | 버전 | LangVersion | VS            |
| ------------- | ---- | ----------- | ------------- |
| .NET          | 10.x | 14          | VS 2026       |
| .NET          | 9.x  | 13          | VS 2022 17.10 |
| .NET          | 8.x  | 12          | VS 2022 17.8  |
| .NET          | 7.x  | 11          | VS 2022 17.4  |
| .NET          | 6.x  | 10          | VS 2022 17.0  |
| .NET          | 5.x  | 9.0         | VS 2019 16.8  |
| .NET 코어     | 3.x  | 8.0         | VS 2019 16.3  |
| .NET 코어     | 2.x  | 7.3         | VS 2017 15.7  |
| .NET Standard | 2.1  | 8.0         | VS 2019       |
| .NET Standard | 2.0  | 7.3         | VS 2017       |
| .NET Standard | 1.x  | 7.3         | VS 2017       |

|                            |                |
| -------------------------- | -------------- |
| `<TargetFramework>`        | net5           |
| `<TargetFramework>`        | netcoreapp1.0  |
| `<TargetFramework>`        | netstandard1.0 |
| `<TargetFrameworkVersion>` | v1.0           |

| TargetFrameworkVersion | LangVersion | VS      |
| ---------------------- | ----------- | ------- |
| v4.8                   | 7.3         | VS 2019 |
| v4.7                   | 7.0         | VS 2017 |
| v4.6                   | 6.0         | VS 2015 |
| v4.5.1                 | 5.0         | VS 2013 |
| v4.5                   | 5.0         | VS 2012 |
| v4.0                   | 4.0         | VS 2010 |
| v3.5                   | 3.0         | VS 2008 |
| v2.0                   | 2.0         | VS 2005 |
| v1.1                   | 1.2         | VS 2003 |
| v1.0                   | 1.0         | VS 2002 |