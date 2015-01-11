using System;
using NUnit.Framework;
using ShoppingCart ;

namespace ShoppingCartTest
{
    [TestFixture]
    public class CartIteamTest
    {
        private CartIteam _iteam;
        private decimal _quantity = 2m;
        private string _description = "This is a Iteam";
        private decimal _unitPrice = 2m;
        private decimal _iteamPrice;
        private decimal _discount = 2m;
        
        
        [SetUp]
        public void setup()
        {
            _iteam = new CartIteam(_quantity, _description, _unitPrice);
            _iteamPrice = _quantity * _unitPrice;
        }              
        
        [Test]
        public void IsQuantityAvailable()
        {
            Assert.That(_iteam.Quantity , Is.EqualTo(_quantity));
        }

        [Test]
        public void IsDescriptionAvailable()
        {
            Assert.That(_iteam.Description, Is.EqualTo(_description));
        }

        [Test]
        public void IsUnitPriceAvailable()
        {
            Assert.That(_iteam.UnitPrice, Is.EqualTo(_unitPrice));
        }

        [Test]
        public void IsIteamPriceAvailable()
        {
            Assert.That(_iteam.IteamPrice(), Is.EqualTo(_iteamPrice));
        }

        [Test]
        public void IsQuantityModifyable()
        {
            _iteam.Quantity=5;
            Assert.That(_iteam.Quantity, Is.EqualTo(5));
        }

        [Test]
        public void CanDiscountBeAdded()
        {
            _iteam.setDiscount(_discount);
            Assert.That(_iteam.Discount, Is.EqualTo(_discount));
        }

        [Test]
        public void IsIteamPriceWithDiscountLessThanZero()
        {            
            Assert.That(_iteam.IteamPriceWithDiscount(_discount), Is.Not.EqualTo(0));
        }
    }
}
