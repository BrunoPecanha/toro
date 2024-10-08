﻿using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Toro.Domain.Entity;

namespace Toro.Repository.Context {
    public interface IToroContext {
        DbSet<Investor> Investor { get; }
        DbSet<Patrimony> Patrimony { get; }
        DbSet<Asset> Asset { get; set; }
        DbSet<AssetXPatrimony> AssetXPatrimony { get; set; }
        DbSet<User> User { get; set; }
        Task<int> SaveChangesAsync();
    }
}
