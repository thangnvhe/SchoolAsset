# Tangible Asset Management in Private Schools

## 1. Introduction
The "Tangible Asset Management" project is a **web application** built using **ASP.NET MVC**, designed to help private schools track and manage assets and budgets effectively. The system provides key functionalities such as transaction management, asset tracking, budget allocation, and more.

## 2. Key Features
- **Asset Management:**
  - Add, edit, delete assets.
  - Track asset locations in buildings and rooms.
  - Update asset status (good condition, damaged, under maintenance, disposed).

- **Transaction & Budget Management:**
  - Record financial transactions (income/expenses).
  - Allocate budgets for different departments.
  - Monitor budget balance and alert when exceeded.

- **User Roles & Employee Management:**
  - Different access levels for finance, asset management, and maintenance staff.
  - Track transactions made by employees.

## 3. Technologies Used
- **Backend:** ASP.NET MVC (.NET Core 7/8)
- **Frontend:** Razor Views, Bootstrap, jQuery
- **Database:** SQL Server
- **Authentication:** ASP.NET Identity
- **ORM:** Entity Framework Core
- **CI/CD:** GitHub Actions (Optional)
- **Containerization:** Docker (Optional)

## 4. Installation & Setup
### System Requirements
- .NET SDK 7.0+ or 8.0+
- SQL Server (or SQL Express)
- Visual Studio 2022 (Recommended)

### Installation Steps
1. Clone the project:  
   ```sh
   git remote add origin https://github.com/thangnvhe/SchoolAsset.git
   cd AssetManagement
   ```
2. Configure the database in `appsettings.json`:  
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=AssetDB;Trusted_Connection=True;"
   }
   ```
3. Run migrations and update the database:  
   ```sh
   dotnet ef database update
   ```
4. Run the project:  
   ```sh
   dotnet run
   ```
5. Access the web application at `http://localhost:5000`

## 5. User Guide
### Login & Roles
- **Admin:** Manage assets, budgets, transactions, and employees.
- **Finance Department:** Manage transactions, approve expenses, monitor budgets.
- **Maintenance Staff:** Update asset status.

### Asset Management
1. **Add Assets**: Enter details and assign to rooms.
2. **Update Status**: Mark as damaged, under maintenance, or disposed.

### Transaction Management
1. **Record Transactions**: Enter amount, description, and select budget.
2. **View Transaction History**: Search by department and budget.

## 6. Future Development Plan
- [ ] API for transactions & reports
- [ ] Financial report analysis
- [ ] Export reports to PDF/Excel

## 7. Contact Information
- **Author:** [Thangnvhe]
- **Email:** nguyenvanthang08112003@.com
- **GitHub:** [Thangnvhe]
