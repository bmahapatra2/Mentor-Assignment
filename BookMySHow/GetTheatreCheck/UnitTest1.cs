//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tavisca.BookMyShow.Manager;
using Tavisca.TheatreProviderContract;
using System.Linq;
using Tavisca.Manager;
using Xunit;

using System.Configuration;
using Tavisca.BookMyShow.Entity;
using Tavisca.TheatreProviders;
using System.Collections.Generic;
using System;

namespace Tavisca.BookMyShow.GetTheatreCheck
{
    // [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void Test_For_ReadConfigs()
        {
            var value = ConfigurationManager.AppSettings["EnabledTheatreProviders"];
            Assert.Contains("DC", value);
        }

        [Fact]
        public void Test_For_TheatreProvider1()
        {
            TheatreProviderFactory movietheatre = new TheatreProviderFactory();
            ITheatreProvider theatrelist = movietheatre.GetShow("MarvelsTheatreProvider");

            Assert.Equal(2, theatrelist.GetTheaters().Count);
        }

        [Fact]
        public void Test_For_TheatreProvider2()
        {
            TheatreProviderFactory movietheatre = new TheatreProviderFactory();
            ITheatreProvider theatrelist = movietheatre.GetShow("DCTheatreProvider");

            Assert.Equal(2, theatrelist.GetTheaters().Count);
        }

        [Fact]
        public void Test_For_Count_Theatres_In_List()
        {
            TheatresManager list = new TheatresManager();
            int count = list.GetTheatreList().Count;

            Assert.Equal(4, count);
        }

        [Fact]
        public void Test_For_Distinct_Theatres_In_List()
        {
            TheatresManager list = new TheatresManager();
            
            Assert.Equal(3, list.DistinctList());


        }

        [Fact]
        public void Test_For_Discount_For_DC()
        {
            Theatre theatre = new Theatre();
            Price price = new Price();
            ITheatreProvider pro = new DCTheatreProvider();
            Decorator decorator = new Decorator(pro);
            TimeSlot slot = new TimeSlot();
            price.Amount = 100;
            price.Currency = "INR";
            price.GSTPrice = 10;
            Assert.Equal(120, decorator.TheatrePrice(price));
        }

        [Fact]
        public void Test_For_Discount_For_Marvels()
        {
            Theatre theatre = new Theatre();
            Price price = new Price();
            ITheatreProvider pro = new MarvelsTheatreProvider();
            Decorator decorator = new Decorator(pro);
            TimeSlot slot = new TimeSlot();
            price.Amount = 100;
            price.Currency = "INR";
            price.GSTPrice = 10;
            Assert.Equal(120, decorator.TheatrePrice(price));
        }
        [Fact]
        public void Test_For_Discount_Value_In_Config_File()
        {
            var s = Convert.ToInt32(ConfigurationManager.AppSettings["Discount"]);
            int m = (int)s;
            Assert.Equal(10, m);
        }

    }
}