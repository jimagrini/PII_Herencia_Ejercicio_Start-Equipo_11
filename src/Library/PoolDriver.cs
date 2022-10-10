using System;
using System.Collections.Generic;

namespace Library;
public class PoolDriver: Driver
{
    public PoolDriver(string name, string surname, string id, Vehicle vehicle, int capacity, string bio,string photoPath): base(name, surname, id, vehicle, bio, photoPath)
    {
        this.Capacity=capacity;
       
    }
    private int capacity;
    public override int Capacity
    {
        get
        {
            return this.capacity;
        }
        set
        {
            if(value>0)
            {
                this.capacity=value;
            }
        }
    }
}