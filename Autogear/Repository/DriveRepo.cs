using MyDrive.EFModels;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MyDrive.Repository
{
    public class DriveRepo : IDriverepo
    {
        public DBContainer DataContext { get; private set; }
       
        public DriveRepo()
        {
            DataContext = new DBContainer();
        }

        public async Task<User> GetUserById(string userId)
        {
            return await DataContext.Users.SingleOrDefaultAsync(s => s.UserId == userId);
        }

        public async void PrepareSubmit(User repo)
        {
            if (string.IsNullOrEmpty(repo.UserId))
            {
                var user = await GetUserById(repo.UserId);
                if (user == null)
                {
                    DataContext.Users.Add(repo);
                }
            }
        }

        public void PrepareSaveChanges()
        {
            DataContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
