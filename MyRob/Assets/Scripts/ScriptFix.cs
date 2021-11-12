using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFix : MonoBehaviour
{

    public Font[] fonts;

    void Start()
    {
        //gets rid of anti-aliasing of fonts
        for (int i = 0; i < fonts.Length; i++)
        {
            fonts[i].material.mainTexture.filterMode = FilterMode.Point;
        }
    }

}
