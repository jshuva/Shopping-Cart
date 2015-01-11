using System;
using NUnit.Framework;
using ShoppingCart;


namespace ShoppingCartTest
{
    [TestFixture]
    class CartTest
    {
        private Cart _cart;
        private CartIteam _iteam1;
        private CartIteam _iteam2;
        private decimal _discount = 5m;
        private decimal expectedTotal;
        
        [SetUp]
        public void setUp()
        {
            _cart = new Cart();
            _iteam1 = new CartIteam(3m, "1st Iteam", 2m);
            _iteam2 = new CartIteam(5m, "1st Iteam", 4m);
            expectedTotal = _iteam1.IteamPriceWithDiscount(_discount) + _iteam2.IteamPriceWithDiscount(_discount);
        }

        [Test]
        public void CanCartContainZeroIteams()
        {
            Assert.That(_cart.Iteams.Count, Is.EqualTo(0));        
        }

        [Test]
        public void AddingIteamsToTheCart()
        {
            _cart.AddIteams(_iteam1);
            Assert.That(_cart.Iteams.Count, Is.EqualTo(1));
        }

        [Test]
        public void NoDuplicatedIteamInTheCart()
        {
            _cart.AddIteams(_iteam1);
            _cart.AddIteams(_iteam1);
            Assert.That(_cart.Iteams.Count, Is.EqualTo(1));
        }

        [Test]
        public void DeletingIteamsFromTheCart()
        {
            _cart.AddIteams(_iteam1);
            _cart.DeleteIteams(_iteam1);
            Assert.That(_cart.Iteams.Count, Is.EqualTo(0)); 
        }

        [Test]
        public void TotalEqualSumOfAllIteamPrice()
        {
            _cart.AddIteams(_iteam1);
            _cart.AddIteams(_iteam2);
            Assert.That(_cart.GetTotal(_discount), Is.EqualTo(expectedTotal)); 
        }
    }
}
