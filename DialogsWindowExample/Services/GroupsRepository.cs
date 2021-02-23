using DialogsWindowExample.Models;

namespace DialogsWindowExample.Services
{
    class GroupsRepository : RepositoryInMemory<Group>
    {
        public GroupsRepository() : base(TestData.Groups) { }

        protected override void Update(Group Source, Group Destination)
        {
            Destination.Name = Source.Name;
            Destination.Description = Source.Description;
        }
    }
}
