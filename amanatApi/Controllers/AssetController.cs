using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using amanatApi.Models;
using amanatApi.Services;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace amanatApi.Controllers
{
    public class AssetController : ControllerBase
    {
        private IAssetService _assetService;
        public AssetController(IAssetService assetService)
        {
            _assetService = assetService;
        }

        [EnableQuery()]
        [HttpGet]
        [Route("api/asset/query")]
        public ActionResult<IQueryable<VIEW_ASSET>> GetAssetsQuery()
        {
            return _assetService.GetAssetsQuery();
        }

    }
}
