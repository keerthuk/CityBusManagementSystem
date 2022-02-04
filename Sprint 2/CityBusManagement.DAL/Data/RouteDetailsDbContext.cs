using CityBusManagement.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagement.DAL.Data
{
    public class RouteDetailsDbContext : DbContext
    {
        public RouteDetailsDbContext(DbContextOptions<RouteDetailsDbContext> options) : base(options) { 
        }
        public DbSet<RouteDetails> routedetails { get; set; }
        

    }
}
