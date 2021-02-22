using System.Collections.Generic;

namespace DialogsWindowExample.Models
{
    internal class Group : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Student> Students { get; set; }

        public string Description { get; set; }
    }
}
