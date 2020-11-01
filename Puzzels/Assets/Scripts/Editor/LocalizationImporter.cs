using System.IO;
using System.Net;
using UnityEditor;
using UnityEngine;

public class LocalizationImporter
{
    [MenuItem("Localization/Import")]
    public static void Import()
    {
        string url = @"https://docs.google.com/spreadsheets/d/e/2PACX-1vTzc5zMw6q-xrOSNK_uV-E-S9AFV0wdn8q9JyVG1TpLtd29VMVuECUnD4RaLsidfajb3Y2IVS9k-Rip/pub?gid=0&single=true&output=csv";

        WebClientEx wc = new WebClientEx(new CookieContainer());
        wc.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
        wc.Headers.Add("Accept-Encoding", "deflate");
        wc.Headers.Add("Accept-Language", "en-US,en;q=0.5");

        var outputCSVdata = wc.DownloadString(url);

        var path = Application.dataPath + "/Resources/Localization/Localization.csv";
        StreamWriter outStream = File.CreateText(path);
        outStream.Write(outputCSVdata);
        outStream.Close();

        Debug.Log(outputCSVdata);
    }

}
