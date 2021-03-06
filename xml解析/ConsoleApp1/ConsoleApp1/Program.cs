﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument reader = new XmlDocument();
            reader.Load(@"C:\Users\昱軒\Desktop\高三下\多媒體系統\xml解析\35_1.xml");
            XmlNodeList NodeLists = reader.SelectNodes("dataList/rows");
            for (int i = 0; i < NodeLists.Count; i++)
            {
                Console.WriteLine("機構名稱:" + NodeLists[i].SelectSingleNode("機構名稱").InnerText);
                Console.WriteLine("機構狀態:" + NodeLists[i].SelectSingleNode("機構狀態").InnerText);
                Console.WriteLine("地址:" + NodeLists[i].SelectSingleNode("地址縣市別").InnerText
                    + NodeLists[i].SelectSingleNode("地址鄉鎮市區").InnerText
                    + NodeLists[i].SelectSingleNode("地址街道巷弄號").InnerText);
                Console.WriteLine("電話:" + NodeLists[i].SelectSingleNode("電話").InnerText);
                Console.WriteLine();
            } 
            Console.Read();
        }
    }
}
