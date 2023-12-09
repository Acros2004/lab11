using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TestSecond.Model;
using TestSecond.Pages;
using TestSecond.services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestSecond.Tests
{
    public class KufarTests
    {
        
        [Test]
        public void TestAddItemToFavorite()
        {
            Thread.Sleep(30000);
        }
        [Test]
        public void TestAddItemToBasket()
        {
            Thread.Sleep(20000);
        }
        [Test]
        public void DisplayingProductsBySearchAndBySpecificRegion()
        {
            Thread.Sleep(10000);
        }
        [Test]
        public void CheckingTheLowerThresholdForTheNumberOfCharactersInTheDescriptionField()
        {
            Thread.Sleep(10000);
        }

        [Test]
        public void EnteringSpecialCharactersInTheUserName()
        {
            Thread.Sleep(10000);
        }
        [Test]
        public void EnteringLargeNumberOfCharactersInTheNameFieldAnAd()
        {
            Thread.Sleep(10000);
        }
        [Test]
        public void EnteringAnIncorrectPhoneNumberAnAd()
        {
            Thread.Sleep(10000);

        }
        [Test]
        public void SearchForProductsEnteredString()
        {
            Thread.Sleep(10000);
        }
        [Test]
        public void FilteringProductsInTheSearch()
        {
            Thread.Sleep(10000);
        }
        [Test]
        public void DisplayingProductsByCategoryAndBySpecificRegion()
        {
            Thread.Sleep(10000);
        }
    }
}
