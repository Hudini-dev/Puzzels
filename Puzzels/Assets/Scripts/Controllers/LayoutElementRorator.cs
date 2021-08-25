using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(LayoutElement))]
public class LayoutElementRorator : MonoBehaviour
{
    private LayoutElement _layoutElement;

    private Vector2 _size;
    private float _rotationAngle;

    public bool Use;

    private void Awake()
    {
        _layoutElement = GetComponent<LayoutElement>();
        RectTransform rect = GetComponent<RectTransform>();
        _size = new Vector2(_layoutElement.preferredWidth, _layoutElement.preferredHeight);
    }

    public float Rotation
    {
        get => _rotationAngle;
        set
        {
            float rad = value * Mathf.Deg2Rad;
            _layoutElement.preferredWidth = Mathf.Sin(rad) * _size.x + Mathf.Cos(rad) * _size.y;
            _layoutElement.preferredHeight = Mathf.Cos(rad) * _size.x + Mathf.Sin(rad) * _size.y;
            _rotationAngle = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Use)
        {
            Rotation = _rotationAngle + 90;
            Use = false;
        }
    }
}
