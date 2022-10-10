using System;
using System.Collections.Generic;

namespace Library;
public class UcuRide
{
    public UcuRide(Driver driver)
    {
        this.Passengers = new List<User>();
        this.RideStatus = "Vacio";
        this.Driver = driver;
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
        bool trip = false;
        foreach (Driver driver in Drivers)
        {
            if (driver.Capacity > 0 && driver.DriverStatus.Equals("Disponible"))
            {

                if (driver.UcuRide.RideStatus.Equals("Vacio"))
                {
                    driver.UcuRide = new UcuRide(driver);
                    driver.UcuRide.Passengers.Add(passenger);
                    Console.WriteLine($"¡{driver.Name} {driver.Surname} ha creado un viaje con {passenger.Name} {passenger.Surname}!\nRating: {driver.Rating}\nAsientos disponibles: {driver.Capacity}\nVehiculo: {driver.Vehicle.Brand} {driver.Vehicle.Model}\nMatricula: {driver.Vehicle.Plate}\nColor: {driver.Vehicle.Color}\n");
                    driver.Capacity -= 1;
                    driver.Full();
                    driver.Trip();
                    trip = true;
                    break;
                }
                //   Tiene lugares disponibles pero ya se encuentra en un viaje creado 
                else
                {
                    driver.UcuRide.Passengers.Add(passenger);
                    Console.WriteLine($"¡{passenger.Name} {passenger.Surname} se ha unido al viaje de {driver.Name} {driver.Surname}!");
                    Console.WriteLine($"Rating: {driver.Rating}\nAsientos disponibles: {driver.Capacity}\nVehiculo: {driver.Vehicle.Brand} {driver.Vehicle.Model}\nMatricula: {driver.Vehicle.Plate}\nColor: {driver.Vehicle.Color}\n");
                    driver.Capacity -= 1;
                    driver.Full();
                    driver.Trip();
                    trip = true;
                    break;
                }
            }
        }
        if (!trip)
        {
            Console.WriteLine("Actualmente no hay conductores disponibles.\n");
        }
    }
    public void RideFinished()
    {
        this.RideStatus = "Viaje finalizado";
        //Se intuye que ya el driver ya no estara disponible luego de haber llegado al destino
        this.Driver.NotAvailable();
    }

    public void DriverRate(double driverRate, string driverDescription)
    {
        Rate DriverRate = new Rate(this.Driver, driverRate, driverDescription);
    }
    public void PassengerRate(Passenger passenger, double passengerRate, string passengerDescription)
    {
        Rate PassengerRate = new Rate(passenger, passengerRate, passengerDescription);
    }
}