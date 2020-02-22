using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batrak_20._02.Hierarchy02
{
    class Photo : Content
    {
        private string whoIsOnPicture;

        public string WhoIsOnPicture
        {
            get { return whoIsOnPicture; }
            set { whoIsOnPicture = value; }
        }
            
        public Photo(int id, string name, DateTime uploadDate,
            string whoIsOnPicture) : base(id, name, uploadDate)
        {
            this.whoIsOnPicture = whoIsOnPicture;
        }

        public override string ToString()
        {
            return "Who is on picture: " + whoIsOnPicture;
        }
    }
}
