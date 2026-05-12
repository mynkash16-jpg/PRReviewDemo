using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRReviewDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            ICustomerRepository customerRepository = new CustomerRepository();
			return View(customerRepository.GetCustomerById(id));
            //Get customer by id and return to view

        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }

        /// <summary>
        /// id property
        /// </summary>
        public string name { get; set; }
    }

    class CustomerRepository : ICustomerRepository
	{
        public Customer GetCustomerById(int id)
        {
            //Get customer by id from database
            return new Customer() { Id = id, name = "John Doe" };
		}
    }
}
