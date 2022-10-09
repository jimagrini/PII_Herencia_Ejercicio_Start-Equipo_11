using System;
using System.Collections.Generic;

namespace Library;
public class Rate
{
    public Rate(User person, double rating, string description)
    {
        this.Rating = rating;
        this.Description = description;
        person.Reviews.Add(this);
        TotalRating(person);
    }

    User person;
    private string description;
    public string Description
    {
        get
        {
            return this.description;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.description = value;
            }
        }
    }
    private double rating;
    public double Rating
    {
        get
        {
            return this.rating;
        }
        set
        {
            if (value <= 5)
            {
                this.rating = value;
            }
        }
    }
    public static void TotalRating(User person)
    {
        double allRates = 0;
        int rateCtr = 0;
        foreach (Rate rate in person.Reviews)
        {
            allRates += rate.Rating;
            rateCtr += 1;
        }
        double finalRate = allRates / rateCtr;
        person.Rating = finalRate;
    }
}