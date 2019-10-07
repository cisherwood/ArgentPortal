using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArgentPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Card> Card { get; set; }
        public DbSet<CardCategory> CardCategory { get; set; }
        public DbSet<CardTag> CardTag { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Deck> Deck { get; set; }
        public DbSet<CardEffect> CardEffect { get; set; }

        public DbSet<CardDeck> CardDeck { get; set; }
    }
}
