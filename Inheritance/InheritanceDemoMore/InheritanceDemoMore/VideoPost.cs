using System;
using System.Threading;
namespace InheritanceDemoMore
{
    public class VideoPost : Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;

        //timer
        Timer timer;


        protected string VideoURL { get; set; }
        protected int Length { get; set; }
        public VideoPost()
        {

        }
        public VideoPost(string title,string sendByUsername,string videoURl, bool isPublished, int length)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = IsPublic;
            //
            this.VideoURL = videoURl;
            this.Length = length;
        }
        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }
        
        }

        private void TimerCallBack(object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s",currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stop at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
           
        }


        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}",
             this.ID, this.Title,this.VideoURL ,this.Length,this.SendByUsername);
        }
    }
}

