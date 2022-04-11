﻿using Microsoft.AspNetCore.Mvc;
using GoilGasStation.Model;
using GoilGasStation.EF.Repositories;
using GoilGasStation.Blazor.Shared.ViewModels;

namespace RedMotors.Blazor.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }
        [HttpGet]
        public async Task<IEnumerable<CustomerViewModel>> Get()
        {
            var result = await _customerRepo.GetAllAsync();
            return result.Select(customer => new CustomerViewModel
            {
                ID = customer.ID,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber,

            });
        }
        [HttpGet("{id}")]
        public async Task<CustomerEditViewModel> Get(Guid id)
        {
            CustomerEditViewModel model = new();
            if (id != Guid.Empty)
            {
                var existingCustomer = await _customerRepo.GetByIdAsync(id);
                model.ID = existingCustomer.ID;
                model.Name = existingCustomer.Name;
                model.Surname = existingCustomer.Surname;
                model.CardNumber = existingCustomer.CardNumber;
            }
            return model;
        }
        [HttpPost]
        public async Task Post(CustomerEditViewModel customer)
        {
            var newCustomer = new Customer
            {
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber,
            };
            await _customerRepo.CreateAsync(newCustomer);
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _customerRepo.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CustomerEditViewModel customer)
        {
            var customerToUpdate = await _customerRepo.GetByIdAsync(customer.ID);
            if (customerToUpdate == null) return NotFound();
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Surname = customer.Surname;
            customerToUpdate.CardNumber = customer.CardNumber;
            await _customerRepo.UpdateAsync(customer.ID, customerToUpdate);
            return Ok();
        }
    }
}
