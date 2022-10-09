/*using System;
using System.Collections.Generic;

namespace Library;
public class UcuRideShare
{
    public UcuRideShare()
    {
        this.Passengers = new List<Passenger>();
        this.RideStatus="A ride has now been created";
        this.Driver= driver;
        this.Driver.Capacity-=1;
    }
    private Driver driver;
    public List<Passenger> Passengers {get; set;}
    public List<Driver> Drivers = new List<Driver>();
    public Driver Driver {get; set;}
    public string RideStatus {get; set;}
    public void NeedRide()
    {
        if(this.Driver==null)
        {
            Console.WriteLine("No driver has been assigned yet!");
        }
        else
        {
            Console.WriteLine("A trip was successfully created");
            this.RideStatus="On course";
        }
    }
    public int SeatsAvailable {get; set;}

    public void Add(Passenger passenger)
    {
        if(this.RideStatus.Equals("On course"))
        {
            Console.WriteLine("Error: this trips has already begun.");
        }
        else
        {
            if(person.userStatus=="Passenger" && this.Driver==null)
            {
                Console.WriteLine("No driver has started a ride yet, you will be notified when a trip is available.");
            }
            if(person.userStatus=="Driver" && this.Driver==null)
            {
                this.Driver=;
                this.SeatsAvailable= 1;
                this.Passengers.Add(person);
                Console.WriteLine($"{person.Name} {person.Surname} has created a trip!\nRating: {person.Rating}\nSeats available: {person.Capacity}\nCar data: \n{person.Vehicle.Brand} {person.Vehicle.Model}\nPlate: {person.Vehicle.Plate}\nColor: {person.Vehicle.Color} ");
            }
            if(person.userStatus=="Pool Driver" && this.Conductor==null)
            {
                this.Conductor=person;
                this.Seats= Capacity;
                this.Trip.Add(person);
                Console.WriteLine($"{person.Name} {person.Surname} has created a trip!\nRating: {person.Rating}\nSeats available: {person.Capacity}\nCar data: \n{person.Vehicle.Brand} {person.Vehicle.Model}\nPlate: {person.Vehicle.Plate}\nColor: {person.Vehicle.Color} ");
            } 
            if(person.userStatus=="Passenger" && this.Conductor!=null)
            {
                this.Trip.Add(person);
                this.Seats-=1;
                Console.WriteLine($"{person.Name} {person.Surname} has joined the ride!\nSeats available: {this.Seats}");
            }
        }
    }
}*/