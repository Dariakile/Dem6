﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dem6.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TurizmEntities : DbContext
    {
        private static TurizmEntities _context;
        public TurizmEntities()
            : base("name=TurizmEntities")
        {
        }

        public static TurizmEntities GetContext()

        {
            if (_context == null)
                _context = new TurizmEntities();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<HotelComment> HotelComment { get; set; }
        public virtual DbSet<HotelImage> HotelImage { get; set; }
        public virtual DbSet<Tour> Tour { get; set; }
        public virtual DbSet<Type> Type { get; set; }
    }
}
