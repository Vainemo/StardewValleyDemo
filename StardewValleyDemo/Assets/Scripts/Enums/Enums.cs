
public enum ToolEffect
{
   none,
   watering
}
public enum Direction
{
    up,
    down,
    left,
    right
}
public enum ItemType
{
    /// <summary>
    /// 种子
    /// </summary>
    Seed,
    /// <summary>
    /// 商品
    /// </summary>
    Commodity,
    /// <summary>
    /// 水壶
    /// </summary>
    Watering_tool,
    Hoeing_tool,
    /// <summary>
    /// 收集工具
    /// </summary>
    Chopping_tool,
    Breaking_tool,
    Reaping_tool,
    Collecting_tool,
    Reapable_scenary,
    Furniture,
    None,
    Count
}
public enum InventoryLocation
{
    /// <summary>
    /// 玩家背包
    /// </summary>
    Player,
    /// <summary>
    /// 身上装备
    /// </summary>
    Chest,
    /// <summary>
    /// 表示能存物品的地方数量，目前是2
    /// </summary>
    Count
}
