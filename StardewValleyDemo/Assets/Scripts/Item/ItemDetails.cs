using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    /// <summary>
    /// ��Ʒ���
    /// </summary>
    public int ItemCode;
    /// <summary>
    /// ��Ʒ����
    /// </summary>
    public ItemType ItemType;
    /// <summary>
    /// ��Ʒ��������
    /// </summary>
    public string ItemDescription;
    /// <summary>
    /// ����
    /// </summary>
    public Sprite ItemSprite;
    /// <summary>
    /// ��Ʒ����
    /// </summary>
    public string ItemLongDescription;
    /// <summary>
    /// �ܹ�ʰȡ/�ӳ���Ʒ����Ч�뾶
    /// </summary>
    public short ItemUserGridRedius;
    /// <summary>
    /// ʹ�ð뾶
    /// </summary>
    public float ItemUserRadius;
    public bool IsStartingItem;
    /// <summary>
    /// �Ƿ��ܱ�����
    /// </summary>
    public bool CanBePickedUp;
    /// <summary>
    /// �Ƿ��ܱ�����
    /// </summary>
    public bool CanBeDropped;
    /// <summary>
    /// �Ƿ��ܳ�
    /// </summary>
    public bool CanBeEaten;
    /// <summary>
    /// �Ƿ���Я��
    /// </summary>
    public bool CanBeCarried;
}
