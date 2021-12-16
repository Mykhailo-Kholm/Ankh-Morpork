using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_webapp_MVC.Data.Resources
{
    public class DbContextSeeder
    {
        public static void Seed(NpcContext context)
        {
            Random rnd = new Random();
            var assassins = new List<Assassin>(10);
            for (int i = 1; i < 11; i++)
            {
                bool isOccupied = rnd.Next(2) == 1;
                assassins.Add(new Assassin
                {
                    Name = $"Assassin {i}",
                    MinReward = rnd.Next(7, 15),
                    MaxReward = rnd.Next(16, 30),
                    IsOccupied = isOccupied,
                    ImageUrl = $@"{i}.jpg"
                });
            }
            context.Assassins.AddRange(assassins);

            context.Beggars.AddRange(new List<Beggar>(11)
            {
                new Beggar { Name = "Twitcher", Alms = 3, ImageUrl = @"1.jpg"},
                new Beggar { Name = "Drooler", Alms = 2, ImageUrl = @"2.jpg"},
                new Beggar { Name = "Dribbler", Alms = 1,ImageUrl = @"3.jpg"},
                new Beggar { Name = "Mumbler", Alms = 1,ImageUrl = @"4.jpg"},
                new Beggar { Name = "Mutterer", Alms = 0.9m,ImageUrl = @"5.jpg"},
                new Beggar { Name = "Walking-Along-Shouters", Alms = 0.8m,ImageUrl = @"6.jpg"},
                new Beggar { Name = "Demanders of a Chip", Alms = 0.6m,ImageUrl = @"7.jpg"},
                new Beggar { Name = "People Who Call Other People Jimmy", Alms = 0.5m,ImageUrl = @"8.jpg"},
                new Beggar { Name = "People Who Need Eightpence For A Meal", Alms = 0.08m,ImageUrl = @"9.jpg"},
                new Beggar { Name = "People Who Need Tuppence For A Cup Of Tea", Alms = 0.02m,ImageUrl = @"10.jpg"},
                new Beggar { Name = "People With Placards Saying \"Why lie? I need a beer.\"", Alms = 0,ImageUrl = @"11.jpg"},
            });
            context.Fools.AddRange(new List<Fool>(9)
            {
                new Fool {Name = "Muggins", Salary = 0.5m, ImageUrl = @"1.png"},
                new Fool {Name = "Gull", Salary = 1, ImageUrl = @"2png"},
                new Fool {Name = "Dupe", Salary = 2, ImageUrl = @"3.png"},
                new Fool {Name = "Butt", Salary = 3, ImageUrl = @"4.png"},
                new Fool {Name = "Fool", Salary = 5, ImageUrl = @"5.png"},
                new Fool {Name = "Tomfool", Salary = 6, ImageUrl = @"6.png"},
                new Fool {Name = "Stupid Fool", Salary = 7, ImageUrl = @"7.png"},
                new Fool {Name = "Arch Fool", Salary = 8, ImageUrl = @"8.png"},
                new Fool {Name = "Complete Fool", Salary = 10, ImageUrl = @"9.png"},
            });

            context.Thieves.AddRange(new List<Thief>(4)
            {
                new Thief {Name = "Yanukovich", ImageUrl = @"1.jpg"},
                new Thief {Name = "Robbin", ImageUrl = @"2.jpg"},
                new Thief {Name = "Garrett", ImageUrl = @"3.jpg"},
                new Thief {Name = "Brynjolf", ImageUrl = @"4.jpg"}
            });
            context.SaveChanges();
        }
    }
}