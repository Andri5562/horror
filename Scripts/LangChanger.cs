using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LangChanger : MonoBehaviour
{
    public void ChangeLangEng()
    {
        string filePath = Path.Combine(Application.dataPath, "lang.json");
        string json = "{\"lang\": \"en\"}";
        File.WriteAllText(filePath, json);
        Debug.Log("eng");
    }

    public void ChangeLangRus()
    {
        string filePath = Path.Combine(Application.dataPath, "lang.json");
        string json = "{\"lang\": \"ru\"}";
        File.WriteAllText(filePath, json);
        Debug.Log("rus");
    }

    public void ChangeLangUkr()
    {
        string filePath = Path.Combine(Application.dataPath, "lang.json");
        string json = "{\"lang\": \"ua\"}";
        File.WriteAllText(filePath, json);
        Debug.Log("ukr");
    }
}
