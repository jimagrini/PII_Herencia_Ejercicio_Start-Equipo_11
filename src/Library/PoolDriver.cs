using System;
using System.Collections.Generic;
using user;
using vehicle;
using rate;
namespace driver;
public  class PoolDriver: User
{
    public PoolDriver(string name, string surname, string ci, Vehicle vehicle, int capacity, string bio): base(name, surname, ci)
    {
        this.Bio=bio;
        this.Vehicle=vehicle;
        this.Capacity=capacity;
        this.userStatus="Driver";
    }

    public override string userStatus { get; set; }
    private Vehicle vehicle;
    private string bio;

    private int capacity;

    private int rating;

    public override List<Rate> Reviews {get; set;}

    public override Vehicle Vehicle {get; set;}

    public override int Capacity
    {
        get
        {
            return this.capacity;
        }
        set
        {
            if(value>0)
            {
                this.capacity=value;
            }
        }
    }

    public string Bio
    {
        get
        {
            return this.bio;
        }
        set
        {
            if(!String.IsNullOrEmpty(value))
            {
                this.bio=value;
            }
        }
    }
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
    public string Identifier {get; set;}

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