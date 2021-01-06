namespace shopping_basket.Migrations
{
    using shopping_basket.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<shopping_basket.Model.store.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "shopping_basket.Model.store.Context";
        }

        protected override void Seed(shopping_basket.Model.store.Context context)
        {
            var categories = new List<Brand>
            {
                new Brand{Name ="Subaru"},
                new Brand{Name ="Mercedes"},
                new Brand{Name ="Nissan"},
                new Brand{Name ="SRT"},
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Products>
    {
                new Products{Name="Dodge Challenger",Description="American Muscle",Price=20040,CategoryID = categories.Single(b=>b.Name=="SRT").ID},
                new Products{Name="Dodge Charger",Description="American Muscle",Price=12040,CategoryID = categories.Single(b=>b.Name=="SRT").ID},
                new Products{Name="G-Class",Description="Luxury Suv",Price=120040,CategoryID = categories.Single(b=>b.Name=="Mercedes").ID},
                new Products{Name="SLR McLaren",Description="Sports Car",Price=90040,CategoryID = categories.Single(b=>b.Name=="Mercedes").ID},
                new Products{Name="Impreza Premium",Description="Sedan",Price=50040,CategoryID = categories.Single(b=>b.Name=="Subaru").ID},
                new Products{Name="Legacy Outback",Description="Station Wagon",Price=70040,CategoryID = categories.Single(b=>b.Name=="Subaru").ID},
                new Products{Name="GTR-Nissmo",Description="Luxury Sports Car",Price=1520040,CategoryID = categories.Single(b=>b.Name=="Nissan").ID},
                new Products{Name="Dodge Viper",Description="American Muscle, Sports Car",Price=320040,CategoryID = categories.Single(b=>b.Name=="SRT").ID},
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();




        }
    }
}
