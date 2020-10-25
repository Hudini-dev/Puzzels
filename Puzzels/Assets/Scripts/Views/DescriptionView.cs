using UnityEngine;
using UnityEngine.UI;

public class DescriptionView : MonoBehaviour
{
    [SerializeField] private Text _tittle;
    [SerializeField] private Text _description;

    public void Init(DescriptionData data)
    {
        _tittle.text = $"{data.Number}. {data.Title}";
        _description.text = data.Description;
    }
}
