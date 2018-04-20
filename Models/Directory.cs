using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AddressLookup.Models
{
  public class Directory
  {
    private int _listID;
    private static List<Contact> _myContacts = new List<Contact>();

    public void Save()
    {
      _myContacts.Add(this);
      _listID= _myContacts.Count;
    }

    public int GetID()
    {
      return _listID;
    }

    public static void DeleteContact(int id)
    {
      _myContacts.RemoveAt(id-1);
      //deletes id num place along with deleted contact
      for(int c=0; c<_myContacts.Count; c++)
      {
        _myContacts[c].listID= c+1;
        //recount incrementally after removal
      }
    }

    public static Contact ContactDetails()
    {
      return _fullAddress;
    }
    
    public static List<Contact> GetAllContacts()
    {
      return _myContacts;
    }

    public static Contact Find(int id)
    {
      return _myContacts[id-1];
      //find individual Contact by assigned idNum
      // id-1 to account for index starting 0
    }

    public static void DeleteAllContacts()
    {
      _myContacts.Clear();
      //deletes the entire Address Lookup
    }
  }
}
