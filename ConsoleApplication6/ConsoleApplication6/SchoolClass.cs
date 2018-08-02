using System;
using System.Collections.Generic;

namespace School
{
    public class SchoolClass : ISchoolClass
    {
        private string _ID;
        private List<int> _StudentNumber;

        public SchoolClass()
        {

        }

        public string Comment { get; set; }

        // Return a unique Studenet number
        protected int GetStudentNumber(int number)
        {
            if (_StudentNumber[number] == default(int) || number < 1 || number > 30)
            {
                throw new ArgumentOutOfRangeException("Invalid student number");
            }
            this._StudentNumber.Remove(number);
            return number;
        }

        public IEnumerable<Students> StudentsOfClass
        { get; set; }

        public IEnumerable<Teachers> TeachersOfClas
        { get; set; }

        public string ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this._ID = value;
            }
        }

        private void fillStudentNumberList()
        {
            for (int i = 1; i < 30; i++)
            {
                _StudentNumber.Add(i);
            }
        }
    }
}
