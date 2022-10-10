using System;
using System.Collections.Generic;

namespace Library;
public class Driver : User
{
    public Driver(string name, string surname, string id, Vehicle vehicle, string bio, string photoPath) : base(name, surname, id, photoPath)
    {
        this.Vehicle = vehicle;
        this.Capacity = 1;
        this.Bio = bio;
        this.DriverStatus = "Disponible";
        this.UcuRide= new UcuRide(this);
        TwitterPrinter.NewVolunteerDriver(this);
    }

    public virtual int Capacity { get; set; }
    public string DriverStatus { get; set; }
    public UcuRide UcuRide { get; set; }
    private Vehicle vehicle;
    public Vehicle Vehicle { get; set; }

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
        UcuRide.Drivers.Add(this);
    }
    public void Available()
    {
        this.DriverStatus= "Disponible";
    }
    public void NotAvailable()
    {
        this.DriverStatus= "Ocupado";
    }
}