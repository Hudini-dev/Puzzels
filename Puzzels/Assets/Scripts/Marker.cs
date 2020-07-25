using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Marker : MonoBehaviour
    {
        [SerializeField] private Text _counter;
        [SerializeField] private Image _icon;

        public void Init(Sprite icon, int count)
        {
            _counter.text = count.ToString();
            _icon.sprite = icon;
            _counter.gameObject.SetActive(count > 0);
        }
    }
}
