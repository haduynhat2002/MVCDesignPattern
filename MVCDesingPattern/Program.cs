using System;

namespace MVCDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           /* IEmployee empModel = new Employee();
            IEmployeeView empView = new EmployeeView();

            empModel.FirstName = "David";
            empModel.LastName = "Brown";
            empModel.EmployeeID = 32567;
            empModel.EmployeeSalary = 90000.00M;

            EmployeeController empController = new EmployeeController(empModel, empView);
            empController.DisplayEmploeeInfo();

            Console.ReadLine(); */

            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
        }
    }


}
