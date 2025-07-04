# Fawry Challenge

This is a .NET 8.0 console application that implements an e-commerce system with various product types and shipping capabilities.

## Project Structure

The project consists of the following main components:

### Core Classes

- **Product.cs** - Base product class
- **SimpleProduct.cs** - Basic product implementation
- **ShippableProduct.cs** - Product that can be shipped
- **PerishableProduct.cs** - Product with expiration date
- **PerishableShippableProduct.cs** - Product that is both shippable and perishable

### Shopping System

- **Cart.cs** - Shopping cart implementation
- **CartItem.cs** - Individual items in the cart
- **Customer.cs** - Customer information

### Services

- **CheckoutService.cs** - Handles checkout process
- **ShippingService.cs** - Manages shipping operations
- **IShippable.cs** - Interface for shippable products

## Features

- **Product Management**: Support for different product types (simple, shippable, perishable)
- **Shopping Cart**: Add/remove items, calculate totals
- **Checkout Process**: Complete purchase with shipping options
- **Shipping Integration**: Handle shipping for applicable products
- **Expiration Tracking**: Manage perishable products with expiration dates

## Getting Started

### Prerequisites

- .NET 8.0 SDK or later

### Running the Application

1. Clone the repository
2. Navigate to the project directory
3. Run the application:
   ```bash
   dotnet run
   ```

## Architecture

The project follows object-oriented principles with:

- Inheritance hierarchy for different product types
- Interface-based design for shipping capabilities
- Service-oriented architecture for business logic
- Separation of concerns between different components

## Technologies Used

- C# (.NET 8.0)
- Object-Oriented Programming
- SOLID Principles
