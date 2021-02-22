using DialogsWindowExample.Models;

namespace DialogsWindowExample.Services
{
    class GroupRepository : RepositoryInMemory<Group>
    {
        protected override void Update(Group Source, Group Destination)
        {
            Destination.Name = Source.Name;
            Destination.Description = Source.Description;
        }
    }
}
