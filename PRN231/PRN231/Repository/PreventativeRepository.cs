/*using PRN231.Data;
using PRN231.Interfaces;
using PRN231.Models;
using System.Collections.Generic;
using System.Linq;

namespace PRN231.Repository
{
    public class PreventativeRepository : IPreventativeRepository
    {
        private readonly DataContext _context;

        public PreventativeRepository(DataContext context)
        {
            _context = context;
        }
        public bool PreventativeExist(int id)
        {
            return _context.Preventatives.Any(f => f.preventID == id);
        }

        public Preventative GetPreventative(int id)
        {
            return _context.Preventatives.Where(s => s.preventID == id).FirstOrDefault();
        }

        public ICollection<Preventative> GetPreventatives()
        {
            return _context.Preventatives.ToList();
        }

        public bool UpdatePreventative(Preventative preventative)
        {
            _context.Update(preventative);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool CreatePreventative(Preventative preventative)
        {
            _context.Add(preventative);
            return Save();
        }

        public bool DeletePreventative(Preventative preventative)
        {
            _context.Remove(preventative);
            return Save();
        }
    }
}
*/