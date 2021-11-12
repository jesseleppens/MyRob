using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.API;

public class SportHistoryManager : MonoBehaviour
{
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < APIget.GetWeather().data.Count; i++)
        {
            //when the data is from the same day as the next one it is skipped
            if (APIget.GetWeather().data[i].day == APIget.GetWeather().data[i + 1].day)
            {
                continue;
            }
            else
            {
                //creates new object from prefab and sets it as a child of options, then changes the scale
                GameObject item = Instantiate(Resources.Load("History") as GameObject);
                item.transform.SetParent(parent.transform);
                item.GetComponent<RectTransform>().sizeDelta = new Vector2(500, 100);
                item.transform.localScale = new Vector3(1, 1, 1);

                //changes the text of the labels to the date and the actual burned calories from the api;
                Text date = item.transform.Find("date").GetComponent<Text>();
                Text calburned = item.transform.Find("calburned").GetComponent<Text>();
                date.text = APIget.GetWeather().data[i].day;
                int totalcalories = APIget.GetWeather().data[i].cal_burned;
                calburned.text = totalcalories.ToString();
                totalcalories = 0;
            }         
        }
    }
}
