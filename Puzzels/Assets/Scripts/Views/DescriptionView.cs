using UnityEngine;
using UnityEngine.UI;

public class DescriptionView : MonoBehaviour
{
    [SerializeField] private Text _tittle;
    [SerializeField] private Text _description;

    public void Init(DescriptionData data)
    {
        _tittle.text = $"#{data.Number}. {LocalizationController.GetLocalizationString(data.Title)}";
        _description.text = LocalizationController.GetLocalizationString(data.Description);
    }
}
