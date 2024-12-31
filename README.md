# To-Do List API

A simple RESTful API built with ASP.NET Core that allows users to manage their tasks. The API supports operations like creating, reading, updating, and deleting to-do items.

---

## Features
- **CRUD Operations**: Add, retrieve, update, and delete tasks.
- **Swagger Integration**: Explore and test the API directly via the Swagger UI.
- **In-Memory Database**: Uses an in-memory database for testing purposes (can be replaced with a real database in production).

---

## Getting Started

### Prerequisites
- Visual Studio 2022 or later
- .NET 6 SDK or later
- Basic understanding of C# and RESTful APIs

---

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/todo-list-api.git
   cd todo-list-api
2. Open the project in Visual Studio.

Restore dependencies:

dotnet restore

dotnet run
Navigate to Swagger UI:

https://localhost:<port>/swagger
API Endpoints

Base URL
https://localhost:<port>/api/todo

Endpoints
1. Get All To-Do Items
GET /api/todo
Response:

json
    {
        "id": 1,
        "title": "Learn ASP.NET Core",
        "isCompleted": false
    }


2. Get a Single To-Do Item
GET /api/todo/{id}
Response:
{
    "id": 1,
    "title": "Learn ASP.NET Core",
    "isCompleted": false
}
3. Create a New To-Do Item
POST /api/todo
Body:
{
    "title": "Learn Swagger",
    "isCompleted": false
}
Response:
{
    "id": 2,
    "title": "Learn Swagger",
    "isCompleted": false
}
4. Update an Existing To-Do Item
PUT /api/todo/{id}
Body:
{
    "id": 2,
    "title": "Learn Swagger in-depth",
    "isCompleted": true
}
Response:
204 No Content

5. Delete a To-Do Item
DELETE /api/todo/{id}

Response:
204 No Content
   
# Technologies Used
ASP.NET Core: Backend framework
Swagger: API documentation and testing
Entity Framework Core: In-memory database for development
Future Improvements
Implement a persistent database (e.g., SQL Server or PostgreSQL).
Add user authentication and authorization.
Deploy to a cloud platform (e.g., Azure, AWS).

# License
This project is licensed under the MIT License.

Contributing
Contributions are welcome! Feel free to open issues or submit pull requests for improvements.

# Acknowledgments
Microsoft Documentation
Swagger/OpenAPI
Entity Framework Core

Author
JpUnique
https://github.com/JpUnique/













