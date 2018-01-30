using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GummiBear.Models
{
    [Table("Products")]
    public class Product
    {

        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public double AverageRating { get; set; }


        public void GetAverage()
        {
            double averageRating = 0.0;
            if (Reviews.Count > 0)
            {
                foreach (var review in Reviews)
                {
                    averageRating += review.Rating;
                }
                averageRating = (averageRating / Reviews.Count);
            }

            AverageRating = averageRating;
        }
    }
}