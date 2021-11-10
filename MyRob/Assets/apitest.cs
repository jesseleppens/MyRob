using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apitest : MonoBehaviour
{
    // Start is called before the first frame update
    APIdefining test = APIhelper.GetAPIdata();

    void Start()
    {
        Debug.Log(test.fats);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
