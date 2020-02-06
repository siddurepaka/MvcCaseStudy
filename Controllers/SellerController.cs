using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmartMVCCaseStudy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmartMVCCaseStudy.Controllers
{
    public class SellerController : Controller
    {
        public readonly SellerContext _Context;
        public SellerController(SellerContext context)
        {
            this._Context = context;
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Seller Sell)
        {
            try
            {
                _Context.Add(Sell);
                _Context.SaveChanges();
                ViewBag.message = "Hi " + Sell.SUname + "\n You are Successfully Registered.";
                //return RedirectToAction("Login");
                return View();
            }
            catch (Exception e)
            {
                ViewBag.message = "Sorry " + Sell.SUname + "\n You are Not Successfully Registered.\n try again after Sometime.";
                return View();
            }

        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Seller Buy)
        {
            var loguser = _Context.Sellers.Where(e => e.SUname == Buy.SUname && e.SPassword == Buy.SPassword);
            if (loguser == null)
            {
                ViewBag.message = "Not Valid";
                return View();
            }
            else
            {

                return RedirectToAction("Display");
            }

        }
        public ActionResult Display()
        {
            return View();
        }
        // GET: Seller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
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

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
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

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
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