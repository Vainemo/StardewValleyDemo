using System;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
/// <param name="inputX">X方向移动距离</param>
/// <param name="inputY">Y方向移动距离</param>
/// <param name="isWalking">是否是行走状态</param>
/// <param name="isRuning">是否是跑步状态</param>
/// <param name="isIdle">是否是待机状态</param>
/// <param name="isCarrying">是否携带物品</param>
/// <param name="toolEffect">工具效果</param>
/// <param name="isUsingToolRight">工具朝右使用</param>
/// <param name="isUsingToolLeft">工具朝左使用</param>
/// <param name="isUsingToolUp">工具朝上使用</param>
/// <param name="isUsingToolDown">工具朝上使用</param>
/// <param name="isLiftingToolRight">工具是否向右</param>
/// <param name="isLiftingToolLeft">工具是否向左</param>
/// <param name="isLiftingToolUp">工具是否向上</param>
/// <param name="isLiftingToolDown">工具是否向下</param>
/// <param name="isPickRight">是否选择向右</param>
/// <param name="isPickLeft">工具是否向左</param>
/// <param name="isPickUP">是否选择向上</param>
/// <param name="isPickingDown">是否选择向下</param>
/// <param name="isSwingingToolRight">向右摇摆</param>
/// <param name="isSwingingToolLeft">向左摇摆</param>
/// <param name="isSwingingToolUp">向上摇摆</param>
/// <param name="isSwingingToolDown">向下摇摆</param>
/// <param name="idleUp">朝上待机</param>
/// <param name="idleDown">朝下待机</param>
/// <param name="idleLeft">朝左待机</param>
/// <param name="idleRight">朝右待机</param>
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
