using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AddressLookup.Models
{
  public class Address
  {
    private int _streetNum;
    private string _streetName;
    private string _city;
    private string _state;
    private int _zipcode;

    public Address(int streetNum, string streetName, string city, string state, int zipcode)
    {
      _streetNum= streetNum;
      _streetName= streetName;
      _city= city;
      _state= state;
      _zipcode= zipcode;
    }
  }
}
