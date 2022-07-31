using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Product
    {
    public string Name { get; set; }
    public int Energy { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Energy})";
    }
}
}
