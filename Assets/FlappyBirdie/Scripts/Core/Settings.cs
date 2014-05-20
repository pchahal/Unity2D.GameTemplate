using System.Collections.Generic;
using UnityEngine;
using System.Collections;

    public class Settings : MonoBehaviour {
    public static string googlePlayMarketProductDetails  = "market://details?id=<package_name>";
    public static string googlePlayWebsiteProductDetails = "http://play.google.com/store/apps/details?id=<package_name>";

    public static string googlePlayMarketProductList = "market://search?q=pub:<publisher_name>";
    public static string googlePlayWebsiteProductList = "http://play.google.com/store/search?q=pub:<publisher_name>";      
}
