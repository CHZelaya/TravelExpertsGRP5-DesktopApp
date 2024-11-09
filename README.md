# TravelExpertsGRP5-DesktopApp

## To Do List - Project Workshop 3 (Current Group Focus)

### Form 1: Travel Packages Management
#### Assigned to : Daryl
(✅ - Copy/paste the checkmark as you finish tasks) 
- ❌ Implement CRUD functionality for travel packages.
- ❌ Create a user-friendly interface for adding, editing, and deleting packages.
- ❌ Add functionality to select products from a product list to associate with packages.
- ❌ Implement search functionality to filter displayed packages.

### Form 2: Agents and Agencies Management
#### Assigned to : Carlos
(✅ - Copy/paste the checkmark as you finish tasks)
- ❌ Create an admin user interface for managing agents and agencies.
- ❌ Implement CRUD functionality for agents and agencies.
- ❌ Add search functionality to filter agents and agencies displayed.

### Form 3: Products and Suppliers Management
#### Assigned to : Sal
(✅ - Copy/paste the checkmark as you finish tasks)
- ❌ Develop a user interface for maintaining products and suppliers.
- ❌ Implement CRUD functionality for products and suppliers.
- ❌ Create functionality for managing product_suppliers data.
- ❌ Add search functionality to filter products and suppliers displayed.

### Validation Tasks
#### Assigned to : Cantor
(✅ - Copy/paste the checkmark as you finish tasks)
- ❌ Implement data validation for travel packages:
  - Agency Commission cannot exceed Base Price.
  - Package End Date must be later than Package Start Date.
  - Package Name and Package Description cannot be null.
- ❌ Implement data validation for agents and agencies.
- ❌ Implement data validation for products and suppliers.

---

## Description
The Travel Experts Application is a C#.NET Windows Forms application designed to help employees of Travel Experts manage data stored in their SQL Server database. The application provides a graphical interface for viewing and modifying essential data related to travel packages, agents, agencies, products, and suppliers.

## Features
- **CRUD Operations**: Add, edit, delete, and view travel packages, agents, and agencies.
- **Data Validation**: Ensure data integrity with various validation checks.
- **Search Functionality**: Filter displayed data based on user input.
- **User Management**: Admin users can perform CRUD operations on agents and agencies.

## Database Tables
The application will utilize the following tables:
1. Packages
2. Products
3. Products_suppliers
4. Suppliers
5. Packages_products_suppliers
6. Agents
7. Agencies

## Usage
To use the application, launch the executable and navigate through the user interface to manage travel packages, agents, and agencies. Ensure that all required fields are filled out correctly to avoid validation errors.


# Project Workshop 4 
### (To be done after completion of Project Workshop 3)

## Customer Management System

### Summary
In a previous phase of the Travel Experts project, web pages were developed to interact with a Node.js backend. This workshop focuses on recreating those pages using C# and ASP.NET Core. The goal is to build a robust customer management system that allows for user sign-up, login, and management of travel products. The transition from Node.js to ASP.NET Core will leverage the strengths of the .NET framework, providing a more integrated and scalable solution for handling customer data and interactions.

### Form 1: Customer Sign-Up and Validation
(✅ - Copy/paste the checkmark as you finish tasks)

❌ Recreate the customer sign-up page to send form data to an ASP.NET page for verification.  
❌ Ensure all required fields are filled in (business phone is optional).  
❌ Validate that the postal code follows the correct Canadian format.  
❌ Ensure the phone number consists of numeric digits and includes an area code.  
❌ Verify that the password is entered twice and both entries match.  
❌ Allow the agent ID to be null when creating a customer record.  

### Form 2: Customer Login and Data Update
(✅ - Copy/paste the checkmark as you finish tasks)

❌ Enhance the customer sign-up page to enable customers to log in.  
❌ Implement user ID and password authentication.  
❌ Allow customers to modify their personal information after logging in.  

### Form 3: Travel Product Listing
(✅ - Copy/paste the checkmark as you finish tasks)

❌ Design a page that enables customers to view the travel products they have purchased.  
❌ Display a price breakdown listing the cost of each package.  
❌ Calculate and show the total cost owing for the purchased products.  

### Form 4: Customer Payment Simulation
(✅ - Copy/paste the checkmark as you finish tasks)

❌ Simulate customer payments using a virtual wallet/card system.  
❌ Associate a credit balance with each customer for payment towards packages.  
❌ Implement a feature that allows customers to use their virtual balance for transactions.  

### Validation Tasks
(✅ - Copy/paste the checkmark as you finish tasks)

❌ Implement data validation for customer sign-up and login.  
❌ Ensure that all validations are user-friendly and provide appropriate error messages.  
❌ Verify that all implemented validations work as expected in the application.  

## Contributions
Each team member is encouraged to contribute to the project. Please document your contributions and workflow in the provided documentation file.

## Deliverables
1. **Source Code**: The project files should be zipped into one file, clearly named to indicate the workshop module and your name.
2. **Documentation File**: A README that provides details of each team member’s contribution and the workflow of the project.

## Evaluation Criteria
The project will be evaluated based on:
- Code neatness and readability.
- Documentation quality.
- Functionality and design of the application.
- Individual contributions to the project.

