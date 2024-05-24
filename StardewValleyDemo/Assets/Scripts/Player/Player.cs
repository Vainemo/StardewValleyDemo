using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SingletionMonobehaviour<Player>
{
    private float xInput;
    private float yInput;
    private bool isWalking;
    private bool isRuning;
    private ToolEffect toolEffect = ToolEffect.none;
    private bool isIdle;
    private bool isCarrying = false;
    private bool isUsingToolRight;
    private bool isUsingToolLeft;
    private bool isUsingToolUp;
    private bool isUsingToolDown;
    private bool isLiftingToolRight;
    private bool isLiftingToolLeft;
    private bool isLiftingToolUp;
    private bool isLiftingToolDown;
    private bool isPickingRight;
    private bool isPickingLeft;
    private bool isPickingUP;
    private bool isPickingDown;
    private bool isSwingingToolRight;
    private bool isSwingingToolLeft;
    private bool isSwingingToolUp;
    private bool isSwingingToolDown;
    private bool idleUp;
    private bool idleDown;
    private bool idleLeft;
    private bool idleRight;
    private Rigidbody2D rigidBoy2D;

    private Camera mainCamera;
#pragma warning disable 414
    private Direction playerDirection;
#pragma warning restore 414
    private float movementSpeed;
    private bool _playInputIsDisabled = false;
    public bool PlayInputIsDisabled { get => _playInputIsDisabled; set => _playInputIsDisabled = value; }
    protected override void Awake()
    {
        base.Awake();
        rigidBoy2D= GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }
    private void Update()
    {
        #region Player Input
        ResetAnimationTriggers();
        PlayerMovementInput();
        PlayerWalkInput();
        EventHandler.CallMovementEvent(xInput, yInput, isWalking, isRuning, isIdle, isCarrying, toolEffect, isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown, isLiftingToolRight
                , isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown, isPickingRight, isPickingLeft, isPickingUP, isPickingDown, isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown, false, false, false, false);
        #endregion
    }
    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        Vector2 move = new Vector2(xInput * movementSpeed * Time.deltaTime, yInput * movementSpeed * Time.deltaTime);
        rigidBoy2D.MovePosition(rigidBoy2D.position + move);
    }
    private void PlayerWalkInput()
    {
        if (Input.GetKey(KeyCode.LeftShift)|| Input.GetKey(KeyCode.RightShift))
        {
            isRuning = false;
            isWalking= true;
            isIdle= false;
            movementSpeed = Settings.walkingSpeed;
        }
        else
        {
            isRuning = true;
            isWalking = false;
            isIdle = false;
            movementSpeed = Settings.runingSpeed;
        }
    }

    private void PlayerMovementInput()
    {
        yInput = Input.GetAxisRaw("Vertical");
        xInput = Input.GetAxisRaw("Horizontal");
        if (yInput!=0&&xInput!=0)
        {
            xInput = xInput * 0.71F;
            yInput = yInput * 0.71F;
        }
        if (yInput!=0||xInput!=0)
        {
            isRuning= true;
            isWalking = false;
            isIdle = false;
            movementSpeed = Settings.runingSpeed;
            if (xInput <0)
            {
                playerDirection =Direction.left;
            }
            else if(xInput>0)
            {
                playerDirection =Direction.right;
            }
            else if(yInput<0)
            {
                playerDirection =Direction.down;
            }
            else
            {
                playerDirection =Direction.up;
            }
        }
        else if(xInput==0&&yInput==0)
        { 
            isRuning= false;
            isWalking= false;
            isIdle = true;
        }
    }

    private void ResetAnimationTriggers()
    {
        isPickingDown= false;
        isPickingLeft= false;
        isPickingRight= false;
        isPickingUP= false;
        isUsingToolDown= false;
        isUsingToolLeft= false;
        isUsingToolRight= false;
        isUsingToolUp= false;
        isLiftingToolDown= false;
        isLiftingToolLeft= false;
        isLiftingToolRight= false;
        isLiftingToolUp= false;
        isSwingingToolDown= false;
        isSwingingToolLeft= false;
        isSwingingToolRight= false;
        isSwingingToolUp= false;
        toolEffect = ToolEffect.none;
    }
    public Vector3 GetPlayerViewportPosition()
    {
        return mainCamera.WorldToViewportPoint(transform.position);
    }

}
