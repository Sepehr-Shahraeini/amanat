using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using amanatApi.Models;

namespace amanatApi.Services
{

    public interface IAssetService
    {
        DbSet<VIEW_ASSET> GetAssetsQuery();
        DbSet<VIEW_VEHICLE> GetVehiclesQuery();
        DbSet<VIEW_MELK> GetMelksQuery();
        DbSet<VIEW_PHONE> GetPhonesQuery();
    }


    public class AssetService : IAssetService
    {

        private readonly amanatContext _context;
        public AssetService(amanatContext amanat)
        {
            _context = amanat;
        }

        public DbSet<VIEW_ASSET> GetAssetsQuery()
        {
            return _context.VIEW_ASSETs;
        }
      public DbSet<VIEW_VEHICLE> GetVehiclesQuery()
        {
            return _context.VIEW_VEHICLEs;
        }
      public DbSet<VIEW_MELK> GetMelksQuery()
        {
            return _context.VIEW_MELKs;
        }
      public DbSet<VIEW_PHONE> GetPhonesQuery()
        {
            return _context.VIEW_PHONEs;
        }
    }
}
