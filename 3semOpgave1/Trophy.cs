using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _3semOpgave1
{
    public class Trophy
    {
        public int Id { get; private set; }
        public string Competition { get; set; }
        public int Year { get; set; }

        public Trophy(string competition, int year)
        {
            Competition = competition;
            Year = year;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public bool ValidateCompetition()
        {
            if(Competition.Length < 3) 
            {
                throw new ArgumentOutOfRangeException("This competitions name is too short, and therefor invalid");
            }
            return true;
        }
        public bool ValidateYear() 
        {
            if(Year < 1970) 
            {
                throw new ArgumentOutOfRangeException("This is not a valid year. It's way too early");
            }
            if(Year > 2024)
            {
                throw new ArgumentOutOfRangeException("This is not a valid year. This year hasnt happened yet, are you a time traveler?");
            }
            return true;
            
        }
        public bool ValidateAll()
        {
            if (!ValidateCompetition() || !ValidateYear())
            {
                throw new Exception("This Trophy is invalid");
            }

            return true;
        }

        public override string ToString()
        {
            return $"This Trophy was won in {Year}, in the competition {Competition}. It's unique Id is {Id}";
        }
        /*

        Tilføj en unit test til dit projekt.

        Din unit test skal have et godt “Code Coverage”
            */
    }
}
