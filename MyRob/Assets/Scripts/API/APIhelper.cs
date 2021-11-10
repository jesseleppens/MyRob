using UnityEngine;
using System.Net;
using System.IO;

public static class APIhelper
{
    
    public static APIdefining GetAPIdata()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://i480028.hera.fhict.nl/api/?user_id=1");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<APIdefining>(json);
    }
}
