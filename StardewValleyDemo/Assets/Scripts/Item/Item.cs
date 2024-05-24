using System;
using UnityEngine;

public class Item : MonoBehaviour
{
    [ItemCodeDescription]
    [SerializeField]
    private int _itemCode;
    private SpriteRenderer spriteRenderer;
    public int ItemCode 
    { 
        get { return _itemCode; } 
        set {  _itemCode = value; }
    }
    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }
    private void Start()
    {
        if (ItemCode != 0)
        {
            Init(ItemCode);
        }
    }

    public void Init(int itemCodeParam)
    {
        if (itemCodeParam != 0)
        {
            ItemCode=itemCodeParam;
            ItemDetails itemDetails=InventoryManager.Instance.GetItemDetails(ItemCode);
            spriteRenderer.sprite=itemDetails.ItemSprite;
            if (itemDetails.ItemType==ItemType.Reapable_scenary)
            {
                gameObject.AddComponent<ItemNudge>();
            }
        }
    }
}