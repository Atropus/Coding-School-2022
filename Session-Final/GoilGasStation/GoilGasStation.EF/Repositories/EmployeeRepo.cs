using GoilGasStation.Model;
using GoilGasStation.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoilGasStation.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        private readonly GoilGasStationContext _context;
        public EmployeeRepo(GoilGasStationContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Employee Entity)
        {
            await _context.Employees.AddAsync(Entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var currentEmployee = _context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (currentEmployee is null)
                throw new KeyNotFoundException($"'{id}' not found");
            _context.Employees.Remove(currentEmployee);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(Guid id)
        {
            return await _context.Employees.Where(employee => employee.ID == id).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(Guid id, Employee entity)
        {
            var currentEmployee = await _context.Employees.SingleOrDefaultAsync(employee => employee.ID == id);
            if (currentEmployee is null)
                throw new KeyNotFoundException($"'{id}' not found");
            currentEmployee.Name = entity.Name;
            currentEmployee.Surname = entity.Surname;
            currentEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            currentEmployee.HireDateEnd = entity.HireDateEnd;
            currentEmployee.EmployeeType = entity.EmployeeType;
            await _context.SaveChangesAsync();
        }
    }
}
