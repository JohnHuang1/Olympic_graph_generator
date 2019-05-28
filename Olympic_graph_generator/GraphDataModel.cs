﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Olympic_graph_generator
{
    public class GraphDataModel
    {
        public enum GraphType { PieChart, BarGraph, LineGraph };

        public string Title { get; set; }
        public string Xaxis { get; set; }
        public string Yaxis { get; set; }
        public GraphType gType { get; set; }
        private List<ItemModel> dataSetList = new List<ItemModel>();

        public GraphDataModel(string title = "", string yaxis = "", string xaxis = "", GraphType graphType = 0)
        {
            Title = title;
            Yaxis = yaxis;
            Xaxis = xaxis;
            gType = graphType;
        }


        public void AddItem(string name, double data, Color color)
        {
            dataSetList.Add(new ItemModel(name, data, color));
        }
        public void AddItem(string name, double data)
        {
            dataSetList.Add(new ItemModel(name, data, Color.Blue));
        }

        public ItemModel GetItem(string name)
        {
            return (ItemModel) dataSetList.Where(i => i.Name == name);
        }

        public ItemModel GetItemAt(int index)
        {
            return dataSetList.ElementAt(index);
        }

        public void RemoveItem(string name)
        {
            dataSetList.Remove((ItemModel)dataSetList.Where(i => name == i.Name));
        }

        public void RemoveItem(ItemModel item)
        {
            dataSetList.Remove(item);
        }

        public void RemoveItemAt(int index)
        {
            dataSetList.RemoveAt(index);
        }

        public void ChangeItemAt(int index, string name, double data, Color color)
        {
            ItemModel item = dataSetList.ElementAt(index);
            item.Name = name;
            item.Data = data;
            item.Color = color;
        }

        public List<ItemModel> GetItemList()
        {
            return dataSetList;
        }
    }
}

