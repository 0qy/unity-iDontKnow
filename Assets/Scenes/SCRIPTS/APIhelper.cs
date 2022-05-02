using UnityEngine;
using System.Net;
using System.IO;

public static class APIhelper 
{
    public static Wethera GetCurrentWeather()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.create("http://api.openweathermap.org/data/2.5/weather?q=auckland&APPID=b1ac7199f66d788f1a46bdc50bbe0c39");
        HttpWebResponse response = (HttpWebResponse)requset.getResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<Weather>(json);
    }
}