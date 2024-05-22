using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private int _loops = int.MaxValue;

    private void Start()
    {
        transform.DOScale(_endValue, _duration).SetLoops(_loops, _loopType);
    }
}
