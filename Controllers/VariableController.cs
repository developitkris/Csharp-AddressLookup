using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressLookup.Models;

namespace AddressLookup.Controllers
{
  public class VariableController : Controllers
  {
    [Produces("text/html")]
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/contact/form")]
    public ActionResult Form()
    {
      return View("Form");
    }

    [HttpGet("contact/directory")]
    public ActionResult ContactList()
    {
      return View();
    }

    [HttpPost("/directory")]
    public ActionResult CreateContact()
    {
      Address _fullAddress = new Address(Request.Form["streetNum"], Request.Form["streetName"], Request.Form["city"], Request.Form["state"], Request.Form["zipcode"]);
      Contact _myContacts = new Contact(Request.Form["firstName"], Request.Form["lastName"], Request.Form["number"], Request.Form["email"], _fullAddress);
      _myContacts.Save();
      return View("Home", Contact.GetAllContacts());
    }

    [HttpPost("/contact/remove")]
    public ActionResult DeleteAll()
    {
      Contact.DeleteAllContacts();
      return View();
    }
  }
}
