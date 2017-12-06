using System;
using System.Collections.Generic;
using System.Text;

namespace BE_layer
{
    class Mother
    {
        private int id { set; get; }
        private string firstName { set; get; }
        private string lastName { set; get; }
        private int phone { set; get; }
        private string adress { set; get; }
        private string around { set; get; }
        private bool [] work_day { set; get; }
        private TimeSpan[,] nanny_needed  { set; get; }
        private string remarks { set; get; }

        //constractor
        public Mother()
        {
            id = 123456789;
            lastName = "shoam";
            firstName = "pazit";
            phone = 0528361516;
            adress = "zabutinsky 19, tel aviv, israel";
            around = "harimon 5, tel aviv, israel";
            work_day = new bool[6];
            for (int i = 0; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    work_day[i] = true;
                }
                else
                {
                    work_day[i] = false;
                }
            }
            nanny_needed = new TimeSpan[2, 6];
            for (int i = 0; i < 6; i++)
            {
                if (work_day[i] == true)
                {
                    nanny_needed[0, i] = new TimeSpan(8, 0, 0);
                    nanny_needed[1, i] = new TimeSpan(16, 0, 0);
                }

            }
            remarks = "she needs an apple every hour";
        }
        public override string ToString()
        {
            string s = "id: " + id + "\n";
            s += "first name: " + firstName + "\n";
            s += "last name: " + lastName + "\n";
            s += "phon number: " + phone + "\n";
            s += "adress: " + adress + "\n";
            s += "looking around: " + around + "\n";                                             
            s += "work days: " + "\n";
            s += "\t" + "sunday: " + work_day[0] + "\n";
            s += "\t" + "monday: " + work_day[1] + "\n";
            s += "\t" + "Tuesday: " + work_day[2] + "\n";
            s += "\t" + "Wednesday: " + work_day[3] + "\n";
            s += "\t" + "Thursday: " + work_day[4] + "\n";
            s += "\t" + "Friday: " + work_day[5] + "\n";
            s += "work hours: " + "\n";
            s += "\t" + "sunday: " + "\t" + "monday: " + "\t" + "Tuesday: " + "\t" + "Wednesday: " + "\t" + "Thursday: " + "\t" + "Friday: " + "\n";
            s += "\t";
            for (int i = 0; i < 6; i++)
            {
                s += nanny_needed[0, i] + " " + "\t";
            }
            s += "\n";
            s += "\t";
            for (int i = 0; i < 6; i++)
            {
                s += nanny_needed[1, i] + " " + "\t";
            }
            s += "\n";           
            s += "remarks: " + remarks + "\n";
            return s;
        }

    }
}
