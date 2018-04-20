using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AddressLookup.Models
{
  public class Contact
  {
    private string _firstName;
    private string _lastName;
    private string _number;
    private string _email;
    private Address _address;
    private static List<Address> _fullAddress = new List<Address>();

    public Contact(string firstName, string lastName, string number, string email, Address address)
    {
      _firstName= firstName;
      _lastName= lastName;
      _number= number;
      _email= email;
      _address= address;
      //_id=count++
    }
  }
}
