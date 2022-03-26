using System.Collections.Generic;

namespace RestWithASP_NET5Udemy.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {        List<HyperMediaLink> Links { get; set; }
    }
}
