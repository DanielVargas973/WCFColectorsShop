using System;
using System.Collections.Generic;
using System.IO;

namespace ColectorsShop.Data.com.cs.data.dao
{
    public class ColectorsShopDao
    {
        private readonly string Directory = string.Empty;
        public ColectorsShopDao(string directory)
        {
            Directory = directory;
        }
        public List<string> GetDataOfRegistrados(string fileNameDocument)
        {
            try
            {
                List<string> data = new List<string>();
                StreamReader sr = new StreamReader(Directory + fileNameDocument);
                var line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    data.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                throw;
            }
        }
    }
}