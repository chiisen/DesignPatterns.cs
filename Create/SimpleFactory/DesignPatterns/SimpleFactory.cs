using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Product;

namespace DesignPatterns
{
    // 簡單工廠
    public class SimpleFactory
    {
        public static IProduct CreateProduct(string type)
        {
            switch (type)
            {
                case "A":
                    return new ProductA();
                case "B":
                    return new ProductB();
                default:
                    throw new ArgumentException("無效的產品類型");
            }
        }
    }
}
