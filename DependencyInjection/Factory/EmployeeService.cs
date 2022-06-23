using DependencyInjection.InterfaceFactory;
using DependencyInjection.Model;

namespace DependencyInjection.Factory
{
    public class EmployeeService : IEmployeeDetails
    {
        public List<Employee> GetEmployee()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Title = "Mr",
                    Name = "Simon",
                    Age = 32,
                    EmailId = "test@mailinator.com",
                    MobileNumber= "12346",
                    Address = "Pune",
                    Pincode =   411057

                },
                new Employee()
                {
                    Id = 2,
                    Name = "David",
                    Age = 35,
                    EmailId = "David@mailinator.com",
                    MobileNumber= "654323456",
                    Address = "Mumbai",
                    Pincode =   221011
                },
                new Employee()
                {
                    Id = 3,
                    Title = "Mr",
                    Name = "Peter",
                    Age = 29,
                    EmailId = "Peter@mailinator.com",
                    MobileNumber= "54323456",
                    Address = "Lucknow",
                    Pincode =   221100
                }
            };
            return employees;
        }
    }
}
