using System;
namespace InheritanceDemoMore
{
    public class ImagePost : Post
    {
        public string ImageUrl { get; set; }

        public ImagePost()
        {
        }
        //public ImagePost(string title, string sendByUsername, string imageUrl, bool isPublic)
        //{
        //    this.ID = GetNextId();
        //    this.Title = title;
        //    this.SendByUsername = sendByUsername;
        //    this.IsPublic = isPublic;
        //    this.ImageUrl = imageUrl;
        //}
        public ImagePost(string title, bool isPublic,string SendByUsername, string imageUrl):base(title, isPublic, SendByUsername)
        {
            
            this.ImageUrl = imageUrl;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}- by {3}", this.ID, this.Title,this.ImageUrl ,this.SendByUsername);
        }
    }
}

