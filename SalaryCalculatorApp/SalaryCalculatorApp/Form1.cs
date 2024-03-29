﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class SalaryCalcForm : Form
    {
        public SalaryCalcForm()
        {
            InitializeComponent();
        }

        private Employee anEmployee;// = new Employee();
        private Employee empName;// = new EmployeeName();
        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            empName = new Employee(employeeNameTextBox.Text);
            anEmployee= new Employee(Convert.ToDouble(basicAccountTextBox.Text), 
                                   Convert.ToDouble(houseRentTextBox.Text), 
                                   Convert.ToDouble(medicalAllowanceTextBox.Text));
            //empName.name = employeeNameTextBox.Text;
            //anEmployee.basicAcc = Convert.ToDouble(basicAccountTextBox.Text);
            //anEmployee.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            //anEmployee.medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);

            MessageBox.Show("Name: "+empName.EmpName+"\nand the salary is "+anEmployee.getSalary().ToString());

        }
    }
}
