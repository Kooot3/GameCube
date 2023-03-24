using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonAnimation : MonoBehaviour , IPointerEnterHandler , IPointerExitHandler
{
    private Vector3 _originalScale;
    private Vector3 _scaleTo;
    [SerializeField] private float _duraction = 2.0f;
    [SerializeField] private float _scaleButton = 2.0f;
    [SerializeField] private Ease _ease = Ease.InOutSine;

    private void Start()
    {
        _originalScale = transform.localScale;
        _scaleTo = _originalScale * _scaleButton;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(_scaleTo, _duraction).SetEase(_ease);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(_originalScale, _duraction).SetEase(_ease);
    }
}
