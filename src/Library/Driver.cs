using System;
using System.Collections.Generic;
using user;
using vehicle;
using rate;
namespace driver;
public  abstract class Driver: User
{
    public Driver(string name, string surname, string ci, Vehicle vehicle , string bio): base(name, surname, ci)
    {
        this.Bio=bio;
        this.userStatus="Driver";
        this.Vehicle=vehicle;
        this.Capacity=1;
    }

    public override int Capacity {get; set;}
    private Vehicle vehicle;
    private string bio;

    private int rating;

    public override List<Rate> Reviews {get; set;}

    public override Vehicle Vehicle {get; set;}

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