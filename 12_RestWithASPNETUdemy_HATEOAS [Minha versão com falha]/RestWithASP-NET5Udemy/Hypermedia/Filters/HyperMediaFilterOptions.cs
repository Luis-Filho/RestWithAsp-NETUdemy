using RestWithASP_NET5Udemy.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
