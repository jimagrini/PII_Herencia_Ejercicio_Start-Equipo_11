using System;
using System.Collections;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle driversCar = new Vehicle("Chevrolet","Onix","SBU 9331", 2020, "Gris");

            User keke = new Passenger("Christian","Almeida", "1234567");

            Driver izquierdo = new PoolDriver("Juan","Izquierdo", "1234537", driversCar, 2, "Mi nombre es Juan Izquierdo, soy funcionario en la facultad, vivo en el barrio Prado.");

            izquierdo.NewDriver();
            izquierdo.Available();

            UcuRide.MyDriver(keke);

            User ginella= new Passenger("Francisco","Ginella", "1234568");
            UcuRide.MyDriver(ginella);

            User carballo= new Passenger("Felipe","Carballo", "1234569");
            UcuRide.MyDriver(carballo);

            //UcuRideShare rideShare = new UcuRideShare();

            //rideShare.Add(driver);
            //rideShare.Add(passenger);

            /*
            Rate drivertopassenger = new Rate(passenger,4,"estudiante amable");

            Rate passengerToDriver = new Rate(driver,5,"buen conductor");

            Console.WriteLine(driver.Rating);
            Console.WriteLine(passenger.Rating);

            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
        }
    }
}
