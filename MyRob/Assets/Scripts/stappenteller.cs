using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stappenteller : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("repeat", 5, 5);
    }

    void repeat()
    {
        text.text = "AANTAL STAPPEN: " + APIget.GetStappen().data[0].aantal_stappen.ToString();
    }
}

