using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdeToFood.Entities
{
    public class Friend
    {
        public int ID { get; set; }
        public string Name { get; set; }

        /*
         * [Key]
        //public int Id { get; set; }

        //public string FriendId { get; set; }

        //public User User { get; set; }

        //    public virtual int Id { get; set; }

        //    [ForeignKey("RequestedBy")]
        //    public virtual int RequestedBy_Id { get; set; }
        //    public virtual User RequestedBy { get; set; }

        //    public virtual User RequestedTo { get; set; }

        //    public FriendRequestFlag FriendRequestFlag { get; set; }
        //}

        //public enum FriendRequestFlag
        //{
        //    None,
        //    Approved,
        //    Rejected,
        //    Blocked,
        //    Spam
        };
        */
    }
}
