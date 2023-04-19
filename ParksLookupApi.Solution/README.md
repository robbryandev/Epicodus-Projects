# National Parks Api

## Contributers

- Robert Bryan

## Description

An api implementation to get details about united states national parks

## Technologies Used

- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Nim](https://nim-lang.org/)
- [.Net6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [MySql](https://www.mysql.com/)
- [Cors](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS)

## Dataset Used
[National Parks](https://www.kaggle.com/datasets/thedevastator/the-united-states-national-parks)

## Setup/Installation Requirements

### Requirements

- .Net6
- dotnet tool dotnet-ef
- MySql Server

### Setup

- Open a terminal inside of "ParksLookupApi"
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

- Open a terminal inside of "ParksLookupApi"
- Run server

```
dotnet run
```

## API Documentation

### Cors policies
```
Default (any host):
  methods:
    GET

localOrigin (localhost only):
  methods:
    GET, POST, PUT, DELETE
```

### Endpoints
Base URL: `https://localhost:5000`

#### Park endpoints
```
GET /api/park
GET /api/park/random
GET /api/park/{park_id}
POST /api/park/{park_id}
PUT /api/park/{park_id}
DELETE /api/park/{park_id}
```

#### State endpoints
```
GET /api/state
GET /api/state/random
GET /api/state/{state_id}
POST /api/state/{state_id}
PUT /api/state/{state_id}
DELETE /api/state/{state_id}
```

### Example Queries

#### Sample park GET request
```
https://localhost:5001/api/park/1
```

#### Sample park response
```json
  {
    "park_id": 1,
    "state_id": 19,
    "name": "Acadia"
  }
```

#### Sample park POST request
```
endpoint:
  https://localhost:5001/api/park

body:
  {
    "state_id": 19,
    "name": "Acadia"
  }
```

#### Sample state GET request
```
https://localhost:5001/api/state/1
```

#### Sample state response
```json
  {
    "state_id": 1,
    "name": "California",
    "park_count": 9
  }
```

#### Sample state POST request
```
endpoint:
  https://localhost:5001/api/state

body:
  {
    "name": "California",
    "park_count": 9
  }
```

## Known Bugs

- None

## License

MIT License

Copyright (c) 2023 Robert Bryan

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.