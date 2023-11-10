using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class TitleScreenManager : MonoBehaviour
{
    public RectTransform TitleScreen, options, credits;
    public float uiSlideSpeed;
    // Start is called before the first frame update
    void Start()
    {
        TitleScreen.DOAnchorPos(Vector2.zero, 0.25f);
        uiSlideSpeed = 1f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void optionsButton()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(TitleScreen.DOScale(Vector2.zero, 1f));
        seq.Append(TitleScreen.DOAnchorPos(new Vector2(0, -1920), uiSlideSpeed).SetEase(Ease.Linear));
        options.DOAnchorPos(Vector2.zero, uiSlideSpeed).SetEase(Ease.Linear);
    }

    public void closeOptions()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(options.DOScale(Vector2.zero, 0.5f));
        seq.Append(options.DOAnchorPos(new Vector2(0, 1080), uiSlideSpeed).SetEase(Ease.Linear));
        seq.Append(options.DOScale(Vector2.one, 0.5f));
        Sequence seq2 = DOTween.Sequence();
        seq2.Append(TitleScreen.DOAnchorPos(Vector2.zero, uiSlideSpeed).SetEase(Ease.Linear));
        seq2.Append(TitleScreen.DOScale(Vector2.one, 0.5f));
    }

    public void creditsButton()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(TitleScreen.DOScale(Vector2.zero, 1f));
        seq.Append(TitleScreen.DOAnchorPos(new Vector2(0, 1920), uiSlideSpeed).SetEase(Ease.Linear));
        credits.DOAnchorPos(Vector2.zero, uiSlideSpeed).SetEase(Ease.Linear);
    }

    public void closeCredits()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(credits.DOScale(Vector2.zero, 0.5f));
        seq.Append(credits.DOAnchorPos(new Vector2(19200, 0), uiSlideSpeed).SetEase(Ease.Linear));
        seq.Append(credits.DOScale(Vector2.one, 0.5f));
        Sequence seq2 = DOTween.Sequence();
        seq2.Append(TitleScreen.DOAnchorPos(Vector2.zero, uiSlideSpeed).SetEase(Ease.Linear));
        seq2.Append(TitleScreen.DOScale(Vector2.one, 0.5f));
    }
}
