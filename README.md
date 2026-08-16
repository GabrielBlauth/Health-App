# Health App

**Author:** Gabriel Blauth de Araujo

## About

A role-based healthcare management web application built to practice ASP.NET Core Identity, authentication/authorization, and relational data modeling in a realistic scenario. The system supports three distinct user roles — Admin, Doctor, and Patient — each with a different view and level of access, and models a many-to-many relationship between doctors and their assigned patients.

## Features

### As Admin
- View a full list of all registered doctors
- View a full list of all registered patients
- Inspect the currently authenticated user's identity claims (role, email, security stamp) — included to demonstrate how ASP.NET Core Identity represents an authenticated user under the hood

### As Doctor
- View assigned patients

### As Patient
- View assigned doctor

## Tech Stack
- **Framework:** ASP.NET Core Razor Pages (.NET)
- **Authentication:** ASP.NET Core Identity, with role-based authorization (Admin / Doctor / Patient)
- **Database:** SQL Server (LocalDB for local development), via Entity Framework Core
- **Data model:** `DoctorPatient` join entity modeling the many-to-many relationship between doctors and patients
- **Seed data:** roles, an admin account, and sample doctor/patient pairs are seeded automatically on first run

## Getting Started

1. Clone the repository
2. Make sure SQL Server LocalDB is installed and running:
   ```
   sqllocaldb start mssqllocaldb
   ```
3. Set **HealthApp.Razor** as the Startup Project (it's the only executable project in the solution — `HealthApp.Domain` is a class library and can't be run directly)
4. Apply migrations to create the database, via Package Manager Console:
   ```
   Update-Database
   ```
5. Run the project (F5). Roles and demo accounts (below) are created automatically the first time the app runs.

## Demo Credentials (for testing/evaluation)

All seeded accounts share the same password: **`Letmein01*`**

| Role | Email |
|---|---|
| Admin | `admin@healthapp.com` |
| Doctor | `doctor01@healthapp.com` |
| Patient | `patient01@healthapp.com` (assigned to doctor01) |
| Doctor | `doctor02@healthapp.com` |
| Patient | `patient02@healthapp.com` (assigned to doctor02) |

Log in as **Admin** to see the full doctor and patient lists at once. Log in as **Doctor** or **Patient** to see the role-scoped view.

## Known Limitations

This was built as an academic exercise, not a production system:
- Demo credentials above are seeded intentionally for testing/evaluation and should never be used as a real authentication pattern
- Password is shared across all seed accounts for convenience — a production system would enforce unique, securely generated credentials per user
- No password reset / email confirmation flow is wired up (Identity is configured but simplified for this scope)
