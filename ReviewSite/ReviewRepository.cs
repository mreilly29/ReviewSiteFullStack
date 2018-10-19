using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public class ReviewRepository : IReviewRepository
    {
        Dictionary<int, Review> allReviews = new Dictionary<int, Review>()
        {
            { 1, new Review() {Id = 1, Title = "Corgi Type: Untoasted", ImageUrl = "/Images/whiteCorgi.png", ReviewCategory = "dog", Content = "Untoasted type Corgis have white fur. It's as if you had a piece of bread and did not put it in a toaster." } },
            { 2, new Review() {Id = 2, Title = "Corgi Type: Toasted", ImageUrl="/Images/puppyCorgi.jpg",ReviewCategory = "dog", Content = "Toasted type Corgis have brown fur. Like if you were to take a white piece of bread and put it in the toaster to toast it."} },
            { 3, new Review() {Id = 3, Title = "Corgi Type: Burnt", ImageUrl="/Images/blackCorgi.jpg", ReviewCategory="dog", Content = "Burnt type Corgis have mostly black fur with partial brown and white mixed in. In other words, you left your piece of bread in the toaster for far too long and it got burnt."} },
        };
    
        public Review FindById(int id)
        {
            return allReviews[id];
        }

        public List<Review> GetAll()
        {
            return allReviews.Values.ToList();
        }
    }
}
