using System;
using System.Collections.Generic;

namespace Library;
public class Passenger : User
{
    public Passenger(string name, string surname, string id): base(name, surname, id)
    {
        this.Name=name;
        this.Surname=surname;
        this.Id=id;
    }
    /*public static void MePassenger()
    {
        ///  Implementa el metodo estatico de UcuRide el cual busca choferes con asientos disponibles, 
        /// y de encontrarlos crea una instancia de dicha clase, a la cual le asigna el chofer encontrado y el pasajero.
        UcuRide.MyDriver(this);
    }*/
    public void MePassenger()
    {
        UcuRide.MyDriver(this);
    }
}