using UnityEngine;
using System.Net;
using System.IO;

public static class APIhelper 
{
    public static Weather GetCurrentWeather()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=auckland&APPID=b1ac7199f66d788f1a46bdc50bbe0c39");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        Weather w = JsonUtility.FromJson<Weather>(json);
        return w;
    }
}