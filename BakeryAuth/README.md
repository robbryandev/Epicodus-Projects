# Pierre's Sweet and Savory Treats

## Contributers

- Robert Bryan

## Description

A basic web app to keep track of treats and the flavors they have

## Technologies Used

- c#
- .Net6
- Entity Framework Core
- MySql
- HTML
- CSS
- Bootstrap

## Setup/Installation Requirements

### Requirements

- .Net6
- dotnet tool dotnet-ef
- MySql Server

### Setup

- Open a terminal inside of "HairSalon"
- Restore packages

```
dotnet restore
```

- setup database

```
dotnet ef database update
```

- Create a file named "appsettings.json" inside of "Factory" following this schema

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=robert_bryan;uid=[your mysql username];pwd=[your mysql password];"
  }
}
```

## Run

- Open a terminal inside of "Factory"
- Run server

```
dotnet run
```

## Known Bugs

- None

## License

MIT License

Copyright (c) 2023 Robert Bryan

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.