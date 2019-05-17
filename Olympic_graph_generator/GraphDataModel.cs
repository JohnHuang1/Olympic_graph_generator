using System;
using System.Collections.Generic;
using System.Linq;
namespace Olympic_graph_generator
{
    public class GraphDataModel
    {

        public class ItemModel
        {
            private string Name { get; set; }
            private Int64 Data { get; set; }
            private int Color { get; set; }

            public ItemModel(string name, Int64 data, int color)
            {
                Name = name;
                Data = data;
                Color = color;
            }
            public string GetName()
            {
                return Name;
            }
            
        }

        public string Title { get; set; }
        public string Xaxis { get; set; }
        public string Yaxis { get; set; }
        private List<ItemModel> dataSetList = new List<ItemModel>();

        public GraphDataModel(string title = "", string yaxis = "", string xaxis = "")
        {
            Title = title;
            Yaxis = yaxis;
            Xaxis = xaxis;
        }


        public void AddItem(string name, Int64 data, int color = 0)
        {
            dataSetList.Add(new ItemModel(name, data, color));
        }

        public ItemModel GetItemAt(int index)
        {
            return dataSetList.ElementAt(index);
        }

        public void RemoveItem(string name)
        {
            dataSetList.Remove((ItemModel)dataSetList.Where(i => name == i.GetName()));
        }

        public void RemoveItemAt(int index)
        {
            dataSetList.RemoveAt(index);
        }
    }
}
