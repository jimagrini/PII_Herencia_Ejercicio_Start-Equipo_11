using System;
using System.Collections;
using Library;
using TwitterUCU;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle driversCar = new Vehicle("Chevrolet","Onix","SBU 9331", 2020, "Gris");

            Passenger keke = new Passenger("Christian","Almeida", "1234567",@"estudiant.png");
            TwitterPrinter.NewPassenger(keke);

            Driver izquierdo = new PoolDriver("Juan","Izquierdo", "1234537", driversCar, 2, "Mi nombre es Juan Izquierdo, soy funcionario en la facultad, vivo en el barrio Prado.","png-clipart-car-cartoon-car-cartoon-character-compact-car.png");
            izquierdo.NewDriver();
            TwitterPrinter.NewVolunteerDriver(izquierdo);
            izquierdo.Available();

            UcuRide.MyDriver(keke);

            Passenger ginella= new Passenger("Francisco","Ginella", "1234568","");
            TwitterPrinter.NewPassenger(ginella);
            UcuRide.MyDriver(ginella);

            Passenger carballo= new Passenger("Felipe","Carballo", "1234569","estudiant.png");
            TwitterPrinter.NewPassenger(carballo);
            UcuRide.MyDriver(carballo);

            Driver rochet= new Driver("Sergio", "Rochet", "87654321", new Vehicle("Toyota","Corola","SBU 9332", 2014, "Negro"), "Tengo muy buenos reflejos","bill2.jpg");
            rochet.NewDriver();
            TwitterPrinter.NewVolunteerDriver(rochet);
            rochet.Available();

            UcuRide.MyDriver(carballo);
            
            Rate kekeRate = new Rate(keke,4,"macanudo e interesante");
            Console.WriteLine($"La calificación de {keke.Name} {keke.Surname} es de {keke.Rating}.");

            Rate izquierdoRate = new Rate(izquierdo,4.2,"buen conductor");  
            Console.WriteLine($"La calificación de {izquierdo.Name} {izquierdo.Surname} es de {izquierdo.Rating}.");

            

            /*En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

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
