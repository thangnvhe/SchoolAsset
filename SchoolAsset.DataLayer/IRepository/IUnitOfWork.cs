using SchoolAsset.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAsset.DataLayer.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Building> Buildings { get; }
        Task<int> CompleteAsync();
    }
}

