using System;
using System.Collections.Generic;

namespace Library;
public class UcuRide
{
    public UcuRide(Driver driver)
    {
        this.Passengers = new List<User>();
        this.RideStatus = "A ride has now been created";
        this.Driver = driver;
        this.Driver.Capacity -= 1;
    }
    private Driver driver;
    public string RideStatus { get; set; }
    public List<User> Passengers { get; set; }
    public static List<Driver> Drivers = new List<Driver>();
    public Driver Driver { get; set; }

    /// <summary>
    /// Metodo que busca choferes disponibles y crea instancias de UcuRide
    /// </summary>
    /// <param name="passenger"></param>
    public static void MyDriver(User passenger)
    {
        foreach (Driver driver in Drivers)
        {
            if (driver.Capacity >= 1 && driver.DriverStatus != "Not Available")
            {
                if (driver.DriverStatus.Equals("Available"))
                {
                    UcuRide myRide = new UcuRide(driver);
                    driver.UcuRide = myRide;
                    myRide.Passengers.Add(passenger);
                    Console.WriteLine(myRide.RideStatus);
                    break;
                }
                //   Tiene lugares disponibles pero ya se encuentra en un viaje creado 
                else
                {
                    driver.UcuRide.Passengers.Add(passenger);
                    driver.Capacity -= 1;
                    break;
                }
            }
            else{Console.WriteLine("No hay conductores disponibles");}
        }
    }
    public void RideFinished()
    {
        this.RideStatus = "This ride has finished";
        //Se intuye que ya el driver ya no estara disponible luego de haber llegado al destino
        this.Driver.NotAvailable();
    }
    public void DriverRate (double driverRate, string driverDescription)
    {
        Rate DriverRate= new Rate (this.Driver, driverRate, driverDescription);
    }
    public void PassengerRate (Passenger passenger, double passengerRate, string passengerDescription)
    {
        Rate PassengerRate= new Rate (passenger, passengerRate, passengerDescription);
    }
}