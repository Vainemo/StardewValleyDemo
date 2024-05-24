using UnityEngine;

public static class Settings 
{
    //当玩家经过时，物体变到透明的时间
    public const float fadeInSeconds = 0.25f;
    //当玩家离开时，物体从透明变不透明的时间
    public const float fadeOutSeconds = 0.25f;
    public const float TargetAlpha = 0.45f;
    /// <summary>
    /// 人物的初始仓库大小
    /// </summary>
    public static int PlayerInitialInventoryCapacity = 24;
    /// <summary>
    /// 最大仓库
    /// </summary>
    public static int PlayerMaximumInventoryCapacity = 48;
    public const float runingSpeed = 5.333f;
    public const float walkingSpeed = 2.666f;
    public static int xInput;
    public static int yInput;
    public static int isWalking;
    public static int isRuning;
    public static int toolEffect;
    public static int isIdle;
    public static int isCarrying;
    public static int isUsingToolRight;
    public static int isUsingToolLeft;
    public static int isUsingToolUp;
    public static int isUsingToolDown;
    public static int isLiftingToolRight;
    public static int isLiftingToolLeft;
    public static int isLiftingToolUp;
    public static int isLiftingToolDown;
    public static int isPickingRight;
    public static int isPickingLeft;
    public static int isPickingUP;
    public static int isPickingDown;
    public static int isSwingingToolRight;
    public static int isSwingingToolLeft;
    public static int isSwingingToolUp;
    public static int isSwingingToolDown;
    public static int idleUp;
    public static int idleDown;
    public static int idleLeft;
    public static int idleRight;
    static Settings()
    {
        xInput = Animator.StringToHash("xInput");
        yInput= Animator.StringToHash("yInput");
        isWalking = Animator.StringToHash("isWalking");
        isRuning = Animator.StringToHash("isRunning");
        toolEffect= Animator.StringToHash("toolEffect");
        isIdle = Animator.StringToHash("isIdle");
        isCarrying = Animator.StringToHash("isCarrying");
        isUsingToolRight = Animator.StringToHash("isUsingToolRight");
        isUsingToolLeft = Animator.StringToHash("isUsingToolLeft");
        isUsingToolUp= Animator.StringToHash("isUsingToolUp");
        isUsingToolDown = Animator.StringToHash("isUsingToolDown");
        isLiftingToolRight = Animator.StringToHash("isLiftingToolRight");
        isLiftingToolLeft = Animator.StringToHash("isLiftingToolLeft");
        isLiftingToolUp = Animator.StringToHash("isLiftingToolUp");
        isLiftingToolDown = Animator.StringToHash("isLiftingToolDown");
        isPickingRight = Animator.StringToHash("isPickingRight");
        isPickingLeft = Animator.StringToHash("isPickingLeft");
        isPickingUP = Animator.StringToHash("isPickingUP");
        isPickingDown = Animator.StringToHash("isPickingDown");
        isSwingingToolRight = Animator.StringToHash("isSwingingToolRight");
        isSwingingToolUp = Animator.StringToHash("isSwingingToolUp");
        isSwingingToolDown = Animator.StringToHash("isSwingingToolDown");
        idleUp = Animator.StringToHash("idleUp");
        idleDown = Animator.StringToHash("idleDown");
        idleLeft = Animator.StringToHash("idleLeft");
        idleRight = Animator.StringToHash("idleRight");
    }
}
