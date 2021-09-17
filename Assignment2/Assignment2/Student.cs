using System;

namespace Assignment2
{
    public class Student
    {
        private int id;
        public string GivenName;
        string Surname;
        public Status status{get;}
        DateTime StartDate;
        DateTime EndDate;
        DateTime GraduationDate;

        public Student(int id, string GivenName, string Surname) {
            this.id = id;
            this.GivenName = GivenName;
            this.Surname = Surname;
            this.status = Status.New;
        }

        public string ToString() {
           return $"{this.id} {this.GivenName} {this.Surname}";
        }
    
    }

public enum Status {
    New,
    Active,
    Dropout,
    Graduated
}

}
