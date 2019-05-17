using System;
namespace Olympic_graph_generator
{
    public class ItemModel
    {
        public string Name { get; set; }
        public Int64 Data { get; set; }
        public int Color { get; set; }

        public ItemModel(string name, Int64 data, int color)
        {
            Name = name;
            Data = data;
            Color = color;
        }

    }
}
