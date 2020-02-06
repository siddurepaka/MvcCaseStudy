using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmartMVCCaseStudy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmartMVCCaseStudy.Controllers
{
    public class BuyerController : Controller
    {
        public readonly BuyerContext _Context;
        public BuyerController(BuyerContext context)
        {
            this._Context = context;
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Buyer Buy)
        {
            try
            {
                _Context.Add(Buy);
                _Context.SaveChanges();
                ViewBag.message = "Hi " + Buy.BUname + "\n You are Successfully Registered.";
                //return RedirectToAction("Login");
                return View();
            }
            catch(Exception e)
            {
                ViewBag.message = "Sorry " + Buy.BUname + "\n You are Not Successfully Registered.\n try again after Sometime.";
                return View();
            }
           
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Buyer Buy)
        {
            var loguser = _Context.Buyers.Where(e => e.BUname == Buy.BUname && e.BPassword == Buy.BPassword);
           if(loguser==null)
            {
                ViewBag.message = "Not Valid";
                return View();
            }
            else
            {

              return  RedirectToAction("Display");
            }

        }
        public ActionResult Display()
        {
            return View();
        }
        // GET: Buyer
        public ActionResult Index()
        {
            return View();
        }


        // GET: Buyer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Buyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buyer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buyer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}