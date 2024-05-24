using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerAnimationTest : MonoBehaviour
{
    public  float xInput;
    public  float yInput;
    public  bool isWalking;
    public  bool isRuning;
    public  ToolEffect toolEffect;
    public  bool isIdle;
    public  bool isCarrying;
    public  bool isUsingToolRight;
    public  bool isUsingToolLeft;
    public  bool isUsingToolUp;
    public  bool isUsingToolDown;
    public  bool isLiftingToolRight;
    public  bool isLiftingToolLeft;
    public  bool isLiftingToolUp;
    public  bool isLiftingToolDown;
    public  bool isPickingRight;
    public  bool isPickingLeft;
    public  bool isPickingUP;
    public  bool isPickingDown;
    public  bool isSwingingToolRight;
    public  bool isSwingingToolLeft;
    public  bool isSwingingToolUp;
    public  bool isSwingingToolDown;
    public  bool idleUp;
    public  bool idleDown;
    public  bool idleLeft;
    public  bool idleRight;

    // Update is called once per frame
    void Update()
    {
        EventHandler.CallMovementEvent(xInput, xInput, isWalking, isRuning, isIdle, isCarrying, toolEffect, isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown, isLiftingToolRight
                , isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown, isPickingRight, isPickingLeft, isPickingUP, isPickingDown, isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown, idleUp, idleDown, idleLeft, idleRight);
    }
}
