using System;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
/// <param name="inputX">X�����ƶ�����</param>
/// <param name="inputY">Y�����ƶ�����</param>
/// <param name="isWalking">�Ƿ�������״̬</param>
/// <param name="isRuning">�Ƿ����ܲ�״̬</param>
/// <param name="isIdle">�Ƿ��Ǵ���״̬</param>
/// <param name="isCarrying">�Ƿ�Я����Ʒ</param>
/// <param name="toolEffect">����Ч��</param>
/// <param name="isUsingToolRight">���߳���ʹ��</param>
/// <param name="isUsingToolLeft">���߳���ʹ��</param>
/// <param name="isUsingToolUp">���߳���ʹ��</param>
/// <param name="isUsingToolDown">���߳���ʹ��</param>
/// <param name="isLiftingToolRight">�����Ƿ�����</param>
/// <param name="isLiftingToolLeft">�����Ƿ�����</param>
/// <param name="isLiftingToolUp">�����Ƿ�����</param>
/// <param name="isLiftingToolDown">�����Ƿ�����</param>
/// <param name="isPickRight">�Ƿ�ѡ������</param>
/// <param name="isPickLeft">�����Ƿ�����</param>
/// <param name="isPickUP">�Ƿ�ѡ������</param>
/// <param name="isPickingDown">�Ƿ�ѡ������</param>
/// <param name="isSwingingToolRight">����ҡ��</param>
/// <param name="isSwingingToolLeft">����ҡ��</param>
/// <param name="isSwingingToolUp">����ҡ��</param>
/// <param name="isSwingingToolDown">����ҡ��</param>
/// <param name="idleUp">���ϴ���</param>
/// <param name="idleDown">���´���</param>
/// <param name="idleLeft">�������</param>
/// <param name="idleRight">���Ҵ���</param>
public delegate void MovementDelegate(float inputX,float inputY,bool isWalking,bool isRuning,bool isIdle,bool isCarrying,ToolEffect toolEffect,
    bool isUsingToolRight,bool isUsingToolLeft,bool isUsingToolUp,bool isUsingToolDown,bool isLiftingToolRight,bool isLiftingToolLeft,
    bool isLiftingToolUp, bool isLiftingToolDown,bool isPickRight, bool isPickLeft, bool isPickUP,bool isPickingDown,bool isSwingingToolRight,bool isSwingingToolLeft,bool isSwingingToolUp,bool isSwingingToolDown,bool idleUp,
    bool idleDown,bool idleLeft,bool idleRight);
public static class EventHandler
{
    public static event Action<InventoryLocation, List<InventoryItem>> InventoryUpdatedEvent;
    public static void CallInventoryUpdatedEvent(InventoryLocation location, List<InventoryItem> inventoryItems)
    {
        if (InventoryUpdatedEvent!=null)
        {
            InventoryUpdatedEvent(location, inventoryItems);
        }
    }

    public static event MovementDelegate MovementEvent;

    public static void CallMovementEvent(float inputX, float inputY, bool isWalking, bool isRuning, bool isIdle, bool isCarrying, ToolEffect toolEffect,
    bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown, bool isLiftingToolRight, bool isLiftingToolLeft,
    bool isLiftingToolUp, bool isLiftingToolDown, bool isPickRight, bool isPickLeft, bool isPickUP, bool isPickingDown, bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown, bool idleUp,
    bool idleDown, bool idleLeft, bool idleRight)
    {
        if (MovementEvent!=null)
        {
            MovementEvent(inputX,inputY,isWalking,isRuning,isIdle,isCarrying,toolEffect,isUsingToolRight,isUsingToolLeft,isUsingToolUp,isUsingToolDown,isLiftingToolRight
                ,isLiftingToolLeft,isLiftingToolUp,isLiftingToolDown,isPickRight,isPickLeft,isPickUP,isPickingDown,isSwingingToolRight,isSwingingToolLeft,isSwingingToolUp,isSwingingToolDown,idleUp,idleDown,idleLeft,idleRight);
        }
    }
}
