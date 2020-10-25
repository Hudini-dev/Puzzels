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
 
    private void Start()
    {
        Init();
    }

    private string GenerateJson()
    {
        var descriptionData = new DescriptionData() { Number = _number, Title = _tittle, Description = _description };
        var playerJson = JsonConvert.SerializeObject(_playerData, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
        PlayerBoardData playerData = JsonConvert.DeserializeObject<PlayerBoardData>(playerJson);
        var oppponentJson = JsonConvert.SerializeObject(_opponentData, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
        PlayerBoardData opponentData = JsonConvert.DeserializeObject<PlayerBoardData>(oppponentJson);
        var puzzelData = new PuzzelData() { DescriptionData = descriptionData, PlayerData = playerData, OponnentData = opponentData};

        return JsonConvert.SerializeObject(puzzelData, Formatting.Indented, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
    }

    public void Init()
    {
        var json = GenerateJson();
        var puzzel = JsonConvert.DeserializeObject<PuzzelData>(json);

        _viewController.Init(puzzel, _language);
    }
 }
