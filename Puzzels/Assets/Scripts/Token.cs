using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Token : MonoBehaviour
    {
        [SerializeField] private Text _counter;
        [SerializeField] private Image _icon;

        public void Init(Sprite icon, int count)
        {
            _counter.text = count.ToString();
            _icon.sprite = icon;
            _counter.gameObject.SetActive(count > 0);
        }

        public void SetAmount(int amount)
        {
            _counter.text = amount.ToString();
            _counter.gameObject.SetActive(amount > 0);
        }
    }
}
