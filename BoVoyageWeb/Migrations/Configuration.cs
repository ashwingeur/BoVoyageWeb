﻿using BoVoyageWeb.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BoVoyageWeb.Migrations
{
    public class Configuration : DbMigrationsConfiguration<BoVoyageDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

    }
}