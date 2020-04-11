using BuilderPattern;
using BuilderPattern.Concrete;
using DesignPattern.ABFVechicle.ABProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ABFVechicle.Products
{
    class BajajChetak: IScooty
    {
        private Engineer _engineer;

        public BajajChetak()
        {
            _engineer = new Engineer();
        }

        public string GetScooty()
        {
            return _engineer.BuildScooty(new Scooty());
        }
    }
}
