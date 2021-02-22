using DialogsWindowExample.Models;

namespace DialogsWindowExample.Services
{
    class GroupsRepository : RepositoryInMemory<Group>
    {
        protected override void Update(Group Source, Group Destination)
        {
            Destination.Name = Source.Name;
            Destination.Description = Source.Description;
        }
    }
}
