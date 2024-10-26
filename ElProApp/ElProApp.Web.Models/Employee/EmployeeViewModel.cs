﻿namespace ElProApp.Web.Models.Employee
{
    using ElProApp.Data.Models.Mappings;
    using ElProApp.Services.Mapping;
    using ElProApp.Data.Models;

    public class EmployeeViewModel : IMapFrom<Employee>
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public Decimal Wages { get; set; } 

        public Decimal MoneyToTake {  get; set; }
        
        public string UserId { get; set; } = null!;
        public string UserName { get; set; } = string.Empty;

        public ICollection<EmployeeTeamMapping> TeamsEmployeeBelongsTo { get; set; } = [];
    }
}
