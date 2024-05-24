using UnityEngine;

public class TriggerObscuringItemFader : MonoBehaviour
{
    /// <summary>
    /// 碰撞器发生碰撞时触发的方法
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ObscuringItemFader[] obscuringItemFaders=collision.gameObject.GetComponentsInChildren<ObscuringItemFader>();
        if(obscuringItemFaders .Length>0 )
        {
            for(int i = 0;i<obscuringItemFaders .Length;i++)
            {
                obscuringItemFaders[i].FadeOut();
            }
        }
    }
    /// <summary>
    /// 两个碰撞器离开时触发的我方法
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerExit2D(Collider2D collision)
    {
        ObscuringItemFader[] obscuringItemFaders = collision.gameObject.GetComponentsInChildren<ObscuringItemFader>();
        if (obscuringItemFaders.Length > 0)
        {
            for (int i = 0; i < obscuringItemFaders.Length; i++)
            {
                obscuringItemFaders[i].FadeIn();
            }
        }
    }

}
