using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Hypermedia.Abstract
{
    public interface ISupportstHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
