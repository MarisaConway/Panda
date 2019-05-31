using Pandas.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;



namespace Pandas.Models {
    public class PandaContext : DbContext {
        public PandaContext(DbContextOptions options) : base(options) { }
        public DbSet<Panda> Pandas {get;set;}
        public void Create(Panda p)
        {
            Add(p);
            SaveChanges();
        }
        public Panda GetPandaById(int PandaId)
        {
            return Pandas.Where(p => p.PandaId == PandaId).FirstOrDefault();
        }
        public void Update(Panda p)
        {
            Panda result = GetPandaById(p.PandaId);
            if(result != null)
            {
                result.Type = p.Type;
                result.Location = p.Location;
                result.Cuteness = p.Cuteness;
                result.Weight = p.Weight;
                result.Description = p.Description;
                result.Updated_At= DateTime.Now;
                SaveChanges();
            }
        }
        public void DeleteById(int PandaId)
        {
            Remove(GetPandaById(PandaId));
            SaveChanges();
        }
    }
}

// => unonimous function
// FirstOrDefault finds the thing I am looking for, if it doesnt exist returns a null.
