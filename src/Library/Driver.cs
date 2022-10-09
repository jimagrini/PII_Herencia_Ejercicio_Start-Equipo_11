using System;
using System.Collections.Generic;

namespace Library;
public abstract class Driver : User
{
    public Driver(string name, string surname, string id, Vehicle vehicle, string bio) : base(name, surname, id)
    {
        this.Vehicle = vehicle;
        this.Capacity = 1;
        this.Bio = bio;
        this.DriverStatus = "Not Available";
    }

    public virtual int Capacity { get; set; }
    public string DriverStatus { get; set; }
    public UcuRide UcuRide { get; set; }
    private Vehicle vehicle;
    public Vehicle Vehicle { get; set; }
    public List<Driver> Drivers { get; set; }

    private string bio;
    public string Bio
    {
        get
        {
            return this.bio;
        }
        set
        {
            if (!String.IsNullOrEmpty(value))
            {
                this.bio = value;
            }
        }
    }
    public void NewDriver()
    {
        Drivers.Add(this);
    }
    public void Available()
    {
        this.DriverStatus= "Available";
    }
    public void NotAvailable()
    {
        this.DriverStatus= "Not Available";
    }
}