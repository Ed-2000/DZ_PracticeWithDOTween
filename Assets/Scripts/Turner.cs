using UnityEngine;
using DG.Tweening;

public class Turner : MonoBehaviour
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private float _duration;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private LoopType _loopType;
    
    private int _loops = int.MaxValue;

    private void Start()
    {
        transform.DOLocalRotate(_endValue, _duration, _rotateMode).SetLoops(_loops, _loopType);
    }
}
