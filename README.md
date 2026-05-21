# 📊 Employee Management System (EMS)

Welcome to the **Employee Management System**, a secure, highly portable desktop application designed for streamlined organizational administration. This project was engineered and developed as an independent software engineering deliverable.

---

## 🏛️ System Architecture
The application is engineered using a strict **4-Layer Architecture** to enforce a clean separation of concerns, high scalability, and robust maintainability:
1. **Presentation Layer (WinForms):** Provides a responsive, intuitive user interface for administrative staff.
2. **Service Layer (Business Logic):** Validates administrative workflow actions and runs system integrity checks.
3. **Data Access Layer (Repository):** Executes raw SQL statements natively interacting with the database stream via ADO.NET.
4. **Model Layer (Entities):** Defines strongly-typed passive data objects utilized across all runtime scopes.

---

## 🔒 Core Technical Features
* **Portable Persistence:** Utilizes an embedded, serverless **SQLite engine**, packaging the database directly inside a single file (`ems.db`).
* **Cryptographic Security:** Implements industry-standard **BCrypt hashing** for all system user credentials to protect against plaintext credential exposure.
* **Parameterized Inputs:** All SQL statement layers utilize parameter placeholders to totally immunize the system against **SQL Injection attacks**.

---

## 🚀 Getting Started
For complete hardware prerequisites, relative path connection string data, and execution configurations, please refer to our official **[Deployment Guide](./Deployment.md)** file included in this directory.
