using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System;
using System.IO;
using Assets.Scripts.API;

public class APIget : MonoBehaviour
{

    public static Data GetWeather()
    {
        //sends a request to the api and sets the response into a string where new lines are added to add all the objects into an array. the string is the deserialized to read the data as variables
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://i480028.hera.fhict.nl/api/?user_id=1");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        Data info = JsonUtility.FromJson<Data>(fixJson(jsonResponse));
        return info;
    }


    //a method to add 2 lines to the json file because of a bug in unity json deserialisation
     static string fixJson(string value)
    {
        value = "{\"data\":" + value + "}";
        return value;
    }
}
