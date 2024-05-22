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

        ChangeText1();
        Invoke(nameof(ChangeText2), _duration);
        Invoke(nameof(ChangeText3), _duration + _duration);
    }

    private void ChangeText1()
    {
        _text.DOText("qwertyuiop[]", _duration);
    }

    private void ChangeText2()
    {
        _text.DOText("asdfghjkl;'", _duration).SetRelative();
    }

    private void ChangeText3()
    {
        _text.DOText("zxcvbnm,./", _duration, true, ScrambleMode.All);
    }
}
