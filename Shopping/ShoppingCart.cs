using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping
{
    public class ShoppingCart
    {
        public double CheckOut(List<Book> books)
        {
            var booksList = books.OrderBy(x => x.BookName);
            int booksCount = booksList.Sum(x=>x.Num);
            double Price = 0;

                
            while(booksCount>0)
            {
                List<Book> _bookList = new List<Book>();
                foreach (var item in booksList.Where(x => x.CheckOut == false))
                {
                    if (_bookList.Any(x => x.BookName == item.BookName))
                    {

                    }
                    else
                    {
                        item.Num = item.Num - 1;
                        if(item.Num==0)
                        {
                            item.CheckOut = true;
                        }
                        _bookList.Add(item);
                        booksCount = booksCount - 1;

                    }
                }

                switch (_bookList.Count)
                {
                    case 1:
                        {
                            Price = Price + 100;
                            break;
                        }
                    case 2:
                        {
                            Price = Price + (100 * 2 * 0.95);
                            break;
                        }
                    case 3:
                        {
                            Price = Price + (100 * 3 * 0.9);
                            break;
                        }
                    case 4:
                        {
                            Price = Price + (100 * 4 * 0.8);
                            break;
                        }
                    case 5:
                        {
                            Price = Price + (100 * 5 * 0.75);
                            break;
                        }
                    default:
                        break;
                }
                if(_bookList.Count==1)
                {
                    return Price;
                }


            }
            return Price;
        }

          
            

            
        }



    }

