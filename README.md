[README (1).md](https://github.com/user-attachments/files/27275487/README.1.md)

# 🍎 Food Cycle: Surplus Food Management System
**University:** Mansoura University  
**Faculty:** Computers and Information  
**Course:** Object-Oriented Programming (OOP)  
**Academic Year:** 2025-2026

---

## 📝 Project Abstract
**Food Cycle** is a specialized C# Windows Forms application aimed at reducing food waste by bridging the gap between surplus food providers (like restaurants and hotels) and charity organizations. The system ensures that edible surplus food is safely and efficiently redistributed to those in need through a structured validation process managed by system administrators.

---

## 🏗️ System Architecture & OOP Implementation

### 1. Class Hierarchy (Inheritance)
The project utilizes **Inheritance** to manage different user types efficiently:
* **Base Class `User`:** Contains shared attributes like `Username`, `Password`, and `Role`.
* **Derived Class `Admin`:** Inherits from `User` with system-wide management privileges.
* **Derived Class `Organization`:** Inherits from `User` and adds specialized fields like `Address`, `Phone`, and `Email`. 

### 2. Data Persistence (File Handling)
To satisfy the course requirements for data persistence without external databases, we implemented a robust **File Handling** system using `.txt` files. This system handles reading, writing, and updating records for both users and food donations dynamically.

### 3. Core Features
* **Encapsulation:** Ensuring data integrity by using private fields and public properties.
* **Enums:** Implementing typed constants for `UserRole` and `DonationStatus`.
* **Input Validation:** Extensive use of **Exception Handling** (Try-Catch) to ensure a crash-free experience.

---

## 👥 Team Members
* **Moaz Hesham** (Team Leader)
* **Mostafa Asaad**
* **Mostafa Alaa**
* **Malak Abou El-Magd**
* **Malak Sherif**
* **Hagar Soliman**

---

## 🛠️ Built With
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **IDE:** Visual Studio 2022
* **Version Control:** Git & GitHub
