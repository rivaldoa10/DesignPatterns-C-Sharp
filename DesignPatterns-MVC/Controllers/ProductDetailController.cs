using DesignPatterns_MVC.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Tools;
using Tools.Earn;

namespace DesignPatterns_MVC.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;
        private readonly IOptions<MyConfig> _config;

        public IConfiguration Configuration { get; }
        public ProductDetailController(IOptions<MyConfig> config, LocalEarnFactory localEarnFactory,
            ForeignEarnFactory foreignEarnFactory)
        {
            _config = config;
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            Log.GetInstance(_config.Value.PathLog).Save("Entro a Product Detail");

            // products
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            // total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
