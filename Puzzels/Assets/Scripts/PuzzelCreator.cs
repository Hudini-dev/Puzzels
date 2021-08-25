using Assets.Scripts.Data.Builder;
using Newtonsoft.Json;
using UnityEngine;

public class PuzzelCreator : MonoBehaviour
{
    [SerializeField] private Language _language;
    [SerializeField] private int _number;
    [SerializeField] private string _tittle;
    [SerializeField] private string _description;
    [SerializeField] private PlayerTableData _playerData;
    [SerializeField] private PlayerTableData _opponentData;

    [SerializeField] private PuzzelViewController _viewController;

    private PuzzelData _puzzelData;

    public PuzzelData PuzzelData
    {
        get
        {
            if(_puzzelData == null)
            {
                GeneratePuzzelData();
            }
            return _puzzelData;
        }
    }
 
    private void Start()
    {
        Init();
    }

    private void GeneratePuzzelData()
    {
        var descriptionData = new DescriptionData() { Number = _number, Title = _tittle, Description = _description };
        var playerJson = JsonConvert.SerializeObject(_playerData, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
        PlayerBoardData playerData = JsonConvert.DeserializeObject<PlayerBoardData>(playerJson);
        var oppponentJson = JsonConvert.SerializeObject(_opponentData, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
        PlayerBoardData opponentData = JsonConvert.DeserializeObject<PlayerBoardData>(oppponentJson);
        _puzzelData = new PuzzelData() { DescriptionData = descriptionData, PlayerData = playerData, OponnentData = opponentData };
}

    public string GenerateJson()
    {
        return JsonConvert.SerializeObject(PuzzelData, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
    }

    public void Init()
    {
        _viewController.Init(PuzzelData, _language);
    }

    public void Create(string puzzelJson)
    {
        var puzzel = JsonConvert.DeserializeObject<PuzzelData>(puzzelJson);
        _viewController.Init(puzzel, _language);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            TakeScreenShot();
        }
    }

    private void TakeScreenShot()
    {
        ScreenCapture.CaptureScreenshot("TABLE_SCREEN");
    }
}
