using System;
using System.Collections.Generic;
using rate;
using vehicle;
namespace user;
public abstract class User
{
    protected User(string name, string surname, string id)
    {
        this.Name = name;
        this.userStatus=null;        
        this.Surname= surname;
        this.Id= id;
        this.Rating=0;
        this.Reviews= new List<Rate>();
    }

    public abstract string userStatus {get; set;}
    public List<Rate> Reviews {get; set;}
    private string name;
    private string surname;
    private string id;
    public double Rating {get; set;}
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

    public string Id
    {
        get
        {
            return this.id;
        }
        set
        {
            if(!String.IsNullOrEmpty(value))
            {
                this.id=value;
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