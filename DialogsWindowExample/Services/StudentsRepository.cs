using DialogsWindowExample.Models;

namespace DialogsWindowExample.Services
{
    class StudentsRepository : RepositoryInMemory<Student>
    {
        protected override void Update(Student Source, Student Destination)
        {
            Destination.Name = Source.Name;
            Destination.Surname = Source.Surname;
            Destination.Patronymic = Source.Patronymic;
            Destination.Rating = Source.Rating;
            Destination.Birthday = Source.Birthday;
        }
    }
}
