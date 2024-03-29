using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasAi.db
{
    public class DBObjectManager
    {
        public Guid UUID { get; set; }
        public string Title { get; set; }
        public string Input { get; set; }
        public string Content { get; set; }

        public DateTime DateCreated;

        public DBObjectManager() {
            this.UUID = Guid.NewGuid();
            this.DateCreated = DateTime.Now;
        }
    }
}
