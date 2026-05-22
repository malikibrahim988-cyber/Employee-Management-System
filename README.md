# Employee Management System (EMS)

> A role-based desktop application for managing employee records, attendance, departmental categories, and organizational announcements — built with C# Windows Forms and SQLite.

---

## Overview

The Employee Management System (EMS) is a standalone desktop application developed as part of the Visual Programming (CS-412) course at the University of Agriculture Faisalabad. It provides a clean, role-sensitive interface for two types of users: **Administrators** and **Employees**.

---

## Features

### Administrator
- 🔐 Secure login with BCrypt password hashing
- 👥 Full CRUD operations on Employee records (Add, Update, Delete, Search)
- 🗂️ Department Category management — dynamically linked to employee forms
- 📢 Broadcast announcements to all Employees
- 📋 View complete attendance logs

### Employee
- 🔐 Secure login with first-time Profile Setup
- 👤 View personal profile (name, department, role)
- 📣 Read latest management announcements
- ✅ Daily attendance check-in with duplicate prevention

---

## Technology Stack

| Component | Technology |
|-----------|-----------|
| Language | C# (.NET 8) |
| UI Framework | Windows Forms (WinForms) |
| Database | SQLite (embedded, serverless) |
| Data Access | ADO.NET — Repository Pattern |
| Security | BCrypt.Net-Next (password hashing) |
| IDE | Visual Studio 2022 |
| Version Control | Git / GitHub |

---

## Architecture

The project follows a **4-Layer Architecture**:

```
┌─────────────────────────────────────┐
│        Layer 1 — Forms              │  LoginForm, DashboardForm,
│        (Presentation Layer)         │  EmployeeForm, PortalForm...
├─────────────────────────────────────┤
│        Layer 2 — Services           │  PasswordHelper (BCrypt)
│        (Business Logic Layer)       │  Input Validation, Role Logic
├─────────────────────────────────────┤
│        Layer 3 — Repository         │  EmployeeRepository,
│        (Data Access Layer)          │  UserRepository, CategoryRepository
├─────────────────────────────────────┤
│        Layer 4 — Database           │  DbConnection, DbInitializer,
│        (Data Layer)                 │  ems.db (SQLite)
└─────────────────────────────────────┘
```

---

## Database

The application uses an embedded SQLite database (`ems.db`) with 5 tables:

- `Users` — authentication and profile data
- `Employees` — HR records (name, salary, department, role)
- `Categories` — departmental category definitions
- `Attendance` — daily check-in records
- `Announcements` — broadcast messages from Admin

---

## Getting Started

### Prerequisites
- Windows 7/10/11
- [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022 (if building from source)

### Run the Application
```bash
# Clone the repository
git clone https://github.com/YOUR_USERNAME/EmployeeManagementSystem.git

# Open in Visual Studio 2022
# Build and run with F5
```

For full setup instructions, see [DEPLOYMENT.md](DEPLOYMENT.md)

---

## Default Login Credentials

| Role | Username | Password |
|------|----------|----------|
| Administrator | admin | admin123 |
| Employee | employee | emp123 |

---

## Project Structure

```
Employee Management/
├── Forms/              # Presentation Layer — all WinForms
├── Services/           # Business Logic — PasswordHelper (BCrypt)
├── Repository/         # Data Access — repository classes
├── Database/           # DbConnection, DbInitializer
├── Models/             # Entity models (Employee, User, Category)
├── ems.db              # SQLite database
└── Program.cs          # Entry point
```

---

## Screenshots

> *(Screenshots of Login Form, Dashboard, Employee Management, Employee Portal)*

---

## Developer

**Muhammad Ibrahim**  
Roll No: 2024-ag-5302  
BS Computer Science — University of Agriculture Faisalabad  
Course: Visual Programming (CS-412)  
Supervisor: Dr. Qamar Nawaz
