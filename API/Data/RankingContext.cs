#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_RankHub.Models;

    public class RankingContext : DbContext
    {
        public RankingContext (DbContextOptions<RankingContext> options)
            : base(options)
        {
        }

        public DbSet<API_RankHub.Models.Ranking> Ranking { get; set; }
    }
