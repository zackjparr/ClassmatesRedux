using System;
using System.Collections.Generic;
using System.Text;

namespace ClassmatesRedux
{
    class Students
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Hometown { get; set; }
        public string Food { get; set; }
        public string Wrestler { get; set; }

        public Students(int StudentID, string Name, string Hometown, string Food, string Wrestler)
        {
            this.StudentID = StudentID;
            this.Name = Name;
            this.Hometown = Hometown;
            this.Food = Food;
            this.Wrestler = Wrestler;
        }
    }
}
