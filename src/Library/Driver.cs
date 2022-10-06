using System;
using System.Collections.Generic;
using user;
using vehicle;
using rate;
namespace driver;
public  abstract class Driver: User
{
    public Driver(string name, string surname, string id, Vehicle vehicle , string bio): base(name, surname, id)
    {
        this.userStatus="Driver";
        this.Vehicle=vehicle;
        this.Capacity=1;
        this.Bio=bio;
    }

    public virtual int Capacity {get; set;}
    private Vehicle vehicle;
    public Vehicle Vehicle {get; set;}

    private string bio;
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

}