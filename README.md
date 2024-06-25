# Auction Chat Application

This project is an auction chat application built using .NET 8. It enables real-time communication for bidding processes and includes user management, room management, bidding, invoicing, and payment processing.

## Overview

This application is designed to facilitate real-time interactions among users during an auction. Users can enter a bidding room, submit bids, receive real-time notifications, and handle payments via Paystack.

## Design Decisions

1. **Framework**: .NET 8 for robustness and scalability.
2. **Real-time Communication**: SignalR for real-time messaging and notifications.
3. **Database**: SQL Server for reliable data management and Entity Framework Core for ORM.
4. **Payment Gateway**: Paystack for easy payment processing.
5. **Architecture**: Layered architecture with services and controllers, and AutoMapper for entity-to-DTO mapping.

## Setup Instructions

### Prerequisites

- .NET 8 SDK
- SQL Server
- Paystack account

### Step-by-Step Setup

1. **Clone the Repository**:
    ```bash
    git clone https://github.com/chuka00/HeightsAuctionApp.git
    cd auction-chat-app
    ```

2. **Database Setup**:
    - Update the connection string in `appsettings.json` to point to your SQL Server instance:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_username;Password=your_password;"
      }
    }
    ```
    - Run the database migrations to set up the database schema:
    ```bash
    dotnet ef database update
    ```

3. **Configure Paystack**:
    - Update the Paystack configuration in `appsettings.json`:
    ```json
    {
      "Paystack": {
        "SecretKey": "your_paystack_secret_key"
      }
    }
    ```

4. **Run the Application**:
    ```bash
    dotnet run
    ```

## Services

1. **User Service**:
    - Handles user-related operations such as registration and authentication.

2. **Room Service**:
    - Manages auction rooms where users can join and participate in auctions.

3. **Bid Service**:
    - Handles bid submissions and tracks the highest bid in real-time.

4. **Invoice Service**:
    - Generates invoices for the highest bidder once the auction ends.

5. **Payment Service**:
    - Processes payments using Paystack and updates the auction status upon successful payment.

