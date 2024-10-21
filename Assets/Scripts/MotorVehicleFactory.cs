using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorVehicleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        //if (requirements.NumberOfWheels > 0 && requirements.NumberOfWheels < 3) return new MotorBikeFactory().Create(requirements);
        //if we want fame, and choose item 1 

        if (requirements.HasEngine ==  true && requirements.NumberOfWheels == 1)
        {
            //if we dont select true love
            if (requirements.HasCargo == false)
            {
                return new Settle();

            }

        }

        //if true love and item 2 
        if (requirements.NumberOfWheels == 2)
        {
            if(requirements.HasEngine == true && requirements.HasCargo == false)
            {
                return new Job();
            }
            else if (requirements.HasCargo == true && requirements.HasEngine == false)
            {
                return new Dice();
            }

        }
        //if true love and item 2 
        if (requirements.NumberOfWheels == 3)
        {
            if (requirements.HasEngine == true && requirements.HasCargo == false)
            {
                return new Spirit();
            }
            else if (requirements.HasCargo == true && requirements.HasEngine == false)
            {
                return new Skull();
            }

        }
        if (requirements.HasEngine == true && requirements.HasCargo == true)
        {
            return new Greedy();
        }

        switch (requirements.NumberOfWheels)
        {
            case 1:
                return new Become();
            case 2:
                return new Dice();
            case 3:
                return new Skull();
            default:
                return new Truck();
        }

    }
}
