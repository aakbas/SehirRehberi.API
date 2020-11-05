using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Models
{
    public class Comment
    {

        public int Id { get; set; }

        public int PhotoId { get; set; }

        public string CommentDetail { get; set; }

        public int UpVote{ get; set; }      



    }
}
