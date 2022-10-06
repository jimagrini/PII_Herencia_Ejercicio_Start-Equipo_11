using System;
using System.Collections.Generic;
using rate;
using user;
using passenger;
using driver;
namespace socialmedia;
public class UcuRideShare
{
    public List<User> Trip {get; set;}

    public User Conductor {get; set;}
    public UcuRideShare()
    {
        this.Trip = new List<User>();
        this.rideStatus="Not started";
        this.Conductor= null;
        this.Seats=0;
    }

    public string rideStatus {get; set;}
    public void StartRide()
    {
        if(this.Conductor==null)
        {
            Console.WriteLine("No driver has been assigned yet!");
        }
        else
        {
            Console.WriteLine("A trip was successfully created");
            this.rideStatus="On course";
        }
    }

    public int Seats {get; set;}

    public void Add(User person)
    {
        if(this.rideStatus.Equals("On course"))
        {
            Console.WriteLine("Error: this trips has already begun.");
        }
        else
        {
            if(person.userStatus=="Passenger" && this.Conductor==null)
            {
                Console.WriteLine("No driver has started a ride yet, you will be notified when a trip is available.");
            }
            if(person.userStatus=="Driver" && this.Conductor==null)
            {
                this.Conductor=person;
                this.Seats= 1;
                this.Trip.Add(person);
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
}