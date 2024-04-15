﻿using prjVeículos.Builders;
using prjVeículos.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjVeículos.Directors
{
    class Director
    {
        IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck() 
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.MANUAL);
        }
    }
}
