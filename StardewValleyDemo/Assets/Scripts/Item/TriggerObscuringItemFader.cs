using UnityEngine;

public class TriggerObscuringItemFader : MonoBehaviour
{
    /// <summary>
    /// ��ײ��������ײʱ�����ķ���
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
    /// ������ײ���뿪ʱ�������ҷ���
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
