using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    /// <summary>
    /// 物品编号
    /// </summary>
    public int ItemCode;
    /// <summary>
    /// 物品类型
    /// </summary>
    public ItemType ItemType;
    /// <summary>
    /// 物品简略名称
    /// </summary>
    public string ItemDescription;
    /// <summary>
    /// 精灵
    /// </summary>
    public Sprite ItemSprite;
    /// <summary>
    /// 物品描述
    /// </summary>
    public string ItemLongDescription;
    /// <summary>
    /// 能够拾取/扔出物品的有效半径
    /// </summary>
    public short ItemUserGridRedius;
    /// <summary>
    /// 使用半径
    /// </summary>
    public float ItemUserRadius;
    public bool IsStartingItem;
    /// <summary>
    /// 是否能被捡起
    /// </summary>
    public bool CanBePickedUp;
    /// <summary>
    /// 是否能被丢弃
    /// </summary>
    public bool CanBeDropped;
    /// <summary>
    /// 是否能吃
    /// </summary>
    public bool CanBeEaten;
    /// <summary>
    /// 是否能携带
    /// </summary>
    public bool CanBeCarried;
}
