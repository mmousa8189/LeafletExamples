using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace LeafletExamples.Web.Pages
{
    public class GeoJsonSimpleModel : PageModel
    {
        private readonly ILogger<GeoJsonSimpleModel> _logger;
        private readonly IWebHostEnvironment _environment;

        public GeoJsonSimpleModel(ILogger<GeoJsonSimpleModel> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }
        public void OnGet()
        {
        }

        public JsonResult OnGetGeojsonFile()
        {
            var data  = new GeojsonTypeRootobject();
            string path = Path.Combine(_environment.WebRootPath, "App_Data", "egypt_administrative.geojson");

            using (StreamReader sr = new(path))
            {
                data = JsonConvert.DeserializeObject<GeojsonTypeRootobject>(sr.ReadToEnd());
            }
            return new JsonResult(data);
        }
    }
}
