# EmployeeManagement - Mediator Pattern

## Project Structure

### API Layer
Controllers → EmployeeController.cs

Behaviors → ValidationBehavior.cs

Features
- Employee
  - Commands
    - CreateEmployee
      - CreateEmployeeCommand.cs
      - CreateEmployeeHandler.cs
      - CreateEmployeeValidator.cs

    - UpdateEmployee
      - UpdateEmployeeCommand.cs
      - UpdateEmployeeHandler.cs
      - UpdateEmployeeValidator.cs

    - DeleteEmployee
      - DeleteEmployeeCommand.cs
      - DeleteEmployeeHandler.cs
      - DeleteEmployeeValidator.cs

  - Queries
    - GetEmployee
      - GetEmployeeQuery.cs
      - GetEmployeeHandler.cs
      - GetEmployeeValidator.cs

### DAL Layer
Data → ApplicationDBContext.cs

Entities → Employee.cs

Repository
- IEmployeeRepository.cs
- EmployeeRepository.cs

Mapping → MappingProfile.cs

DTOs
- CreateEmployeeDTO.cs
- UpdateEmployeeDTO.cs

---

## Features Implemented

- Employee CRUD Operations
- REST APIs
- Entity Framework Core
- Mediator Pattern using MediatR
- Request & Handler Separation
- Fluent Validation
- Pipeline Behavior Validation
- Repository Pattern
- Soft Delete Functionality
- SQL Server Integration
- Asynchronous Database Operations
- Clean Architecture Structure
