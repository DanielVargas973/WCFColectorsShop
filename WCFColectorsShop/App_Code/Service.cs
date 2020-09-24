using ColectorsShop.Core.com.cs.core;
using System;
using System.Collections.Generic;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    [Obsolete]
    public List<string> GetDataOfComic()
    {
        ColectorsShopCore colectorsShopCore = new ColectorsShopCore(Connection.GetConfigOfAppSettings("directory"));
        return colectorsShopCore.GetInformationOfAnime(Connection.GetConfigOfAppSettings("filenameAnime"));
    }
}