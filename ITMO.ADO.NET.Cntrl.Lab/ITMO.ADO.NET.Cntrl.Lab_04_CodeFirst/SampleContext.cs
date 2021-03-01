using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SomeShop;

namespace ITMO.ADO.NET.Cntrl.Lab_04_CodeFirst
{
    public class SampleContext: DbContext
    {
        public SampleContext() : base("SomeShop")
        {
            Database.SetInitializer<SampleContext>(new SampleInitializer());
        }
        public DbSet<Model.Client> Clients { get; set; }
        public DbSet<Model.Order> Orders { get; set; }
    }
    public class SampleInitializer
       : DropCreateDatabaseIfModelChanges<SampleContext>
    {
        protected override void Seed(SampleContext context)
        {
            List<Model.Order> orders = new List<Model.Order>
            {
                new Model.Order()
            };
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
