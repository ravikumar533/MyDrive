using System;
using System.Threading.Tasks;
using MyDrive.EFModels;

namespace MyDrive.Repository
{
    public interface IDriverepo : IDisposable
    {
        // Database
        DBContainer DataContext { get; }
        Task<User> GetUserById(string userId);
        void PrepareSubmit(User repo);
        void PrepareSaveChanges();
    }
}