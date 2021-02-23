using DialogsWindowExample.Models;
using System.Collections.Generic;

namespace DialogsWindowExample.Services
{
    class StudentsManager
    {
        private readonly StudentsRepository students;
        private readonly GroupsRepository groups;

        public StudentsManager(StudentsRepository students, GroupsRepository groups)
        {
            this.students = students;
            this.groups = groups;
        }

        public IEnumerable<Student> Students => students.GetAll();

        public IEnumerable<Group> Groups => groups.GetAll();
    }
}
