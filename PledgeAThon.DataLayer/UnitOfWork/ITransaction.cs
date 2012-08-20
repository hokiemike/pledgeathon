using System;

namespace PledgeAThon.DataLayer.UnitOfWork
{
    /// <summary>
    /// Represents transaction in the repository.
    /// </summary>
    public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
