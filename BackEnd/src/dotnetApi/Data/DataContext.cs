﻿using dotnetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}
