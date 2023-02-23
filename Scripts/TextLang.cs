using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class TextLang : MonoBehaviour
{
    public string lang;
    public string[] text;
    private Text textLine;

    void Start()
    {
        // Read lang.json
        string filePath = Path.Combine(Application.dataPath, "lang.json");
        string jsonString = File.ReadAllText(filePath);
        Dictionary<string, string> jsonData = JsonUtility.FromJson<Dictionary<string, string>>(jsonString);
        lang = jsonData["lang"];

        // Set the language index based on the lang value
        switch (lang)
        {
            case "en":
                textLine.text = text[0];
                break;
            case "ru":
                textLine.text = text[1];
                break;
            case "ua":
                textLine.text = text[2];
                break;
            default:
                textLine.text = text[0];
                break;
        }
    }

    void Update()
    {
        // Read lang.json
        string filePath = Path.Combine(Application.dataPath, "lang.json");
        string jsonString = File.ReadAllText(filePath);
        Dictionary<string, string> jsonData = JsonUtility.FromJson<Dictionary<string, string>>(jsonString);
        lang = jsonData["lang"];

        // Set the language index based on the lang value
        switch (lang)
        {
            case "en":
                textLine.text = text[0];
                break;
            case "ru":
                textLine.text = text[1];
                break;
            case "ua":
                textLine.text = text[2];
                break;
            default:
                textLine.text = text[0];
                break;
        }
    }
}
