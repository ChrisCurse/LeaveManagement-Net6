using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int LeaveTypeId);

        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);

        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int Id);
        Task<LeaveAllocation?> GetEmployeeAllocation(string Id, int leaveTypeId);

        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
    
}
