using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private int _loops = int.MaxValue;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration).SetLoops(_loops, _loopType);
    }
}
