using System;
using System.Collections.Generic;

namespace Library;
public abstract class User
{
    protected User(string name, string surname, string id, string photoPath)
    {
        this.Name = name;
        this.Surname = surname;
        this.Id = id;
        this.Rating = 0;
        this.Reviews = new List<Rate>();
        this.PhotoPath = photoPath;
    }
    public string PhotoPath{get;set;}
    public List<Rate> Reviews { get; set; }
    private string name;
    private string surname;
    private string id;
    public double Rating { get; set; }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (!String.IsNullOrEmpty(value))
            {
                this.name = value;
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
            if (!String.IsNullOrEmpty(value))
            {
                this.id = value;
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
            if (!String.IsNullOrEmpty(value))
            {
                this.surname = value;
            }
        }
    }
}