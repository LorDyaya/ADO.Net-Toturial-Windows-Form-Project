# ADO.NET Contacts Management Windows Forms App

This is a Windows Forms Application built with C# using ADO.NET and SQL Server to perform CRUD Operations on Contacts Data.

The project was developed using the same 3-Tier Architecture used in my Console Application project, which made the application easier to build, organize, and maintain.

---

# Features
- Add New Contact
- Update Contact
- Delete Contact
- Find Contact
- Display Contacts List
- Simple Windows Forms UI
- Database Connectivity using ADO.NET

---

# Technologies Used
- C#
- Windows Forms
- ADO.NET
- SQL Server
- Object-Oriented Programming (OOP)
- 3-Tier Architecture

---

# Database
The database was restored from my local device using SQL Server Management Studio (SSMS).

---

# Project Architecture

This project follows the 3-Tier Architecture design pattern.

## 1. Presentation Layer
This layer contains the Windows Forms UI.

Its responsibility is:
- Handling user interaction
- Displaying data
- Calling methods from the Business Layer

In this project, I only added the Windows Forms code and UI functionality while reusing the same layers and logic from the Console Application project.

---

## 2. Business Layer
This layer contains the application logic.

It includes:
- The `Contact` class
- Business rules
- Save functionality
- Validation and data handling

This layer acts as a bridge between the Presentation Layer and the Data Access Layer.

---

## 3. Data Access Layer
This layer is responsible for:
- Connecting to SQL Server
- Executing SQL commands
- Performing CRUD Operations using ADO.NET

All database operations are managed here.

---

# Why 3-Tier Architecture?

Using 3-Tier Architecture provides many advantages:

- Better code organization
- Easier maintenance
- Reusability of business logic
- Easier debugging and testing
- Separation of concerns
- Ability to reuse the same layers in different applications

For example:
I reused the same Business Layer and Data Access Layer from the Console Application project and only changed the Presentation Layer by adding Windows Forms.

This demonstrates one of the biggest advantages of 3-Tier Architecture.

---

# Final Notes
This project helped me practice:
- Windows Forms Development
- ADO.NET
- CRUD Operations
- SQL Server
- OOP Concepts
- 3-Tier Architecture Design

## Author
Yehia Hamed

> I wish continued success for everyone 
