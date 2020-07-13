using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;

namespace SalaryCalculatorTestProject
{
    [TestClass]
    public class EmployeeSalaryTest
    {
        [TestMethod]
        public void EmployeeWeeklySalaryTest()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee employee = new Employee();

            string expectedResponse = String.Format("This ANGRY EMPLOYEE worked {0} hrs. " +
                            "Paid for 40 hrs at $ {1}" +
                            "/hr = ${2}", weeklyHours, wage, salary);
            string actualResposne = employee.CalculateWeeklySalary(weeklyHours, wage);

            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [TestMethod]
        public void ContractorWeeklySalaryTest()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor employee = new Contractor();

            string expectedResponse = String.Format("This HAPPY CONTRACTOR worked {0} hrs. " +
                            "Paid for {0} hrs at $ {1}" +
                            "/hr = ${2}", weeklyHours, wage, salary);
            string actualResposne = employee.CalculateWeeklySalary(weeklyHours, wage);

            Assert.AreEqual(actualResposne, expectedResponse);
        }

        [TestMethod]
        public void EmployeeWeeklySalaryTest_70Wage_55HoursDoesNotReturnsCorrectString()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;
            Employee employee = new Employee();

            string expectedResponse = String.Format("Problem 1 - This ANGRY EMPLOYEE worked {0} hrs. " +
                            "Paid for 40 hrs at $ {1}" +
                            "/hr = ${2}", weeklyHours, wage, salary);
            string actualResposne = employee.CalculateWeeklySalary(weeklyHours, wage);

            Assert.AreNotEqual(actualResposne, expectedResponse);
        }

        [TestMethod]
        public void ContractorWeeklySalaryTest_70Wage_55HoursDoesNotReturnsCorrectString()
        {
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;
            Contractor employee = new Contractor();

            string expectedResponse = String.Format("Problem 2 This HAPPY CONTRACTOR worked {0} hrs. " +
                          "Paid for {0} hrs at $ {1}" +
                          "/hr = ${2} ", weeklyHours, wage, salary);
            string actualResposne = employee.CalculateWeeklySalary(weeklyHours, wage);

            Assert.AreNotEqual(actualResposne, expectedResponse);
        }
    }
}
