using DialogsWindowExample.Models;
using System.Linq;

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

        // Ищет первую попавшуюся группу с указанным именем
        public Group Get(string groupName) => GetAll().FirstOrDefault(g => g.Name == groupName);
    }
}
