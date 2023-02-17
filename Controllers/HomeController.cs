using ChallengeTask_v2.Data;
using ChallengeTask_v2.Models;
using ChallengeTask_v2.Tables;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Diagnostics;

namespace ChallengeTask_v2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //Collateral_agreements CA_obj = new Collateral_agreements()
            //{
            //    CAName = "Input-1",
            //};
            //Contract_Frequencies CF_obj = new Contract_Frequencies()
            //{
            //    CFName = "Input-1",
            //    //Collateral_Agreements_ID = CA_obj.CollateralAgreementID,
            //    Collateral_Agreements = CA_obj
            //};
            //Interest_frequency IF_obj = new Interest_frequency()
            //{
            //    IFName = "Input-1",
            //    Contract_Frequencies = CF_obj
            //};

            //// Save changes
            //CF_obj.IF_obj.Add();

            //var context = new ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());

            Collateral_agreements CA_obj = new Collateral_agreements()
            {
                CAName = "Input-A",
            };
            Contract_Frequencies CF_obj = new Contract_Frequencies()
            {
                CFName = "Input-A",
            };
            Interest_frequency IF_obj = new Interest_frequency()
            {
                IFName = "Input-A"
            };

            CF_obj.Collateral_Agreements_ID = CA_obj;
            IF_obj.Contract_Frequencies_ID = CF_obj;

            CF_obj.IF_ID.Add(IF_obj);
            CA_obj.CF_ID.Add(CF_obj);

            this._context.Add(CA_obj);
            this._context.SaveChanges();
            
            //using(var context = new ApplicationDbContext())
            //{
            //    using(DbContextTransaction transaction = (DbContextTransaction)context.Database.BeginTransaction())
            //    {
            //        context.Add(CA_obj);
            //        context.SaveChanges();
            //    }
            //}


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}