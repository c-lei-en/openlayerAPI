using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using openlayerAPI.Authorization.Roles;
using openlayerAPI.Authorization.Users;
using openlayerAPI.MultiTenancy;
using openlayerAPI.Mountains;
using openlayerAPI.Palaces;
using openlayerAPI.FamousPeoples;
using openlayerAPI.Dynastys;
using openlayerAPI.Registers;

namespace openlayerAPI.EntityFrameworkCore
{
    public class openlayerAPIDbContext : AbpZeroDbContext<Tenant, Role, User, openlayerAPIDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Mountain> Mountains { get; set; }
        public DbSet<Palace> Palaces { get; set; }
        public DbSet<FamousPeople> FamousPeoples { get; set; }
        public DbSet<Dynasty> Dynastys { get; set; }
        public DbSet<Register> Registers { get; set; }
        public openlayerAPIDbContext(DbContextOptions<openlayerAPIDbContext> options)
            : base(options)
        {
        }
       
    }
}
