using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VuHongNgocBTH2.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<VuHongNgocBTH2.Models.CompanyVHN069> CompanyVHN069 { get; set; } = default!;

        public DbSet<VuHongNgocBTH2.Models.VHN069> VHN069 { get; set; } = default!;
    }
