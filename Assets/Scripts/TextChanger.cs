using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("qwertyuiop[]", _duration));
        sequence.Append(_text.DOText("asdfghjkl;'", _duration).SetRelative());
        sequence.Append(_text.DOText("zxcvbnm,./", _duration, true, ScrambleMode.All));
    }
}
