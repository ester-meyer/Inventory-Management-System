# Inventory Management System (WinForms, C#)

A desktop application for managing a small retail store, built in C# using WinForms and structured according to the 3-layer architecture:  
**Data Access Layer (DAL)**, **Business Logic Layer (BL)**, and **Presentation Layer (UI)**.  
Data is stored locally using XML files.

## Overview

This system provides tools for both **cashiers** and **store managers**:

- Cashiers can register purchases and view product information.
- Managers can manage products, customers, and promotions with full CRUD operations.
- Sales reports and basic analytics are available to store managers.
- All data is saved in XML format for portability and simplicity.

## Technologies Used

- C# (.NET Framework)
- WinForms
- XML file storage
- Visual Studio IDE

## Project Architecture

The system is built using a modular 3-layer architecture:

### Data Access Layer (DAL)
- `DAL/IDal.cs`  
- `DAL/DalXml.cs`  
- `DAL/data/products.xml`  
- `DAL/data/sales.xml`  
- `DAL/data/users.xml`  

### Business Logic Layer (BL)
- `BL/IBl.cs`  
- `BL/Bl.cs`  
- `BL/Entities/Product.cs`  
- `BL/Entities/Sale.cs`  
- `BL/Entities/User.cs`  

### Presentation Layer (UI)
- `UI/MainForm.cs`  
- `UI/CashierForm.cs`  
- `UI/ManagerForm.cs`  
- `UI/AddProductForm.cs`  
- `UI/ViewReportsForm.cs`  

### Other
- `Program.cs`  
- `README.md`  

## Contributors

- **Mindy Meir**  
- **Yehudit Alper**  
*(Full collaboration on all aspects of the project: architecture, logic, and UI)*

## Notes

- This application was developed as part of a software engineering academic project.
- The system can be extended to support additional features such as database integration, advanced reporting, and more user roles.
