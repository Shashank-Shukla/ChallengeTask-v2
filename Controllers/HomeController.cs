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
            Collateral_agreements CA_obj = null;
            Contract_Frequencies CF_obj = null;
            Interest_frequency IF_obj = null;

            // Inserting test data
            for (int i = 0; i < 20; i++)
            {
                CA_obj = new Collateral_agreements() {
                    CAName = $"Parent_Entry-{i}",
                };

                for (int j = 0; j <= i; j++)
                {
                    CF_obj = new Contract_Frequencies() 
                    {
                        CFName = $"Child_Entry-{i}_{j}",
                        Collateral_Agreements_ID = CA_obj
                    };

                    for (int k = 0; k<= j; k++)
                    {
                        IF_obj = new Interest_frequency()
                        {
                            IFName = $"GrandChild_Entry-{i}_{j}",
                            Contract_Frequencies_ID = CF_obj
                        };

                        CF_obj.IF_ID.Add(IF_obj);
                    }

                    CA_obj.CF_ID.Add(CF_obj);
                }
                

                this._context.Add(CA_obj);
            }

            this._context.SaveChanges();
            this._context.Dispose();
            //this._context.BulkSaveChanges();

            //using (var transactions = _context.Database.BeginTransaction())
            //{
            //    try
            //    {
            //        this._context.Add(CA_obj);
            //        this._context.BulkSaveChanges();
            //        transactions.Commit();
            //    }
            //    catch (Exception ex)
            //    {
            //        transactions.Rollback();
            //        throw;
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