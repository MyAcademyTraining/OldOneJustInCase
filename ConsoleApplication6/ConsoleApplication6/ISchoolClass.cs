using System.Collections.Generic;

namespace School
{
    public interface ISchoolClass
    {
         IEnumerable<Teachers> TeachersOfClas { get; set; }
         IEnumerable<Students> StudentsOfClass { get; set; }
    }
}
