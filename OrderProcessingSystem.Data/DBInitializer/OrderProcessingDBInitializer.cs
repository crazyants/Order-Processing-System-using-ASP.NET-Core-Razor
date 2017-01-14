﻿using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Data.DBInitializer
{
    /// <summary>
    /// Custom DB initializer. This will seed data.
    /// </summary>
    public class OrderProcessingDBInitializer : CreateDatabaseIfNotExists<OrderProcessingDbContext>
    {
        /// <summary>
        /// Seed items
        /// </summary>
        /// <param name="context">DBContext</param>
        protected override void Seed(OrderProcessingDbContext context)
        {
            SeedOrders(context);
            SeedClient(context);
            base.Seed(context);
        }

        private void SeedOrders(OrderProcessingDbContext context)
        {
            context.Orders.Add(new Order
            {
                Name = "Hoodie",
                Description = "25 hoodies required for Mphasis",
                LastUpdated = DateTime.Now.AddDays(-15)
            });

            context.Orders.Add(new Order
            {
                Name = "Table Cloth",
                Description = "100 Table Cloth required for Larsen & Toubro Infotech",
                LastUpdated = DateTime.Now.AddDays(-1)
            });

            context.Orders.Add(new Order
            {
                Name = "T-Shirt",
                Description = "1000 T-Shirt required for ALTEN Calsoft Labs",
                LastUpdated = DateTime.Now.AddDays(-60)
            });

            context.Orders.Add(new Order
            {
                Name = "Banner",
                Description = "10 Banner required for Aftek",
                LastUpdated = DateTime.Now.AddDays(-2)
            });
        }

        private void SeedClient(OrderProcessingDbContext context)
        {
            context.Clients.Add(new Client
            {
                FirstName = "Abhishek",
                LastName = "Goenka",
                ClientType = "Individual",
                ContractDate = DateTime.Now.AddYears(-5),
                Email = "abhishek@nblog.in",
                Phone = "9008719714",
                Notes = "Test Notes",
                CompanyName = "No Company",
                BillingAddress = new Address {Id = 1, Street = "ABV", City = "Bangalore", State = "Karnataka", Zip = "560102"},
                MailingAddress = new Address {Id = 2, Street = "ABV", City = "Bangalore", State = "Karnataka", Zip = "560102"},
            });
        }
    }
}