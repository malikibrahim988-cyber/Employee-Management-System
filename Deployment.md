# Deployment Guide — Employee Management System (EMS)

## System Requirements

| Component | Requirement |
|-----------|-------------|
| Operating System | Windows 7, 8, 10, or 11 (64-bit recommended) |
| Runtime | .NET 8 Desktop Runtime (Windows) |
| Disk Space | Minimum 100 MB free |
| RAM | Minimum 2 GB |
| Display | Minimum 1024×768 resolution |

---

## Prerequisites — Step by Step

### Step 1: Install .NET 8 Desktop Runtime

1. Visit: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
2. Under **.NET Desktop Runtime 8.x**, click **Download** for your system (x64 recommended)
3. Run the installer and follow the on-screen instructions
4. Verify installation by opening Command Prompt and running:
   ```
   dotnet --version
   ```
   You should see a version number starting with `8.`

---

## Running the Application

### Option A — Run the Executable (Recommended)

1. Extract the ZIP file to any folder on your machine
2. Navigate to:
   ```
   EmployeeManagementSystem\bin\Release\net8.0-windows\
   ```
3. Double-click **EMS.exe** to launch the application
4. The database (`ems.db`) is bundled and will initialize automatically on first run

### Option B — Build and Run from Source (Visual Studio)

1. Install **Visual Studio 2022** (Community Edition is free):
   https://visualstudio.microsoft.com/vs/community/
   - During installation, select the workload: **.NET Desktop Development**

2. Open the solution:
   - Navigate to the extracted project folder
   - Double-click **Employee Management.sln**

3. Restore NuGet packages:
   - In Visual Studio, go to **Tools → NuGet Package Manager → Manage NuGet Packages for Solution**
   - Click **Restore** if prompted, or packages restore automatically on build

4. Set the startup project:
   - In Solution Explorer, right-click **Employee Management** → **Set as Startup Project**

5. Run the application:
   - Press **F5** (Debug) or **Ctrl+F5** (Run without debugging)

---

## Database Setup

The application uses an embedded **SQLite** database (`ems.db`).

- **No installation required** — SQLite is bundled via NuGet (System.Data.SQLite)
- The database file is located at the **project root** alongside the `.csproj` file
- Visual Studio build setting is configured as **Copy if Newer**, so `ems.db` is automatically copied to the output directory on every build
- On first launch, `DbInitializer` automatically creates any missing tables
- The included `ems.db` file contains the complete schema and is ready to use immediately

### Default Login Credentials

| Role | Username | Password |
|------|----------|----------|
| Administrator | admin | admin123 |
| Employee | employee | emp123 |

> **Note:** You can register additional accounts directly from the Login Form using the Register button.

---

## NuGet Dependencies

These packages are restored automatically by Visual Studio or `dotnet restore`:

| Package | Version | Purpose |
|---------|---------|---------|
| System.Data.SQLite | Latest | SQLite database connectivity |
| BCrypt.Net-Next | Latest | Password hashing and verification |

---

## Troubleshooting

| Problem | Solution |
|---------|----------|
| App won't launch | Ensure .NET 8 Desktop Runtime is installed |
| Database error on startup | Make sure `ems.db` is in the same folder as `EMS.exe` |
| NuGet packages missing | Run `dotnet restore` in the project folder or restore via Visual Studio |
| Login fails | Use the default credentials above or register a new account |
| Path too long error | Extract the ZIP to a short path like `C:\EMS\` |

---

## Project Structure

```
Employee Management/
├── Employee Management.sln
├── Employee Management/
│   ├── Forms/              # All Windows Forms (UI Layer)
│   ├── Services/           # Business logic — PasswordHelper (BCrypt)
│   ├── Repository/         # Data access — all repository classes
│   ├── Database/           # DbConnection, DbInitializer
│   ├── Models/             # Entity model classes
│   ├── ems.db              # SQLite database file
│   └── Program.cs          # Application entry point
```

---

## Contact

**Developer:** Muhammad Ibrahim  
**Roll No:** 2024-ag-5302  
**Program:** BS Computer Science — University of Agriculture Faisalabad  
**Course:** Visual Programming (CS-412)
