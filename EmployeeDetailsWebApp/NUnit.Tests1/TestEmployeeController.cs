using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino;
using Rhino.Mocks;
using EmployeeDetailsWebApp;
using EmployeeDetailsWebApp.Model;
namespace NUnit.Tests1
{
    [TestFixture]
    public class TestEmployeeController
    {        
        private Employee mockEmployee1 = new Employee()
        {
            Id = "1000",
            FirstName = "Mock_First_Name",
            LastName = "Mock_Last_Name",
            EmailId = "Mock_Id.m@mock.com",
            Age = 20,
            ActiveStatus = true
        };
        private Employee mockEmployee2 = new Employee()
        {
            Id = "1001",
            FirstName = "Mock_First_Name_2",
            LastName = "Mock_Last_Name_2",
            EmailId = "Mock_Id_2.m@mock.com",
            Age = 20,
            ActiveStatus = true
        };
        private Employee mockEmployee3 = new Employee()
        {
            Id = "1001",
            FirstName = "Mock_First_Name_2",
            LastName = "Mock_Last_Name_2",
            EmailId = "Mock_Id_2.m@mock.com",
            Age = 20,
            ActiveStatus = true
        };
        private List<Employee> mockEmployeeList ;    

        [SetUp]
        public void TestInit()
        {
            mockEmployeeList = new List<Employee>();
            mockEmployeeList.Add(mockEmployee1);
            mockEmployeeList.Add(mockEmployee2);           
        }
        [Test]
        public void GivingValidEmployeeDetailsOnCreateReturnsOne()
        {
            var employeeRepositoryMock = MockRepository.GenerateMock<IEmployeeRepositoryInterface>();
            employeeRepositoryMock.Expect(x => x.InsertEmployeeById(mockEmployee1)).Return(1);            
            EmployeeController employeeController = new EmployeeController(employeeRepositoryMock);
            var result = employeeController.CreateNewEmployee(mockEmployee1);
            Assert.AreEqual(1,result,"Result is not 1");
        }
        [Test]
        public void GivingEmptyFirstNameOrLastNameOnCreateReturnsZero()
        {
            var employeeRepositoryMock = MockRepository.GenerateMock<IEmployeeRepositoryInterface>();
            employeeRepositoryMock.Expect(x => x.InsertEmployeeById(mockEmployee2)).Return(1);
            EmployeeController employeeController = new EmployeeController(employeeRepositoryMock);
            var result = employeeController.CreateNewEmployee(mockEmployee1);
            Assert.AreEqual(0, result, "Result is not 1");
        }
        [Test]
        public void GivingEmptyEmailOnCreateReturnsZero()
        {
            var employeeRepositoryMock = MockRepository.GenerateMock<IEmployeeRepositoryInterface>();
            employeeRepositoryMock.Expect(x => x.InsertEmployeeById(mockEmployee1)).Return(1);
            EmployeeController employeeController = new EmployeeController(employeeRepositoryMock);
            var result = employeeController.CreateNewEmployee(mockEmployee3);
            Assert.AreEqual(0, result, "Result is not 1");
        }
    }
}
