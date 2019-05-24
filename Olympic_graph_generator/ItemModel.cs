using System;
using System.Drawing;
namespace Olympic_graph_generator
{
    public class ItemModel
    {
        public string Name { get; set; }
        public int Data { get; set; }
        public Color Color { get; set; }

        public ItemModel(string name, int data, Color color)
        {
            Name = name;
            Data = data;
            Color = color;
        }

    }
}
