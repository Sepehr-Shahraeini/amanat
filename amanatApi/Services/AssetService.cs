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
    }
}
