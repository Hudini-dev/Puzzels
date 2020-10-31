using System.Collections;
using UnityEngine;

public class ContainerController : MonoBehaviour
{
    [SerializeField] private Transform _frame;
    [SerializeField] private Transform _labelMask;
    [SerializeField] private Transform _container;

    public Transform Container => _container;

    private void Start()
    {
        StartCoroutine(SetFrameParent());
    }

    public void Clear()
    {
        foreach (Transform child in _container)
        {
            Destroy(child.gameObject);
        }
    }

    private IEnumerator SetFrameParent()
    {
        yield return new WaitForEndOfFrame();

        _frame.SetParent(_labelMask);
    }
}
