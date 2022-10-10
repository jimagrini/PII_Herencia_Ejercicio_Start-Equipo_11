using System;
using System.Collections.Generic;
using TwitterUCU;

namespace Library;
public abstract class TwitterPrinter
{
    public static void NewVolunteerDriver(Driver driver)
    {
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter($"Bienvenido  {driver.Name} a la plataforma Ucu RideShare!! Gracias por prestar tus servicios como conductor",driver.PhotoPath));
    }
    public static void NewPassenger(Passenger Passenger)
    {
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter($"Bienvenido  {Passenger.Name} a la plataforma Ucu RideShare como pasajero!! disfruta tus proximos viajes!! ",Passenger.PhotoPath));
    }

}    
