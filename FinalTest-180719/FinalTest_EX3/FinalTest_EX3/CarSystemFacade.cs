﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest_EX3
{
    public class CarSystemFacade : ICarActions, ICarShowStatus
    {
        CarDAO myCarDAO = new CarDAO();

        public void StartDrive()
        {
            myCarDAO.StartDriving();
        }

        public void EndDrive()
        {
            myCarDAO.EndDriving();
        }

        public void IncreaseSpeed()
        {
            myCarDAO.IncreaseSpeedOfCar();
        }

        public void DecreaseSpeed()
        {
            myCarDAO.DecreaseSpeedOfCar();
        }

        public void TurnRight()
        {
            myCarDAO.TurningRight();
        }

        public void TurnLeft()
        {
            myCarDAO.TurningLeft();
        }

        public void ShowFuel()
        {
            myCarDAO.ShowStateOfFuel();
        }

        public void ShowLocation()
        {
            myCarDAO.ShowMyLocation();
        }
    }
}
