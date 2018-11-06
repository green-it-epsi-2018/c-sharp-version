using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Green_It
{
    public class Utils
    {

        public static List<string> ReadFileCSV(StreamReader csvreader)
        {
            List<string> _Data = new List<string>();
            while (!csvreader.EndOfStream)
            {
                _Data.Add(csvreader.ReadLine()+ "<br>");
                /*if (_Data.Count > 20)
                    return _Data;*/
            }
            return _Data;
        }
    }
}