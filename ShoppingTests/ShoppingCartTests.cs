using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            _books.Add(new Book { BookName = "哈利波特第一集", Num = 1, Price = 100,CheckOut=false });

            var target = new ShoppingCart();

            var expected = 100;

            //act 測試目標行為
            var actual = target.CheckOut(_books);

            //assert 驗證目標行為
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void CheckOutTest_購買第一集一本和第二集一本_價格應為190()
        {
            //arrange 初始化
            List<Book> _books = new List<Book>();
            _books.Add(new Book { BookName = "哈利波特第一集", Num = 1, Price = 100, CheckOut = false });
            _books.Add(new Book { BookName = "哈利波特第二集", Num = 1, Price = 100, CheckOut = false });

            var target = new ShoppingCart();

            var expected = 190;

            //act 測試目標行為
            var actual = target.CheckOut(_books);

            //assert 驗證目標行為
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void CheckOutTest_購買第一集一本和第二集一本和第三集一本_價格應為270()
        {
            //arrange 初始化
            List<Book> _books = new List<Book>();
            _books.Add(new Book { BookName = "哈利波特第一集", Num = 1, Price = 100, CheckOut = false });
            _books.Add(new Book { BookName = "哈利波特第二集", Num = 1, Price = 100, CheckOut = false });
            _books.Add(new Book { BookName = "哈利波特第三集", Num = 1, Price = 100, CheckOut = false });

            var target = new ShoppingCart();

            var expected = 270;

            //act 測試目標行為
            var actual = target.CheckOut(_books);

            //assert 驗證目標行為
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void CheckOutTest_購買第一集一本和第二集一本和第三集一本和第四集一本_價格應為320()
        {
            //arrange 初始化
            List<Book> _books = new List<Book>();
            _books.Add(new Book { BookName = "哈利波特第一集", Num = 1, Price = 100, CheckOut = false });
            _books.Add(new Book { BookName = "哈利波特第二集", Num = 1, Price = 100, CheckOut = false });
            _books.Add(new Book { BookName = "哈利波特第三集", Num = 1, Price = 100, CheckOut = false });
            _books.Add(new Book { BookName = "哈利波特第四集", Num = 1, Price = 100, CheckOut = false });

            var target = new ShoppingCart();

            var expected = 320;

            //act 測試目標行為
            var actual = target.CheckOut(_books);

            //assert 驗證目標行為
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

        [TestMethod()]
        public void CheckOutTest_購買一整套各買一本_價格應為375()
        {
            //arrange 初始化
            List<Book> _books = new List<Book>();
            _books.Add(new Book { BookName = "哈利波特第一集", Num = 1, Price = 100, CheckOut = false });
            _books.Add(new Book { BookName = "哈利波特第二集", Num = 1, Price = 100, CheckOut = false });
            _books.Add(new Book { BookName = "哈利波特第三集", Num = 1, Price = 100, CheckOut = false });
            _books.Add(new Book { BookName = "哈利波特第四集", Num = 1, Price = 100, CheckOut = false });
            _books.Add(new Book { BookName = "哈利波特第五集", Num = 1, Price = 100, CheckOut = false });

            var target = new ShoppingCart();

            var expected = 375;

            //act 測試目標行為
            var actual = target.CheckOut(_books);

            //assert 驗證目標行為
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }

    }
}