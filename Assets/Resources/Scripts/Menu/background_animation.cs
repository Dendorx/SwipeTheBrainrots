using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class BackgroundAnimation : MonoBehaviour
{
    public RectTransform background;
    void Start()
    {
        background = GetComponent<RectTransform>();
        StartCoroutine(AnimateBackground());
    }

    public IEnumerator AnimateBackground()
    {
        while (true)
        {
            background.DOAnchorPos(new Vector2(665, -373.18f), 0).SetEase(Ease.Linear);
            yield return new WaitForSeconds(0);
            background.DOAnchorPos(new Vector2(570, 395), 15).SetEase(Ease.Linear);
            yield return new WaitForSeconds(5);
        }
    }
}
