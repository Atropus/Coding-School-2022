using Microsoft.AspNetCore.Mvc;
using GoilGasStation.Model;
using GoilGasStation.EF.Repositories;
using GoilGasStation.Blazor.Shared.ViewModels;

namespace RedMotors.Blazor.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MonthlyLedgerController : ControllerBase
    {
        //private readonly IEntityRepo<Ledger> _ledgerRepo;
        //public MonthlyLedgerController(IEntityRepo<Ledger> ledgerRepo)
        //{
        //    _ledgerRepo = ledgerRepo;
        //}
        //[HttpGet]
        //public async Task<IEnumerable<LedgerViewModel>> Get()
        //{

        //}
        //[HttpGet("{id}")]
        //public async Task<LedgerViewModel> Get(Guid id)
        //{

        //}
        //[HttpPost]
        //public async Task Post(LedgerViewModel customer)
        //{

        //}


        //[HttpDelete("{id}")]
        //public async Task Delete(Guid id)
        //{

        //}

        //[HttpPut]
        //public async Task<ActionResult> Put(LedgerViewModel customer)
        //{

        //}
    }
}
