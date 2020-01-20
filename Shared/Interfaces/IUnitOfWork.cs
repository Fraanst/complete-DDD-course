using System;

namespace Shared.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}