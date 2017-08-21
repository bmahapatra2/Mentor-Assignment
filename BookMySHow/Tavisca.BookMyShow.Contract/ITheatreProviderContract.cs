using Tavisca.BookMyShow.Entity;
using System.Collections.Generic;

namespace Tavisca.TheatreProviderContract


{
    public interface ITheatreProvider

    {
       List<Theatre> GetTheaters( );

        int TheatrePrice(Price price);
     
    }
}