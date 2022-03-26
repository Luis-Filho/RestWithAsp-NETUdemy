using RestWithASP_NET5Udemy.Hypermedia;
using RestWithASP_NET5Udemy.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Data.VO
{
    public class PersonVO : ISupportstHyperMedia
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
