using System;
using System.Collections.Generic;
using user;
using vehicle;
using rate;
namespace driver;
public  class PoolDriver: Driver
{
    public PoolDriver(string name, string surname, string id, Vehicle vehicle, int capacity, string bio): base(name, surname, id, vehicle, bio)
    {
        this.Bio=bio;
        this.Vehicle=vehicle;
        this.Capacity=capacity;
        this.userStatus="Pool Driver";
    }

    public override string userStatus { get; set; }
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
    public string Identifier {get; set;}
}