using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager:SingletionMonobehaviour<InventoryManager>
{
    private Dictionary<int, ItemDetails> _itemDetailsDicTionary;
    /// <summary>
    /// 所有的仓库（玩家背包，仓库，装备）
    /// </summary>
    public List<InventoryItem>[] InventoryItems;
    /// <summary>
    /// 各个背包的最大数量
    /// </summary>
    [HideInInspector]
    public int[] InventoryListCapacityInArray;
    [SerializeField]
    private SO_ItemList _so_ItemList;
    protected override void Awake()
    {
        base.Awake();
        CreateInventoryLists();
        CreateItemDetailsDictionary();

    }

    private void CreateInventoryLists()
    {
        InventoryItems=new List<InventoryItem>[(int)InventoryLocation.Count];
        for (int i = 0; i < (int)InventoryLocation.Count; i++)
        {
            InventoryItems[i] = new List<InventoryItem>();
        }
        InventoryListCapacityInArray = new int[(int)InventoryLocation.Count];
        InventoryListCapacityInArray[(int)InventoryLocation.Player] = Settings.PlayerInitialInventoryCapacity;
    }

    /// <summary>
    /// 创建字典
    /// </summary>
    private void CreateItemDetailsDictionary()
    {
       _itemDetailsDicTionary = new Dictionary<int, ItemDetails>();
        foreach(ItemDetails itemDetails  in _so_ItemList.ItemDatails)
        {
            _itemDetailsDicTionary.Add(itemDetails.ItemCode, itemDetails);
        }
    }
    /// <summary>
    /// 根据物品代码返回具体信息
    /// </summary>
    /// <param name="itemCode"></param>
    /// <returns></returns>
    public ItemDetails GetItemDetails(int itemCode)
    {
        ItemDetails itemDetails;
        if (_itemDetailsDicTionary.TryGetValue(itemCode,out itemDetails))
        {
            return itemDetails;
        }
        else
        {
            return null;
        }
    }
    public void AddItem(InventoryLocation inventoryLocation, Item item,GameObject gameObject)
    {
        AddItem(inventoryLocation, item);
        Destroy(gameObject);
    }
    public void AddItem(InventoryLocation inventoryLocation,Item item)
    {
        int itemCode=item.ItemCode;
        List<InventoryItem> inventoryList = InventoryItems[(int)inventoryLocation];
        int itemPosition = FindItemInInventory(inventoryLocation, itemCode);
        if (itemPosition!=-1)
        {
            AddItemAtPosition(inventoryList, itemCode, itemPosition);
        }
        //如果没有，则在库存中添加一个
        else
        {
            AddItemAtPosition(inventoryList, itemCode);
        }
        EventHandler.CallInventoryUpdatedEvent(inventoryLocation, InventoryItems[(int)inventoryLocation]);
    }
    /// <summary>
    /// 在背包里增加物品
    /// </summary>
    /// <param name="inventoryList"></param>
    /// <param name="itemCode"></param>
    /// <param name="itemPosition"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void AddItemAtPosition(List<InventoryItem> inventoryList, int itemCode, int itemPosition)
    {
      InventoryItem inventoryItem=new InventoryItem();
        int quantity = inventoryList[itemPosition].ItemQuantity + 1;
        inventoryItem.ItemQuantity = quantity;
        inventoryItem.ItemCode = itemCode;
        inventoryList[itemPosition] = inventoryItem;
    }
    private void AddItemAtPosition(List<InventoryItem> inventoryList, int itemCode)
    {
        InventoryItem inventoryItem=new InventoryItem();
        inventoryItem.ItemCode = itemCode;
        inventoryList.Add(inventoryItem);

    }
    /// <summary>
    /// 根据物品id返回物品位置
    /// </summary>
    private int FindItemInInventory(InventoryLocation inventoryLocation, int itemCode)
    {
       List<InventoryItem> inventoryItems= InventoryItems[(int)inventoryLocation];
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            if (inventoryItems[i].ItemCode==itemCode)
            {
                return i;
            }
        }
        return -1;
    }
}
