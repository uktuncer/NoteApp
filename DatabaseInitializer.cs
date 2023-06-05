using NoteApp.Models.Context;
using NoteApp.Models.Entities;

namespace NoteApp
{
    public class DatabaseInitializer
    {
        private DatabaseContext _context;
        private AppSettings _settings;

        public DatabaseInitializer(DatabaseContext context, AppSettings settings)
        {
            _context = context;
            _settings = settings;
        }

        public void Seed()
        {
            if (_context.Users.Any(x => x.UserName == _settings.AdminUserName) == false)
            {
                _context.Users.Add(new User
                {
                    UserName = _settings.AdminUserName,
                    Password = _settings.AdminPassword,
                    FullName = _settings.AdminFullName,
                    Email = _settings.AdminEmail,
                    IsActive = true,
                    IsAdmin = true,
                    CreatedUser = "default",
                    CreatedAt = DateTime.Now
                });
                _context.SaveChanges();
            }
        }
    }
}
