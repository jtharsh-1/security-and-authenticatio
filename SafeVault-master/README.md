# SafeVault - Secure Web Application

## Project Overview
SafeVault is a secure ASP.NET Core Web API application designed to safely manage sensitive information.
The application demonstrates **secure coding practices**, including input validation, SQL injection prevention, authentication, authorization, role-based access control (RBAC), and encrypted storage of sensitive data.

This project consolidates activities from secure code generation, authentication implementation, and vulnerability debugging, forming a complete, secure application ready for review.

---

## Features

- **User Management**
  - Registration and login using ASP.NET Identity
  - Email confirmation before account activation
  - Passwords securely hashed
- **Role-Based Access Control (RBAC)**
  - Roles: `Admin` and `User`
  - Restrict endpoints such as `/admin-dashboard` to Admins
- **Vault Management**
  - Secure storage of sensitive Vault items
  - AES encryption for data at rest
- **Security Enhancements**
  - Input validation and parameterized queries
  - Protection against SQL injection and XSS
  - JWT-based stateless authentication for API endpoints

---

## Technologies Used

- **Framework:** ASP.NET Core 6/7
- **ORM:** Entity Framework Core
- **Authentication:** ASP.NET Identity
- **Database:** SQL Server
- **Testing:** xUnit
- **Version Control:** Git & GitHub
- **IDE:** Visual Studio Code

---

## Security Implementation Details

| Security Aspect | Implementation |
|-----------------|----------------|
| Input Validation | Copilot-generated code to sanitize user inputs |
| SQL Injection Prevention | Parameterized queries and EF Core LINQ methods |
| Authentication | ASP.NET Identity with hashed passwords |
| Authorization | Role-based policies for Admin/User access |
| Claims & Roles | `User` class extended for claims (Department) |
| Data Encryption | AES encryption for Vault items |
| API Security | JWT authentication and middleware validation |
| Vulnerability Fixes | Reviewed and resolved SQLi and XSS vulnerabilities |

---

## Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/<your-username>/SafeVault-SecureApp.git
   cd SafeVault-SecureApp
