using System.IO;
using UnityEngine;

public class PuzzelManager : MonoBehaviour
{
    [SerializeField] private PuzzelCreator _puzzelCreator;
    [SerializeField] private TextAsset _puzzelFile;

    private string _path;

    private void Awake()
    {
        _path = Application.dataPath + "/Puzzels/";
        GetAllPuzzels();
    }

    public void SaveToFile()
    {
        var fileName = $"Puzzel_{_puzzelCreator.PuzzelData.DescriptionData.Number}.json";
        var fullPath = _path + fileName;
        if(File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }

        FileStream fileStream = new FileStream(fullPath, FileMode.Create);
        StreamWriter streamWriter = new StreamWriter(fileStream);
        streamWriter.Write(_puzzelCreator.GenerateJson());
        streamWriter.Close();
        fileStream.Close();
    }

    public void LoadFromFile()
    {
        var fileName = _puzzelFile.name + ".json";
        var fullPath = _path + fileName;
        FileStream fileStream = new FileStream(fullPath, FileMode.Open);
        StreamReader streamReader = new StreamReader(fileStream);
        var json = streamReader.ReadToEnd();
        streamReader.Close();
        fileStream.Close();

        _puzzelCreator.Create(json);
    }

    private void GetAllPuzzels()
    {
        DirectoryInfo dir = new DirectoryInfo(_path);
        FileInfo[] info = dir.GetFiles("*.json");

        foreach (FileInfo f in info)
        {
            Debug.Log(Path.GetFileNameWithoutExtension(f.FullName));
        }
    }
}
