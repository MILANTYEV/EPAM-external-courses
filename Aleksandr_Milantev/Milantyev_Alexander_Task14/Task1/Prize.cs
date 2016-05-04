using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Prize
    {
        private const int MAX_TITLE_LENGTH = 50;
        private const int MAX_DESCRIPTION_LENGTH = 250;

        private int _id;
        private string _title;
        private string _description;

        public int ID
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Negative or null ID");
                }
                else
                {
                    _id = value;
                }
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length > MAX_TITLE_LENGTH)
                {
                    throw new ArgumentException("Length of title more than max length");
                }
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Empty title");
                }
                else
                {
                    _title = value;
                }
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (value.Length > MAX_DESCRIPTION_LENGTH)
                {
                    throw new ArgumentException("Length of description more than max length");
                }
                else
                {
                    _description = value;
                }
            }
        }

        public Prize(int id, string title, string description = "")
        {
            ID = id;
            Title = title;
            Description = description;
        }
    }
}
