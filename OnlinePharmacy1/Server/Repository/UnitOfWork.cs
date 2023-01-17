using OnlinePharmacy1.Server.Data;
using OnlinePharmacy1.Server.IRepository;
using OnlinePharmacy1.Server.Models;
using OnlinePharmacy1.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlinePharmacy1.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Consultation> _consultations;
        private IGenericRepository<Medication> _medications;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<OrderItem> _orderitems;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Staff> _staffs;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Consultation> Consultations
            => _consultations ??= new GenericRepository<Consultation>(_context);
        public IGenericRepository<Medication> Medications
            => _medications ??= new GenericRepository<Medication>(_context);
        public IGenericRepository<Order> Orders
            => _orders ??= new GenericRepository<Order>(_context);
        public IGenericRepository<OrderItem> OrderItems
            => _orderitems ??= new GenericRepository<OrderItem>(_context);
        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            //foreach (var entry in entries)
            //{
            //    ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
            //    ((BaseDomainModel)entry.Entity).UpdatedBy = user;
            //    if (entry.State == EntityState.Added)
            //    {
            //        ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
            //        ((BaseDomainModel)entry.Entity).CreatedBy = user;
            //    }
            //}

            await _context.SaveChangesAsync();
        }
    }
}