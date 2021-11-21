using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private int _vote; 
        public int Vote
        {
            get
            {
                return this._vote;
            }
        }
        public DateTime Date { get; }

        public Post()
        {
            this.Date = DateTime.Now;
            this.Title = null;
            this.Description = null;
            this._vote = 0;
        }

        public void UpVote()
        {
            this._vote++;
        }

        public void DownVote()
        {
            this._vote--;
        }
    }
}
