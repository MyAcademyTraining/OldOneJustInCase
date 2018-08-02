using System;
using System.Collections.Generic;

namespace School
{
    public class Teachers :  IPerson
    {
        private int _Age;
        private string _Name;
        private List<Discipline> _Disciliplines;

        public Teachers(int age, string name, List<Discipline> Disciplines)
        {
            AgeValidator(age);
            this._Age = age;
            NameValidator(name);
            this._Name = name;

            this._Disciliplines = Disciplines;
        }

        public string Comment { get; set; }

        public List<Discipline> MyProperty
        {
            get
            {
                return this._Disciliplines;
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
                throw new ArgumentOutOfRangeException("This is not a proper age for a teacher");
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
