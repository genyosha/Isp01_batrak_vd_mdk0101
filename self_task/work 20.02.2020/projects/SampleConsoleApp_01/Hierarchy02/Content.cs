using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batrak_20._02.Hierarchy02
{
    abstract class Content
    {
        private int id;
        private string name;
        private DateTime uploadDate;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime UploadDate
        {
            get { return uploadDate; }
            set { uploadDate = value; }
        }

        public Content(int id, string name, DateTime uploadDate)
        {
            this.id = id;
            this.name = name;
            this.uploadDate = uploadDate;
        }

        public override string ToString()
        {
            return "ID: " + id + "Name: " + name + "UploadDate: " + UploadDate;
        }
    }
}
