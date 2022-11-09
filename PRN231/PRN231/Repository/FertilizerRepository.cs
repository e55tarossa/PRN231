/*using Microsoft.EntityFrameworkCore;
using PRN231.Data;
using PRN231.Interfaces;
using PRN231.Models;
using System.Collections.Generic;
using System.Linq;

namespace PRN231.Repository
{
    public class FertilizerRepository : IFertilizerRepository
    {
        private readonly DataContext _context;

        public FertilizerRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateFertilizer(Fertilizer fertilizer)
        {
            _context.Add(fertilizer);
            return Save();
        }

        public bool DeleteFertilizer(Fertilizer fertilizer)
        {
            _context.Remove(fertilizer);
            return Save();
        }

        public bool FertilizerExist(int id)
        {
            return _context.Fertilizers.Any(f => f.fertID == id);
        }

        public Fertilizer GetFertilizer(int id)
        {
            return _context.Fertilizers.Where(s => s.fertID == id).FirstOrDefault();
        }

        public ICollection<Fertilizer> GetFertilizers()
        {
            return _context.Fertilizers.ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateFertilizer(Fertilizer fertilizer)
        {
            _context.Update(fertilizer);
            return Save();
        }


    }
}
*/