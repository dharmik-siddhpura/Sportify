# 🏆 Sportify — Sports Inventory Management System

A Windows desktop application built with **C# Windows Forms** and **SQL Server** to manage a sports equipment store's complete inventory, sales, purchases, and staff operations.

---

## 📸 Screenshots

> *(Add screenshots of Login, Dashboard, Products, and Sales screens here)*

---

## ✨ Features

### 🔐 Authentication
- Secure admin login with password visibility toggle

### 📊 Dashboard
- MDI (Multiple Document Interface) layout — manage all modules from a single window
- Quick navigation buttons for core operations

### 📦 Inventory Management
- **Products** — Add, update, and view all sports products
- **Brands** — Manage product brands
- **Categories** — Organize products by category
- **Colors** — Track product color variants
- **Customization** — Handle custom product configurations

### 🛒 Sales & Purchases
- **Sales** — Record and view sales transactions with report generation
- **Purchases** — Track purchase orders from suppliers
- **Purchase View** — Detailed purchase history

### 👥 People Management
- **Customers** — Add and manage customer records
- **Staff** — Manage employee information
- **Suppliers / Dealers** — Maintain supplier directory

### ⚙️ Settings & Configuration
- **Tax** — Configure tax rates
- **Discount** — Set discount rules
- **Payment Methods** — Manage accepted payment types

### 📄 Reports
- View last sale ID from the print button on the Add Sale screen

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Language | C# |
| UI Framework | Windows Forms (.NET Framework) |
| Database | SQL Server (SSMS) |
| Reporting | RDLC / Microsoft Report Viewer |
| IDE | Visual Studio |

---

## ⚙️ Prerequisites

- Windows OS
- [Visual Studio 2019 / 2022](https://visualstudio.microsoft.com/) (with .NET Desktop Development workload)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) + SQL Server Management Studio (SSMS)

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/dharmik-siddhpura/Sportify.git
cd Sportify
```

### 2. Set Up the Database

1. Open **SQL Server Management Studio (SSMS)**
2. Create a new database named `DB_sportify`
3. Import the database backup file located at:
   ```
   Database/Back/DB_sports.mdf
   ```
   Or attach the `.mdf` file directly in SSMS:
   - Right-click **Databases** → **Attach** → Select `DB_sports.mdf`

### 3. Configure the Connection String

Open `sportify/sportify/connectionclass.cs` and update the `Data Source` to match your SQL Server instance name:

```csharp
public string cnstr = "Data Source=YOUR_SERVER_NAME;Initial Catalog=DB_sportify;Integrated Security=True";
```

> To find your server name: Open SSMS → the server name shown in the login dialog is what you need.

### 4. Open & Run the Project

1. Open `sportify/sportify.sln` in Visual Studio
2. Build the solution: `Ctrl + Shift + B`
3. Run the application: `F5`

---

## 🔑 Login Credentials

| Field | Value |
|---|---|
| Username | `admin` |
| Password | `admin` |

---

## 📁 Project Structure

```
Sportify/
├── images/                          # Branding & logo assets
├── Database/
│   └── Back/
│       └── DB_sports.mdf            # SQL Server database backup
└── sportify/
    └── sportify/
        ├── connectionclass.cs       # Database connection handler
        ├── login.cs                 # Login form
        ├── dashboard.cs             # Main MDI dashboard
        ├── frmproduct.cs            # Product management
        ├── frmsales.cs              # Sales management
        ├── frmpurchase.cs           # Purchase management
        ├── frmcustomer.cs           # Customer management
        ├── frmstaff.cs              # Staff management
        ├── frmsupplier.cs           # Supplier management
        ├── frmbrand.cs              # Brand management
        ├── frmcategory.cs           # Category management
        ├── frmcolor.cs              # Color management
        ├── frmdiscount.cs           # Discount management
        ├── frmtax.cs                # Tax management
        ├── frmpaymentmethod.cs      # Payment method management
        ├── frmcustomization.cs      # Customization management
        ├── rptsales.rdlc            # Sales report definition
        └── sportify.csproj          # Project file
```

---

## 👨‍💻 Developer

**Dharmik Siddhpura**
- GitHub: [@dharmik-siddhpura](https://github.com/dharmik-siddhpura)
- LinkedIn: [dharmik-siddhpura](https://www.linkedin.com/in/dharmik-siddhpura/)
- Email: dharmiksiddhpura02@gmail.com
