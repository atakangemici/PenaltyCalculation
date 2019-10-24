using PenaltyCalculation.Entities;
using PenaltyCalculation.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PenaltyCalculation.Controllers
{
    public class HomeController : Controller
    {
        PenaltyDbContext DBContext = new PenaltyDbContext();

        public ActionResult Index()
        {
            ViewBag.countryValues = new SelectList(DBContext.Country, "Value", "Name");

            return View();
        }

        [HttpPost]
        public ActionResult Index(ViewModel form)
        {
            int dayCount = 0;
            DateTime startDate = form.DateChecked;
            DateTime finishDate = form.DateReturned;
            TimeSpan totalDay = finishDate - startDate;
            double sumDay = totalDay.TotalDays;
            var Language = ConfigurationManager.AppSettings["Language"];

            if (form.countryValues == Language)
            {
                var trCountry = DBContext.Country.Where(x => x.Value == Language).ToList();

                for (int i = 0; i < sumDay; i++)
                {
                    if (startDate.DayOfWeek == DayOfWeek.Sunday || startDate.DayOfWeek == DayOfWeek.Saturday)
                    {
                        startDate = startDate.AddDays(1);
                        continue;
                    }
                    else
                    {
                        dayCount++;
                    }
                    startDate = startDate.AddDays(1);
                }

                if (dayCount > 10)
                {
                    int priceDay = dayCount - 10;
                    ViewBag.PenaltyPrice = priceDay * 5;
                }
            }
            ViewBag.countryValues = new SelectList(DBContext.Country, "Value", "Name");

            return View();
        }
    }
}