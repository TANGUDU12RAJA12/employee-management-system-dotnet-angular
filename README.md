# Employee Management System (.NET 8 + Angular)

This repository contains a full-stack employee management system with:

- **Backend:** ASP.NET Core (.NET 8) Web API
- **Frontend:** Angular 22 standalone components

## Project functionality

The application allows users to manage employee records with standard CRUD operations:

- **Create** new employees
- **Read** employee list and details
- **Update** existing employee data
- **Delete** employees

The frontend displays employees in a responsive list and uses route-based forms for add/edit operations.

## Technology stack

- ASP.NET Core Web API
- Entity Framework Core with SQL Server
- Angular 22
- RxJS
- Tailwind CSS for styling

## Folder structure

- `CurdOperationWithDTO/` — .NET backend project
- `employee/` — Angular frontend project

## How to run

### Backend

1. Open the `CurdOperationWithDTO` folder in Visual Studio or VS Code.
2. Restore NuGet packages and build the project.
3. Run the project to start the Web API.
4. The API is available at `https://localhost:7263/api/Employee`.

### Frontend

1. Open the `employee` folder in a terminal.
2. Install dependencies:
   ```powershell
   npm install
   ```
3. Start the Angular dev server:
   ```powershell
   ng serve --port 4200
   ```
4. Open the app at `http://localhost:4200/`.

## Notes

- The Angular app uses `employee/src/app/service/employees.ts` to call the backend API.
- The employee form supports both add and edit workflows.
- The backend uses DTOs to separate request and response models.

## GitHub

Repository name: `employee-management-system-dotnet-angular`

---

If you want, I can also add a separate `README` section for the API endpoints and sample requests.