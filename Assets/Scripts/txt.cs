using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

public class txt : MonoBehaviour
{
    void Start()
    {
        //string[] readedLines = File.ReadAllLines(levelFolderPath + "/level_" + nameMap + ".txt");
        TextAsset txt = (TextAsset)Resources.Load("test", typeof(TextAsset));
        List<string> lines = new List<string>(txt.text.Split('\n'));
        //Debug.Log(lines[0]);

        float time;

        time = float.Parse(lines[0], CultureInfo.InvariantCulture);
        //time = (float) Convert.ToDouble(lines[0]);
        Debug.Log(time);
    }

}
