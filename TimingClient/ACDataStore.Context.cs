﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimingClient
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AsettoCorsaTrackingEntities : DbContext
    {
        public AsettoCorsaTrackingEntities()
            : base("name=AsettoCorsaTrackingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<Lap> Lap { get; set; }
    }
}
