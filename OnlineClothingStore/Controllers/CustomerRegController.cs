using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineClothingStore.Models;

namespace OnlineClothingStore.Controllers
{
    public class CustomerRegController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerModel cm)
        {
            string connection = "Data Source=ZAFRULLAH;Initial Catalog=dbMyOnlineShopping;Integrated Security=True";
            using (SqlConnection sqlconn = new SqlConnection(connection))
            {
                string sqlquery = "insert into Customer (MemberId,FirstName,LastName,Email,Password,ContactNumber) values('" + cm.FirstName + "','" + cm.lastName + "','" + cm.Email + "','" + cm.Password + "','" + cm.ContactNumber + "') ";
                using(SqlCommand sqlcomm=new SqlCommand(sqlquery, sqlconn))
                {
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    ViewData["message"] = "The New Customer " + cm.FirstName + "is Saved Successfully";
                }
            }
            return View(cm);
        }
    }
}