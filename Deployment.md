
# Employee Management System - Deployment & Environment Configuration Guide

This document outlines the system requirements, environment configuration, and deployment procedures required to execute the Employee Management System (EMS) application successfully.

---

## 🖥️ 1. Hardware & Software Requirements

### Minimum Hardware
* **Processor:** Intel Core i3 (or AMD equivalent) @ 2.0 GHz or higher
* **RAM:** 4 GB minimum (8 GB recommended)
* **Storage:** 50 MB of free disk space (for application binaries and local database expansion)

### Software Environment
* **Operating System:** Windows 10 / Windows 11 (64-bit architecture)
* **Framework:** .NET Framework 4.8 or .NET Runtime 8.0 (depending on target build configuration)
* **Database Engine:** Serverless SQLite (Embedded via System.Data.SQLite NuGet dependency)

---

## 🛠️ 2. Database Initialization & Local Server Configuration

The application utilizes an embedded, serverless **SQLite database architecture Engine**. No standalone server installation (such as MS SQL Server or MySQL) is required.

### Connection String Strategy
The database connectivity string uses a **Relative Path** to ensure full application portability across evaluation environments:

```csharp
Data Source=|DataDirectory|\ems.db;
