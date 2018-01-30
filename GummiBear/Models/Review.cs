using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummiBear.Models
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }


        public override bool Equals(System.Object obj)
        {
            if (!(obj is Review))
            {
                return false;
            }
            else
            {
                Review newReview = (Review)obj;
                return this.ReviewId.Equals(newReview.ReviewId);
            }
        }

        public override int GetHashCode()
        {
            return this.ReviewId.GetHashCode();
        }



        public bool ContentBodyLength()
        {
            if (Content.Length > 255)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}