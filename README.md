# CSharp Restaurant Management System

**iRestaurant** is a comprehensive restaurant management solution with Point of Sale (POS) functionality built using .NET framework and SQL Server. It offers features for managing categories, products, tables, staff, POS orders, kitchen orders, and much more. The system allows seamless management of orders, customer information, staff roles, and billing, making it easier to operate a restaurant efficiently.

## Features

### 1. **User Authentication**
   - [x] Login page with credential validation
   - [ ] User registration

### 2. **Restaurant Management**
  - [x] **Categories**: Add, edit, delete, and search categories
  - [x] **Products**: Manage products with details like name, image, category, size, price, and more
  - [x] **Tables**: Add, edit, delete, and search tables
  - [x] **Staff**: Manage staff information, roles (manual query-based role management), and status
   
### 3. **Point of Sale (POS)**
  - [x] Order Management: Place orders for **Dine In**, **Take Away**, and **Delivery**
  - [x] Order Details: Select items, categorize orders, and manage payments
  - [x] Order Types: Dynamically manage order types (Dine In, Take Away, Delivery)
  - [x] KOT (Kitchen Order Ticket): Send orders directly to the kitchen
  - [x] Bill Management: View bill history, modify incomplete orders, and apply payments

### 4. **Kitchen**
  - [x] View and manage orders in the kitchen with details like bill number, order time, waiter, and customer info
  - [x] Mark orders as completed and update the POS accordingly

### 5. **Reports**
  - [ ] Sales Reports by category and item-wise
  - [ ] Staff management reports
  - [ ] Menu list report

### 6. **Settings**
  - [ ] Placeholder for future configuration options

## Technologies Used

- .NET Framework 4.7.2
- SQL Server
- Windows Forms

## Usage

1. **Login**: Enter your credentials to access the system (currently manual user management via SQL query)
2. **Manage Restaurant**: Use the sidebar to navigate to different pages such as Categories, Products, Tables, and Staff
3. **Place Orders**: Navigate to the POS page, add items to the order, choose the order type (Dine In, Take Away, or Delivery), and send orders to the kitchen
4. **View Bills**: View, edit, and complete bills in the POS system, and process payments when the order is marked as "Complete"
5. **Kitchen Management**: View and mark orders as completed in the kitchen section
6. **Reports**: (Not yet implemented) View and manage reports for sales, staff, and menu
