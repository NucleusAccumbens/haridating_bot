﻿using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IDatingBotDbContext 
    {
        DbSet<DatingUser> DatingUsers { get; } 

        DbSet<TlgUser> TlgUsers { get; }

        DbSet<Photo> Photos { get; }

        Task<int> SaveChangesAsync();
    }
}