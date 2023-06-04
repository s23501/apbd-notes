using Kolokwium.Data;
using System.Numerics;

namespace Kolokwium.Services
{
    public class DbService : IDbService
    {
        private readonly ChangeMeContext _context;
        public DbService(ChangeMeContext context)
        {
            _context = context;
        }

        //public async Task AddDoctor(DoctorData data)
        //{
        //    _context.Doctors.Add(new Doctor
        //    {
        //        FirstName = data.FirstName,
        //        LastName = data.LastName,
        //        Email = data.Email,
        //    });
        //    await _context.SaveChangesAsync();
        //}
    }
}
