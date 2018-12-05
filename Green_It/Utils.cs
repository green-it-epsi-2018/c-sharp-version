using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Green_It
{
    public class Utils
    {

        public static List<string> ReadFileCSV(StreamReader csvreader)
        {
            List<string> _Data = new List<string>();
            while (!csvreader.EndOfStream)
            {
                _Data.Add(csvreader.ReadLine() + "<br>");
            }
            return _Data;
        }

        public static DataTable ReadCsvFile(StreamReader csvreader)
        {

            DataTable dtCsv = new DataTable();
            string Fulltext;
            while (!csvreader.EndOfStream)
            {
                Fulltext = csvreader.ReadToEnd().ToString(); //read full file text  
                string[] rows = Fulltext.Split('\n'); //split full file text into rows  
                for (int i = 0; i < rows.Count() - 1; i++)
                {
                    string[] rowValues = rows[i].Split(';'); //split each row with comma to get individual values  
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < rowValues.Count(); j++)
                            {
                                dtCsv.Columns.Add(rowValues[j]); //add headers  
                            }
                        }
                        else
                        {
                            DataRow dr = dtCsv.NewRow();
                            for (int k = 0; k < rowValues.Count(); k++)
                            {
                                dr[k] = rowValues[k].ToString().Replace("<br />", " ");
                            }
                            dtCsv.Rows.Add(dr); //add other rows  
                        }
                    }
                }
            }
            return dtCsv;
        }

        public static string HashesCsvFile(string dataContents)
        {
            string data = string.Empty;
            using (HashAlgorithm hashAlgorithm = SHA256.Create())
            {
                byte[] plainText = Encoding.UTF8.GetBytes(dataContents);
                byte[] hash = hashAlgorithm.ComputeHash(plainText);
                data = Convert.ToBase64String(hash);
            }
            return data;
        }

        public static string ToHexString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
                sb.Append(b.ToString("x2").ToLower());

            return sb.ToString();
        }

        public static int getNumber()
        {
            return callWebService().Randam();
        }

        public static localhost.WebService callWebService()
        {
            localhost.WebService _WebService = new localhost.WebService();
            return _WebService;
        }
    }
}