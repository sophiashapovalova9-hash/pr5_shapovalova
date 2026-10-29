using pr3_shapovalova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_shapovalova
{
    internal class Helper
    {
        private static SoundRecordSdEntities1 _context;

        public static SoundRecordSdEntities1 GetContext()
        {
            if (_context == null)
            {
                _context = new SoundRecordSdEntities1();
            }
            return _context;
        }

        public static void AddUser(User newUser)
        {
            var db = GetContext();
            db.User.Add(newUser);
            db.SaveChanges();
        }
    }
}
