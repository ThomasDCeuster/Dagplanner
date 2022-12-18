using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagplanner
{
    public class Werknemer
    {
        private int id;
        private string firstName;
        private string lastName;
        private bool isFulltime;
        private bool isStagair;

        public Werknemer(int id, string firstName, string lastName, int isFulltime)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            switch (isFulltime)
            {
                case 0:
                    this.isFulltime = true;
                    this.isStagair = false;
                    break;
                case 1:
                    this.isStagair = false;
                    this.isFulltime = false;
                    break;
                case 2:
                    this.isStagair = true;
                    this.isFulltime = false;
                    break;
            }
        }
        public int getId() { return id; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public bool getIsFulltime() { return isFulltime; }
        public bool getIsStagaire() { return isStagair; }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
        

    }
}
