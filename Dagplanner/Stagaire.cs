﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagplanner
{
    public class Stagaire : Werknemer
    {
        private int daysLeft;

        public Stagaire(int id, string firstName, string lastName, int isFulltime, int daysLeft) : base(id, firstName, lastName, isFulltime)
        {
            this.daysLeft = daysLeft;
        }
        public int GetDaysLeft()
        {
            return daysLeft;
        }
        public override string ToString()
        {
            return base.ToString() + $" ({daysLeft} dagen)";
        }
    }
}
