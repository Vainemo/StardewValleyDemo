using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ObscuringItemFader : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        spriteRenderer=gameObject.GetComponent<SpriteRenderer>();
    }
    /// <summary>
    /// µ­³ö
    /// </summary>
    public void FadeOut()
    {
        StartCoroutine(FadeOutRoutine() );
    }
    /// <summary>
    /// 
    /// </summary>
    public void FadeIn()
    {
        StartCoroutine(FadeInRouttine());
    }
    private IEnumerator FadeInRouttine()
    {
        float currentAlpha=spriteRenderer.color.a;
        float distance = 1f-currentAlpha;
        while(1f-currentAlpha>0.01f)
        {
            currentAlpha += distance / Settings.fadeInSeconds * Time.deltaTime;
            spriteRenderer.color = new Color(1f, 1f, 1f, currentAlpha);
            yield return null;
        }
        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
    }
    private IEnumerator FadeOutRoutine()
    {
        float currentAlpha = spriteRenderer.color.a;
        float distance=currentAlpha-Settings.TargetAlpha;
        while(currentAlpha-Settings.TargetAlpha>0.01f)
        {
            currentAlpha = currentAlpha - distance / Settings.fadeInSeconds*Time.deltaTime;
            spriteRenderer.color=new Color(1f,1f,1f,currentAlpha);
            yield return null;
        }
        spriteRenderer.color=new Color(1f,1f,1f,Settings.TargetAlpha);
    }
}
