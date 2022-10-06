using System;
namespace vehicle;
public class Vehicle
{
    public Vehicle(string brand, string model, string plate, int year, string color)
    {
        this.Brand=brand;
        this.Model=model;
        this.Plate=plate;
        this.Year=year;
        this.Color=color;
    }

    private string color;
    private string brand;
    private string model;
    private string plate;
    private int year;

    public string Color {get; set;}
    public string Brand
    {
        get
        {
            return this.brand;
        }
        set
        {
            if(!String.IsNullOrEmpty(value))
            {
                this.brand=value;
            }
        }
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if(!String.IsNullOrEmpty(value))
            {
                this.model=value;
            }
        }
    }

    public string Plate
    {
        get
        {
            return this.plate;
        }
        set
        {
            if(!String.IsNullOrEmpty(value))
            {
                this.plate=value;
            }
        }
    }

    public int Year {get; set;}
}