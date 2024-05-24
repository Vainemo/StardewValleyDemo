using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager:SingletionMonobehaviour<InventoryManager>
{
    private Dictionary<int, ItemDetails> _itemDetailsDicTionary;
    /// <summary>
    /// ���еĲֿ⣨��ұ������ֿ⣬װ����
    /// </summary>
    public List<InventoryItem>[] InventoryItems;
    /// <summary>
    /// �����������������
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
    /// �����ֵ�
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
    /// ������Ʒ���뷵�ؾ�����Ϣ
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
        //���û�У����ڿ�������һ��
        else
        {
            AddItemAtPosition(inventoryList, itemCode);
        }
        EventHandler.CallInventoryUpdatedEvent(inventoryLocation, InventoryItems[(int)inventoryLocation]);
    }
    /// <summary>
    /// �ڱ�����������Ʒ
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
    /// ������Ʒid������Ʒλ��
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
