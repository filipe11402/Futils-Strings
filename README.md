# String Formatting Library

Format your strings using these Extension Methods

---

## Documentation


#### .NET CLI
```
dotnet add package FUtils.Strings 
```

#### Nuget
```
Install-Package FUtils.Strings
```


#### String Extensions

**ToPascalCase()**

```cs 
    var myStringNonPascalCase = "hello-there";

    // returns HelloThere
    var myPascalCaseString = myStringNonPascalCase.ToPascalCase();
```

**CapitalizeFirstLetter()**
```cs 
    var myNonCapitalizedString = "hellomate";

    // returns Hellomate
    var capitalizedString = myNonCapitalizedString.CapitalizeFirstLetter();
```

**RemoveWhiteSpaces()**
```cs 
    var myWhiteSpaceString = "hello my friend";

    // returns hellomate
    var noWhiteSpacesString = myWhiteSpaceString.RemoveWhiteSpaces();
```

#### Exceptions

**ArgumentNullException**

Throws ArgumentNullException With the message ``` ValueCannotBeNull ```

```cs
    var string = ""; //also if string " " or null

    string.RemoveWhiteSpaces();
    string.CapitalizeFirstLetter();
    string.RemoveWhiteSpaces();
```