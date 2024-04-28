using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeasAi.db
{
    public class DBObjectManager
    {
        private Guid _uuid;
        private string _title;
        private string _input;
        private string _content;
        private DateTime _dateCreated;

        public Guid UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Title cannot be null or empty.");
                }
                _title = value;
            }
        }

        public string Input
        {
            get { return _input; }
            set
            {
                _input = value;
            }
        }

        public string Content
        {
            get { return _content; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Content cannot be null or empty.");
                }
                _content = value;
            }
        }

        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { _dateCreated = value; }
        }

        public DBObjectManager()
        {
            UUID = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }
    }
}
