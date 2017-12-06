using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_layer
{
    class Nanny
    {

        private int id { set; get; }
        private string lastName { set; get; }
        private string firstName { set; get; }
        private DateTime birthday { set; get; }
        private int phone { set; get; }
        private string adress { set; get; }
        private bool elevator { set; get; }
        private int floor { set; get; }
        private int experience { set; get; }
        private int maxKids { set; get; }
        private int maxAge { set; get; }
        private int minAge { set; get; }
        private bool hourly_payment { set; get; }
        private double Hourly_rate { set; get; }
        private double rate_per_month { set; get; }
        private bool[] Weekly_system { set; get; }
        private TimeSpan[,] hour_system { set; get; }
        private bool HINUCH { set; get; }
        private string Recommendations { set; get; }

        //constractor
        public Nanny()
        {
            id = 123456789;
            lastName = "levi";
            firstName = "israela";
            birthday = new DateTime(1988, 12, 21);
            phone = 0527321516;
            adress = "harimon 9, zefat, israel";
            elevator = false;
            floor = 0;
            experience = 2;
            maxKids = 3;
            maxAge = 14;
            minAge = 1;
            hourly_payment = true;
            Hourly_rate = 33.3;
            rate_per_month = 5327.6;
            Weekly_system = new bool[6];
            for (int i = 0; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    Weekly_system[i] = true;
                }
                else
                {
                    Weekly_system[i] = false;
                }
            }
            hour_system = new TimeSpan[2, 6];
            for (int i = 0; i < 6; i++)
            {
                if (Weekly_system[i] == true)
                {
                    hour_system[0, i] = new TimeSpan(8, 0, 0);
                    hour_system[1, i] = new TimeSpan(16, 0, 0);
                }

            }
            HINUCH = false;
            Recommendations = "she is the best in the world";
        }
        public override string ToString()
        {
            string s = "id: " + id + "\n";
            s += "first name: " + firstName + "\n";
            s += "last name: " + lastName + "\n";
            s += "birthday: " + birthday.ToString("dd/MM/yyyy") + "\n";
            s += "phon number: " + phone + "\n";
            s += "adress: " + adress + "\n";
            s += "elevator: " + elevator + "\n";
            s += "floor: " + floor + "\n";
            s += "experience: " + experience + " Years \n";
            s += "maximum kids: " + maxKids + "\n";
            s += "maximum age: " + maxAge + " month \n";
            s += "minimum age: " + minAge + " month \n";
            s += "getting hourly payment: " + hourly_payment + "\n";
            s += "rate per hour: " + Hourly_rate + "\n";
            s += "rate per month: " + rate_per_month + "\n";
            s += "work days: " + "\n";
            s += "\t" + "sunday: " + Weekly_system[0] + "\n";
            s += "\t" + "monday: " + Weekly_system[1] + "\n";
            s += "\t" + "Tuesday: " + Weekly_system[2] + "\n";
            s += "\t" + "Wednesday: " + Weekly_system[3] + "\n";
            s += "\t" + "Thursday: " + Weekly_system[4] + "\n";
            s += "\t" + "Friday: " + Weekly_system[5] + "\n";
            s += "work hours: " + "\n";
            s += "\t" + "sunday: " + "\t" + "monday: " + "\t" + "Tuesday: " + "\t" + "Wednesday: " + "\t" + "Thursday: " + "\t" + "Friday: " + "\n";
            s += "\t";
            for (int i = 0; i < 6; i++)
            {
                s += hour_system[0, i] + " " + "\t";
            }
            s += "\n";
            s += "\t";
            for (int i = 0; i < 6; i++)
            {
                s += hour_system[1, i] + " " + "\t";
            }
            s += "\n";
            s += "Employee of the Ministry of Education: " + HINUCH + "\n";
            s += "Recommendations: " + Recommendations + "\n";
            return s;

        }

    }
}
