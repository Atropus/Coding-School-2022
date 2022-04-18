using Microsoft.AspNetCore.Mvc;
using GoilGasStation.Model;
using GoilGasStation.EF.Repositories;
using GoilGasStation.Blazor.Shared.ViewModels;
using GoilGasStation.Blazor.Shared.Managers;

namespace RedMotors.Blazor.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MonthlyLedgerController : ControllerBase
    {
        
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        
        public MonthlyLedgerController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Employee> employeeRepo)
        {
            
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
        }
        [HttpGet("{Year}/{Month}")]
        public async Task<LedgerViewModel> Get(int Year,int Month)
        {

            var ledger = new LedgerViewModel();
            var resultTransactions = await _transactionRepo.GetAllAsync();
            decimal totalcost = 0.00M;
            var transactions = resultTransactions.Where(x => x.Date.Year == Year && x.Date.Month == Month);
            foreach (var transaction in transactions)
            {

                ledger.Income += transaction.TotalValue;
                foreach (var transactionline in transaction.TransactionLines)
                {

                    totalcost += transactionline.Item.Cost * transactionline.Quantity;
                }
                ledger.Expenses += totalcost;
                totalcost = 0.00M;
            }
            ledger.Expenses += 5000;//TODO
            var existingEmployees = await _employeeRepo.GetAllAsync();
            var serverManager = new ServerManagers();
            DateTime ledgerDateEnd = new DateTime(Year, Month, serverManager.GetLastDayOfMonth(Year, Month));
            var employees = existingEmployees.Where(em => (em.HireDateStart <= ledgerDateEnd && (em.HireDateEnd is null || em.HireDateEnd >= ledgerDateEnd))
            || (em.HireDateStart <= ledgerDateEnd && em.HireDateEnd <= ledgerDateEnd)).ToList(); //me thn eugenh xorhgia toy Ioanni Eskioglou
            foreach (var employee in employees)
            {
                if (employee.HireDateEnd is null || employee.HireDateEnd > ledgerDateEnd)
                {
                    ledger.Expenses += employee.SalaryPerMonth;
                }
                else
                {
                    var salaryPercent = ((DateTime)employee.HireDateEnd).Day / ledgerDateEnd.Day;
                    ledger.Expenses += employee.SalaryPerMonth * salaryPercent;
                }

            }
            ledger.Total = ledger.Income - ledger.Expenses;
            ledger.Year = Convert.ToInt16(Year);
            ledger.Month = Convert.ToSByte(Month);
            return ledger;
    }
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
