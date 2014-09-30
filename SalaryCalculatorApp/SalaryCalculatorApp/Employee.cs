using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Employee
    {
        private string empName;
        private double basicAcc;
        private double houseRent;
        private double medicalAllowance;


        public string EmpName
        {
            set
            {
                empName = value;
            }
            get
            {
                return empName;
            }
        }
        public double BasicAcc
        {
            set
            {
                basicAcc = value;
            }
            get
            {
                return basicAcc;
            }
        }
        public double HouseRent
        {
            set
            {
                houseRent = value;
            }
            get
            {
                return houseRent;
            }
        }
        public double MedicalAlowance
        {
            set
            {
                medicalAllowance = value;
            }
            get
            {
                return medicalAllowance;
            }
        }
        public Employee(string empName)
        {
            EmpName = empName;
        }

        public Employee(double basicAcc, double houseRent, double medicalAllowance)
        {
            BasicAcc = basicAcc;
            HouseRent = houseRent;
            MedicalAlowance = medicalAllowance;
        }
        public double getSalary()
        {
            double result = BasicAcc + BasicAcc*(HouseRent/100) + (BasicAcc*MedicalAlowance/100);
            return result;
        }
    }
}
