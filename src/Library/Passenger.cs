using System;
using System.Collections.Generic;
using user;
using rate;
namespace passenger;
public  class Passenger : User
{
    public Passenger(string name, string surname, string ci): base(name, surname, ci)
    {
        this.userStatus="Passenger";
    }

    public override string userStatus {get; set;}

    private int rating;
    public int Rating 
    {
        get
        {
            return this.rating;
        }
        set
        {
            if(value!=null)
            {
                this.rating=value;
            }
        }
    }
    private string ci;

    private string surname;
    private string name;

    public override List<Rate> Reviews {get; set;}
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if(!String.IsNullOrEmpty(value))
            {
                this.name=value;
            }
        }
    }

    public string Ci
    {
        get
        {
            return this.ci;
        }
        set
        {
            if(!String.IsNullOrEmpty(value))
            {
                this.ci=value;
            }
        }
    }

    public string Surname
    {
        get
        {
            return this.surname;
        }
        set
        {
            if(!String.IsNullOrEmpty(value))
            {
                this.surname=value;
            }
        }
    }

}