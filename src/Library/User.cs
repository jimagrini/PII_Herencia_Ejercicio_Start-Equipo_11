using System;
using System.Collections.Generic;
using rate;
using vehicle;
namespace user;
public abstract class User
{
    protected User(string name, string surname, string ci)
    {
        this.Name = name;
        this.userStatus=null;        
        this.Surname= surname;
        this.Ci= ci;
        this.Rating=0;
        this.Reviews= new List<Rate>();
    }

    public abstract string userStatus {get; set;}
    public virtual int Capacity {get; set;}

    public virtual Vehicle Vehicle  {get; set;}
    public abstract List<Rate> Reviews {get; set;}
    public string Name {get; set;}
    public string Surname {get; set;}
    public string Ci {get; set;}
    public double Rating {get; set;}
}