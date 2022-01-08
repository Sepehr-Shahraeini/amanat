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
        [Route("api/assets/view")]
        public ActionResult<IQueryable<VIEW_ASSET>> GetAssetsQuery()
        {
            return _assetService.GetAssetsQuery();
        }

        [EnableQuery()]
        [HttpGet]
        [Route("api/vehicles/view")]
        public ActionResult<IQueryable<VIEW_VEHICLE>> GetVehiclesQuery()
        {
            return _assetService.GetVehiclesQuery();
        }

        [EnableQuery()]
        [HttpGet]
        [Route("api/melks/view")]
        public ActionResult<IQueryable<VIEW_MELK>> GetMelksQuery()
        {
            return _assetService.GetMelksQuery();
        }

        [EnableQuery()]
        [HttpGet]
        [Route("api/phones/view")]
        public ActionResult<IQueryable<VIEW_PHONE>> GetPhonesQuery()
        {
            return _assetService.GetPhonesQuery();
        }

    }
}
