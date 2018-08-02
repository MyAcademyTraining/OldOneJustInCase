using System;

namespace School
{

    public class Students : SchoolClass, IPerson
    {
        private int _Age;
        private string _Name;
        private int _StudentNumber;


        public Students(string name, int age,int StudentNumber)
        {
            AgeValidator(age);
            this._Age = age;
            NameValidator(name);
            this._Name = name;
            // Get a Student Number from SchoolClass class
            this._StudentNumber = GetStudentNumber(StudentNumber);
        }

        public string Comment { get; set; }

        public int StudentNumber
        {
            get
            {
                return this._StudentNumber;
            }
        }


        int IPerson.Age
        {
            get
            {
                return this._Age;
            }
            set
            {
                AgeValidator(value);
                this._Age = value;
            }
        }

        string IPerson.Name
        {
            get
            {
                return this._Name;
            }
        }

        private void AgeValidator(int age)
        {
            if (age <= 20)
            {
                throw new ArgumentOutOfRangeException("This is not a proper age for a student");
            }
        }

        private void NameValidator(string name)
        {
            if (name == "" || name == default(string))
            {
                throw new ArgumentOutOfRangeException($"This is not a proper name for a {this.GetType()}");
            }
        }


    }
}
