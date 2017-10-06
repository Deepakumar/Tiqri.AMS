using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tiqri.AMS.Web.App_Start;
using Tiqri.AMS.Web.ViewModel;

namespace Tiqri.AMS.Web.ContextHandlers.impl
{
    public class EmployeeContextHandler : IEmployeeContextHandler
    {
        public List<Employee> GelAllEmployee()
        {
            List<Employee> employeeList=null;

            AuthContext context = HttpContext.Current.GetOwinContext().Get<AuthContext>();

            var userList = context.Users.ToList();

            if(userList != null)
            {
                employeeList = new List<Employee>();

                foreach (var user in userList)
                {
                    employeeList.Add(new Employee() { ID = user.Id, FirstName = user.FirstName, LastName = user.LastName });
                }

            }

            return employeeList;
        }

        public CurrentUser GetEmployee(string name)
        {
            AuthContext context = new AuthContext();

            var user = context.Users.Where(i => i.UserName == name).FirstOrDefault();

            return new CurrentUser()
            {
                UserID = user.Id,
                FirstName = user.FirstName , LastName = user.LastName,
                TitleID = ((int)user.Title).ToString()
            };
        }
    }
}