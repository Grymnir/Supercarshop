using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Supercarshop.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Cheaper cars" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Expensive cars" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Unaffordable cars" });

            //seed pies

            
            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 1,
                Name = "Koeniggseg Agera X",
                Price = 24000000,
                ShortDescription = "Monster",
                LongDescription =
                    "Världens snabbaste personbil!!!",
                CategoryId = 3,
                Weight = 1435,              
                TopSpeed = 439,
                Acceleration = 2.8m,
                ImageUrl = "images/cars/koeniggsegagerax.jpg",
                ImageThumbnailUrl = "images/cars/koeniggsegagerax_tn.jpg",
                InStock = true,
            }) ;

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 2,
                Name = "Buggati Chiron",
                Price = 40000000,
                ShortDescription = "Monster",
                LongDescription =
                         "En bil som bara är ett måste att ha i garaget, en absolut toppbil utan dess like!!!",
                CategoryId = 3,
                Weight = 1996,
                InStock = true,                
                TopSpeed = 491,
                Acceleration = 2.4m,
                ImageUrl = "images/cars/bugattichiron.jpg",
                ImageThumbnailUrl = "images/cars/bugattichiron_tn.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 3,
                Name = "Pagani Zonda",
                Price = 12000000,
                ShortDescription = "Litet Monster",
                LongDescription =
                        "Med sina snygga linjer så är detta bilen man suktar efter, som tagen ur fast and the furious och klonat den med ett rymdskepp!!!",
                CategoryId = 2,
                Weight = 1230,
                InStock = true,              
                TopSpeed = 375,
                Acceleration = 2.5m,
                ImageUrl = "images/cars/paganizonda.jpg",
                ImageThumbnailUrl = "images/cars/paganizonda_tn.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 4,
                Name = "Mclaren 720s",
                Price = 2500000,
                ShortDescription = "Monster",
                LongDescription =
                          "Vill man ha absolut toppklass till superbil men är inte beredd att lägga en halv förmögenhet så är detta bilen för dig med sina tokiga linjer, uppfällbara dörrar samt en acceleration på 0-100 på bara 2,9s!!!",
                CategoryId = 2,
                Weight = 1437,
                InStock = true,
                TopSpeed = 341,
                Acceleration = 2.9m,
                ImageUrl = "images/cars/Mclaren720s.jpg",
                ImageThumbnailUrl = "images/cars/Mclaren720s_tn.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 5,
                Name = "BMW M3",
                Price = 280000,
                ShortDescription = "Ättrig jävel",
                LongDescription =
                          "Extremt rolig och snabb bil, prisvärt alternativ till supersportbilarna",
                CategoryId = 1,
                Weight = 1580,
                InStock = true,
                TopSpeed = 310,
                Acceleration = 4.7m,
                ImageUrl = "images/cars/M3.jpg",
                ImageThumbnailUrl = "images/cars/M3_tn.jpg"
            });



            /*
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our famous apple pies!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""  
            }); */


        }
    }
}
