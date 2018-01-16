﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace IOTOIApp.Services
{
    public class OpenWeatherMapProxy
    {
        //static string APPID = "370a7502ab963ebe0c77fc76d8a334e0";

        //public async static Task<RootObject> GetWeather(double lat, double lon)
        //{
        //    try
        //    {
        //        string url = String.Format("http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units=Metric&APPID={2}", lat, lon, APPID);
        //        var http = new HttpClient();
        //        //var response = await http.GetAsync("http://api.openweathermap.org/data/2.5/weather?lat=32.77&lon=-96.79&units=imperial");
        //        var response = await http.GetAsync(url);
        //        var result = await response.Content.ReadAsStringAsync();
        //        var serializer = new DataContractJsonSerializer(typeof(RootObject));

        //        var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
        //        return (RootObject)serializer.ReadObject(ms);
        //    }
        //    catch (HttpRequestException e)
        //    {
        //        Debug.WriteLine("GetWeather error : " + e);
        //        return null;
        //    }

        //}
    }

    //[DataContract]
    //public class Coord
    //{
    //    [DataMember]
    //    public double lon { get; set; }

    //    [DataMember]
    //    public double lat { get; set; }
    //}

    //[DataContract]
    //public class Weather
    //{
    //    [DataMember]
    //    public int id { get; set; }

    //    [DataMember]
    //    public string main { get; set; }

    //    [DataMember]
    //    public string description { get; set; }

    //    [DataMember]
    //    public string icon { get; set; }
    //}

    //[DataContract]
    //public class Main
    //{
    //    [DataMember]
    //    public double temp { get; set; }

    //    [DataMember]
    //    public int pressure { get; set; }

    //    [DataMember]
    //    public int humidity { get; set; }

    //    [DataMember]
    //    public double temp_min { get; set; }

    //    [DataMember]
    //    public double temp_max { get; set; }
    //}

    //[DataContract]
    //public class Wind
    //{
    //    [DataMember]
    //    public double speed { get; set; }

    //    [DataMember]
    //    public int deg { get; set; }
    //}

    ///*
    //[DataContract]
    //public class Rain
    //{
    //    [DataMember]
    //    public double __invalid_name__1h { get; set; }
    //}
    //*/

    //[DataContract]
    //public class Clouds
    //{
    //    [DataMember]
    //    public int all { get; set; }
    //}

    //[DataContract]
    //public class Sys
    //{

    //    [DataMember]
    //    public int type { get; set; }

    //    [DataMember]
    //    public int id { get; set; }

    //    [DataMember]
    //    public double message { get; set; }

    //    [DataMember]
    //    public string country { get; set; }

    //    [DataMember]
    //    public int sunrise { get; set; }

    //    [DataMember]
    //    public int sunset { get; set; }
    //}

    //[DataContract]
    //public class RootObject
    //{
    //    [DataMember]
    //    public Coord coord { get; set; }

    //    [DataMember]
    //    public List<Weather> weather { get; set; }

    //    [DataMember]
    //    public string @base { get; set; }

    //    [DataMember]
    //    public Main main { get; set; }

    //    [DataMember]
    //    public Wind wind { get; set; }
    //    /*
    //    [DataMember]
    //    public Rain rain { get; set; }
    //    */

    //    [DataMember]
    //    public Clouds clouds { get; set; }

    //    [DataMember]
    //    public int dt { get; set; }

    //    [DataMember]
    //    public Sys sys { get; set; }

    //    [DataMember]
    //    public int id { get; set; }

    //    [DataMember]
    //    public string name { get; set; }

    //    [DataMember]
    //    public int cod { get; set; }
    //}
}
