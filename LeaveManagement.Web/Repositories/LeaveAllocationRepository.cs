using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using LeaveManagement.Web.Constants;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Models;
using AutoMapper;
using NuGet.Protocol;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveAllocationRepository(ApplicationDbContext context, UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            

            return await context.LeaveAllocation.AnyAsync(x =>  x.EmployeeId == employeeId 
                                                             && x.LeaveTypeId == leaveTypeId 
                                                             && x.Period == period);

           
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await context.LeaveAllocation
                .Include(x => x.LeaveType)
                .Where(q => q.EmployeeId == employeeId)
                .ToListAsync();

            var employee = await userManager.FindByIdAsync(employeeId);

            var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
            if(allocations.Any())
            {
                employeeAllocationModel.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

            }
            return employeeAllocationModel;
        }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int Id)
        {
            var allocation = await context.LeaveAllocation
                .Include(x => x.LeaveType)
                .FirstOrDefaultAsync(x => x.Id == Id);

          
            if (allocation == null)
            {
                return null;

            }
            var employee = await userManager.FindByIdAsync (allocation.EmployeeId);

            var model = mapper.Map<LeaveAllocationEditVM>(allocation);
            model.Employee = mapper.Map<EmployeeListVM>(employee);

            return model;
        }

        public async Task LeaveAllocation(int LeaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);

            var period = DateTime.Now.Year;

            var leaveType = await leaveTypeRepository.GetAsync(LeaveTypeId);

            var allocations = new List<LeaveAllocation>();

            foreach (var employee in employees)
            {
                if(await AllocationExists(employee.Id, LeaveTypeId, period))
                {
                    continue;
                }
                allocations.Add( new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = LeaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });
              
              
            }
            await AddRangeAsync(allocations);
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                //return NotFound();
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);

            //return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId })
            return true;
        }
    }
}
