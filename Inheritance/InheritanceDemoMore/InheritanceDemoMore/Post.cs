using System;
namespace InheritanceDemoMore
{
	public class Post
	{
		private static int currentPostID;

		protected int ID { get; set; }
		protected string Title { get; set; }
		protected string SendByUsername { get; set; }
		public bool IsPublic { get; set; }


		public Post()
		{
			ID = 0;
			Title = "My First Post";
			IsPublic = true;
			SendByUsername = "Denis Panjuta";
		}

		//Instance constructor that has three parameters
		public Post(string title,bool isPublic,string sendByUsername)
		{
			this.ID = GetNextId();
			this.Title = title;
			this.SendByUsername = sendByUsername;
			this.IsPublic = isPublic;
		}
		protected int GetNextId()
		{
			return ++currentPostID;
		}
		public void Update(string title,bool isPublic)
		{
			this.Title = title;
			this.IsPublic = isPublic;
		}
        public virtual string ToString()
        {
            return String.Format("{0} - {1} - by {2}",this.ID,this.Title,this.SendByUsername);
        }
    }
}

