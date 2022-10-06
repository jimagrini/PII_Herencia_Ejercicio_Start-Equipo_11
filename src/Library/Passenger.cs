using System;
using System.Collections.Generic;
using user;
using rate;
namespace passenger;
public  class Passenger : User
{
    public Passenger(string name, string surname, string id): base(name, surname, id)
    {
        this.userStatus="Passenger";
    }

    public override string userStatus {get; set;}

}