using ColectorsShop.Data.com.cs.data.dao;
using System;
using System.Collections.Generic;

namespace ColectorsShop.Core.com.cs.core
{
    public class ColectorsShopCore
    {
        private readonly string Directory;

        public ColectorsShopCore(string directory)
        {
            Directory = directory;
        }

        public List<string> GetInformationOfAnime(string fileNameDocument)
        {
            try
            {
                ColectorsShopDao colectorsShopDao = new ColectorsShopDao(Directory);
                return colectorsShopDao.GetDataOfRegistrados(fileNameDocument);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}