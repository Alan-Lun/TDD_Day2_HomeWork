﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void CheckOutTest_購買第一集一本_價格應為100()
        {
            //arrange 初始化
            List<Book> _books = new List<Book>();
            _books.Add(new Book { BookName = "哈利波特第一集", Num = 1, Price = 100 });

            var target = new ShoppingCart();

            var expected = 100;

            //act 測試目標行為
            var actual = target.CheckOut();

            //assert 驗證目標行為
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }
    }
}