# ProductionManagementSystem
# Production Planning & Inventory Management System

A web-based inventory and production planning application developed using **ASP.NET Core MVC**, **C#**, **Entity Framework Core**, and **SQL Server**.
This project is designed to help manufacturing companies manage raw material stock, monitor low inventory, and improve production visibility through a dashboard.

---

## 🚀 Features

### 📦 Inventory Management

* Add, edit, delete, and view materials
* Track stock quantity and unit
* Maintain minimum stock levels

### ⚠️ Low Stock Alerts

* Automatically highlights materials below minimum stock
* Helps avoid production stoppages

### 📊 Dashboard

* Total materials count
* Low stock count
* Total stock quantity
* Charts using Chart.js for stock visualization

### 🏭 Production Planning

* Maintain production entry records
* Track product name, quantity produced, and entry date

### 🎨 Responsive UI

* Bootstrap-based modern user interface
* Clean and simple navigation

### 🌐 Deployment

* Published and deployed on IIS
* Connected with SQL Server using Windows Authentication

---

## 🛠 Tech Stack

* ASP.NET Core MVC
* C#
* Entity Framework Core (Code First)
* SQL Server
* HTML
* CSS
* Bootstrap
* JavaScript
* Chart.js
* IIS

---

## 🏗 Architecture

This project follows the **MVC (Model-View-Controller)** pattern:

* **Models** → Represent database entities such as Materials and Production Entries
* **Views** → Razor pages for UI
* **Controllers** → Handle requests and business logic
* **Entity Framework Core** → ORM for database operations

---

## 🗂 Database Tables

### Materials

* Id
* MaterialName
* Quantity
* Unit
* MinStock

### ProductionEntries

* Id
* ProductName
* QuantityProduced
* EntryDate

---

## ⚙️ Setup Instructions

### 1️⃣ Clone Repository

```bash
git clone https://github.com/Coder-Jimmy45/ProductionManagementSystem.git
```

### 2️⃣ Open in Visual Studio

Open solution file:

```bash
ProductionManagementSystem.sln
```

### 3️⃣ Configure Database

Update `appsettings.json`

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=JIMMY\\SQLEXPRESS;Database=ProductionDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 4️⃣ Apply Migration

```bash
Update-Database
```

### 5️⃣ Run Project

Press:

```bash
Ctrl + F5
```

---

## 🌍 IIS Deployment

1. Publish project from Visual Studio
2. Create website in IIS
3. Set physical path to published folder
4. Configure SQL Server access
5. Browse on localhost

---

## 🎯 Future Enhancements

* Login / Authentication
* Role-based access
* Purchase Request Module
* Excel Export
* Email Alerts
* Vendor Management

---

## 👨‍💻 Author

Developed by Abhinash Mahanta

---

## ⭐ If you like this project

Please star this repository.
