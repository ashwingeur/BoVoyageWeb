﻿using BoVoyageWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoVoyageWeb.Data
{
    public class BoVoyageDbContext : DbContext
    {
        public BoVoyageDbContext() : base("BoVoyageConnectionString")
        {
        }

        public DbSet<AgenceVoyage> AgenceVoyages { get; set; }
        public DbSet<Assurance> Assurances { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<DossierReservation> DossierReservations { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Voyage> Voyages { get; set; }

    }
}