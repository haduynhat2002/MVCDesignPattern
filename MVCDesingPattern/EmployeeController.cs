using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDesingPattern
{
    class EmployeeController
    {
        private IEmployee empModel;
        private IEmployeeView empView;

        public EmployeeController(IEmployee emp, IEmployeeView empView)
        {
            this.empModel = emp;
            this.empView = empView;
        }

        public void DisplayEmploeeInfo()
        {
            empView.DisplayEmploeeView(this.empModel);
        }

        public void UpdateEmployeeSalary(Decimal salary)
        {
            this.empModel.EmployeeSalary = salary;
        }
    }
}
