using System.Collections.Generic;

namespace School
{
    public abstract class Discipline
    {
        string name { get; set; }
        IEnumerable<Teachers> TeacherForDiscipline { get; set; }
        IEnumerable<int> NumberOfExercises { get; set; }
        public string Comment { get; set; }
    }
}
