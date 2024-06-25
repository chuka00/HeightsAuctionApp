# Auction Chat Application

This project is an auction chat application built using .NET 8. It enables real-time communication for bidding processes and includes user management, room management, bidding, invoicing, and payment processing.

## Overview

This application is designed to facilitate real-time interactions among users during an auction. Users can enter a bidding room, submit bids, receive real-time notifications, and handle payments via Paystack.

## Design Decisions

1. **Framework**: .NET 6 for robustness and scalability.
2. **Real-time Communication**: SignalR for real-time messaging and notifications.
3. **Database**: SQL Server for reliable data management and Entity Framework Core for ORM.
4. **Payment Gateway**: Paystack for easy payment processing.
5. **Architecture**: Layered architecture with services and controllers, and AutoMapper for entity-to-DTO mapping.

## Project Structure
AuctionChatApp/
│
├── Controllers/
│ ├── BiddingController.cs
│ ├── MessagingController.cs
│ ├── NotificationController.cs
│ ├── RoomController.cs
│ └── UserController.cs
│
├── DTOs/
│ ├── BidDto.cs
│ ├── InvoiceDto.cs
│ ├── MessageDto.cs
│ ├── NotificationDto.cs
│ └── RoomDto.cs
│
├── Entities/
│ ├── Bid.cs
│ ├── Invoice.cs
│ ├── Message.cs
│ ├── Notification.cs
│ ├── Room.cs
│ └── User.cs
│
├── Hubs/
│ └── AuctionHub.cs
│
├── Services/
│ ├── BidService.cs
│ ├── InvoiceService.cs
│ ├── MessagingService.cs
│ ├── NotificationService.cs
│ ├── RoomService.cs
│ └── UserService.cs
│
├── Mappings/
│ └── MappingProfile.cs
│
├── Data/
│ └── ApplicationDbContext.cs
│
├── Program.cs
└── appsettings.json
