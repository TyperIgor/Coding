using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples
{
    internal class OCPExample
    {
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;
        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }


    // Evitar padrões como este que violam o OCP
    public class ProductFilter
    {
        public static IEnumerable<Product> FilterByColor
            (IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }

        public static IEnumerable<Product> FilterBySize
            (IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }
    }

    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Large, Medium
    }

    //OCP Solution
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> first, second;
        public AndSpecification(ISpecification<T> first,
            ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }
        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t); //receive two specifications can be collor or Size and combine them
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Size == size;
        }
    }

    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;
        public ColorSpecification(Color color)
        {
            this.color = color;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Color == color;
        }
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T>spec);
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items,
        ISpecification<Product> spec)
        {
            foreach (var i in items)
                if (spec.IsSatisfied(i))
                    yield return i;
        }
    }
}
