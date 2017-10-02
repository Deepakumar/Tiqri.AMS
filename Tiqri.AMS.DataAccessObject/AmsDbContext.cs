// <copyright file="AmsDbContext.cs" company="Tiqri Ltd">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Deepakumar</author>
// <date>28/09/2017</date>
// <summary>Represents Entity Framework DBContext</summary>
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiqri.AMS.DataAccessObject.Mappers;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject
{
    public class AmsDbContext : DbContext
    {
        public AmsDbContext() : this ("Tiqri.AMS.ConnectionString"){}
        public AmsDbContext(string nameOrConnectionString) : base(nameOrConnectionString){}

        public IDbSet<AccidentCategory> AccidentCategories { get; set; }
        public IDbSet<Accident> Accidents { get; set; }
        public IDbSet<Witness> Witness { get; set; }
        public IDbSet<Victim> Victims { get; set; }
        public IDbSet<Investigation> Investigations { get; set; }
        public IDbSet<InvestigationAction> InvestigationActions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccidentCategoryMapper());
            modelBuilder.Configurations.Add(new AccidentMapper());
            modelBuilder.Configurations.Add(new WitnessMapper());
            modelBuilder.Configurations.Add(new VictimMapper());
            modelBuilder.Configurations.Add(new InvestigationMapper());
            modelBuilder.Configurations.Add(new InvestigationActionMapper());
        }
    }
}
