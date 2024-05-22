using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _endValue;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private int _loops = int.MaxValue;
    private Renderer _renderer;

    private void Start()
    {
        _renderer = transform.GetComponent<Renderer>();
        _renderer.material.DOColor(_endValue, _duration).SetLoops(_loops, _loopType);
    }
}
