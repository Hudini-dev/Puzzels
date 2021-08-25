using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowContextMenu : MonoBehaviour
{
    private Button _button;

    public Transform Panel;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        Debug.LogWarning(transform.position);
        Debug.LogWarning(transform.localPosition);

        Panel.position = transform.position + Vector3.right * 200;
    }
}
