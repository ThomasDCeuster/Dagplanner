using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagplanner
{
    public class Database
    {
        public int id;
        public string voornaam;
        public string achternaam;
        public int isFulltime;
        public int dagen;

        public Database() { }
        public Database(int id, string voornaam, string achternaam, int isFulltime, int dagen)
        {
            this.id = id;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.isFulltime = isFulltime;
            this.dagen = dagen;
        }

        public int getId() { return id; }
        public string getFirstname() { return voornaam; }
        public string getLastname() { return achternaam; }
        public int getIsFulltime() { return isFulltime;}
        public int getDays() { return dagen; }

        public override string ToString()
        {
            return voornaam + " " + achternaam;
        }


    }
}
