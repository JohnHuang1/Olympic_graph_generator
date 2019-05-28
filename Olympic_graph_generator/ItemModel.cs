using System;
using System.Drawing;
namespace Olympic_graph_generator
{
    public class ItemModel
    {
        public string Name { get; set; }
        public double Data { get; set; }
        public Color Color { get; set; }

        public ItemModel(string name, double data, Color color)
        {
            Name = name;
            Data = data;
            Color = color;
        }

    }
}
