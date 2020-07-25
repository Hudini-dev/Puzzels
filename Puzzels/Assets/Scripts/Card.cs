using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Card : MonoBehaviour
{
    [SerializeField] private Transform _markersContainer;

    private Image _image;

    private Image Image
    {
        get
        {
            if(_image == null)
            {
                _image = GetComponent<Image>();
            }

            return _image;
        }
    }

    public void SetFront(Sprite front)
    {
        Image.sprite = front;
    }

    public void AddMarker(Transform marker)
    {
        marker.SetParent(_markersContainer, false);
    }
}
