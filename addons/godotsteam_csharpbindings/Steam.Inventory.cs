namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Adds the promo item using the specified item
    /// </summary>
    /// <param name="item">The item</param>
    /// <returns>The int</returns>
    public static int AddPromoItem(long item)
    {
        return GetInstance().Call(Methods.AddPromoItem, item).AsInt32();
    }
    
    /// <summary>
    /// Adds the promo items using the specified items
    /// </summary>
    /// <param name="items">The items</param>
    /// <returns>The int</returns>
    public static int AddPromoItems(long[] items)
    {
        return GetInstance().Call(Methods.AddPromoItems, items).AsInt32();
    }
    
    /// <summary>
    /// Describes whether check result steam id
    /// </summary>
    /// <param name="steamIdExpected">The steam id expected</param>
    /// <param name="thisInventoryHandle">The this inventory handle</param>
    /// <returns>The bool</returns>
    public static bool CheckResultSteamID(ulong steamIdExpected, long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.CheckResultSteamID, steamIdExpected, thisInventoryHandle).AsBool();
    }
    
    /// <summary>
    /// Consumes the item using the specified item consume
    /// </summary>
    /// <param name="itemConsume">The item consume</param>
    /// <param name="quantity">The quantity</param>
    /// <returns>The int</returns>
    public static int ConsumeItem(ulong itemConsume, long quantity)
    {
        return GetInstance().Call(Methods.ConsumeItem, itemConsume, quantity).AsInt32();
    }
    
    /// <summary>
    /// Deserializes the result using the specified buffer
    /// </summary>
    /// <param name="buffer">The buffer</param>
    /// <returns>The int</returns>
    public static int DeserializeResult(byte[] buffer)
    {
        return GetInstance().Call(Methods.DeserializeResult, buffer).AsInt32();
    }
    
    /// <summary>
    /// Destroys the result using the specified this inventory handle
    /// </summary>
    /// <param name="thisInventoryHandle">The this inventory handle</param>
    public static void DestroyResult(long thisInventoryHandle = 0)
    {
        GetInstance().Call(Methods.DestroyResult, thisInventoryHandle);
    }
    
    /// <summary>
    /// Exchanges the items using the specified output items
    /// </summary>
    /// <param name="outputItems">The output items</param>
    /// <param name="outputQuantity">The output quantity</param>
    /// <param name="inputItems">The input items</param>
    /// <param name="inputQuantity">The input quantity</param>
    /// <returns>The int</returns>
    public static int ExchangeItems(long[] outputItems, uint outputQuantity, ulong inputItems, long inputQuantity)
    {
        return GetInstance().Call(Methods.ExchangeItems, outputItems, outputQuantity, inputItems, inputQuantity).AsInt32();
    }
    
    /// <summary>
    /// Generates the items using the specified items
    /// </summary>
    /// <param name="items">The items</param>
    /// <param name="quantity">The quantity</param>
    /// <returns>The int</returns>
    public static int GenerateItems(long[] items, long quantity)
    {
        return GetInstance().Call(Methods.GenerateItems, items, quantity).AsInt32();
    }
    
    /// <summary>
    /// Gets the all items
    /// </summary>
    /// <returns>The long</returns>
    public static long GetAllItems()
    {
        return GetInstance().Call(Methods.GetAllItems).AsInt64();
    }
    
    /// <summary>
    /// Gets the item definition property using the specified definition
    /// </summary>
    /// <param name="definition">The definition</param>
    /// <param name="name">The name</param>
    /// <returns>The string</returns>
    public static string GetItemDefinitionProperty(uint definition, string name)
    {
        return GetInstance().Call(Methods.GetItemDefinitionProperty, definition, name).AsString();
    }
    
    /// <summary>
    /// Gets the items by id using the specified id array
    /// </summary>
    /// <param name="idArray">The id array</param>
    /// <param name="count">The count</param>
    /// <returns>The int</returns>
    public static int GetItemsByID(ulong idArray, long count)
    {
        return GetInstance().Call(Methods.GetItemsByID, idArray, count).AsInt32();
    }
    
    /// <summary>
    /// Gets the item price using the specified definition
    /// </summary>
    /// <param name="definition">The definition</param>
    /// <returns>The ulong</returns>
    public static ulong GetItemPrice(long definition)
    {
        return GetInstance().Call(Methods.GetItemPrice, definition).AsUInt64();
    }
    
    /// <summary>
    /// Gets the items with prices using the specified length
    /// </summary>
    /// <param name="length">The length</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetItemsWithPrices(long length)
    {
        return GetInstance().Call(Methods.GetItemsWithPrices, length).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the num items with prices
    /// </summary>
    /// <returns>The long</returns>
    public static long GetNumItemsWithPrices()
    {
        return GetInstance().Call(Methods.GetNumItemsWithPrices).AsInt64();
    }
    
    /// <summary>
    /// Gets the result item property using the specified index
    /// </summary>
    /// <param name="index">The index</param>
    /// <param name="name">The name</param>
    /// <param name="thisInventoryHandle">The this inventory handle</param>
    /// <returns>The string</returns>
    public static string GetResultItemProperty(uint index, string name, long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultItemProperty, index, name, thisInventoryHandle).AsString();
    }
    
    /// <summary>
    /// Gets the result items using the specified this inventory handle
    /// </summary>
    /// <param name="thisInventoryHandle">The this inventory handle</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetResultItems(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultItems, thisInventoryHandle).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the result status using the specified this inventory handle
    /// </summary>
    /// <param name="thisInventoryHandle">The this inventory handle</param>
    /// <returns>The string</returns>
    public static string GetResultStatus(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultStatus, thisInventoryHandle).AsString();
    }
    
    /// <summary>
    /// Gets the result timestamp using the specified this inventory handle
    /// </summary>
    /// <param name="thisInventoryHandle">The this inventory handle</param>
    /// <returns>The uint</returns>
    public static uint GetResultTimestamp(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultTimestamp, thisInventoryHandle).AsUInt32();
    }
    
    /// <summary>
    /// Grants the promo items
    /// </summary>
    /// <returns>The long</returns>
    public static long GrantPromoItems()
    {
        return GetInstance().Call(Methods.GrantPromoItems).AsInt64();
    }
    
    /// <summary>
    /// Describes whether load item definitions
    /// </summary>
    /// <returns>The bool</returns>
    public static bool LoadItemDefinitions()
    {
        return GetInstance().Call(Methods.LoadItemDefinitions).AsBool();
    }
    
    /// <summary>
    /// Requests the eligible promo item definitions i ds using the specified steam id
    /// </summary>
    /// <param name="steamId">The steam id</param>
    public static void RequestEligiblePromoItemDefinitionsIDs(ulong steamId)
    {
        GetInstance().Call(Methods.RequestEligiblePromoItemDefinitionsIDs, steamId);
    }
    
    /// <summary>
    /// Requests the prices
    /// </summary>
    public static void RequestPrices()
    {
        GetInstance().Call(Methods.RequestPrices);
    }
    
    /// <summary>
    /// Serializes the result using the specified this inventory handle
    /// </summary>
    /// <param name="thisInventoryHandle">The this inventory handle</param>
    /// <returns>The string</returns>
    public static string SerializeResult(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.SerializeResult, thisInventoryHandle).AsString();
    }
    
    /// <summary>
    /// Starts the purchase using the specified items
    /// </summary>
    /// <param name="items">The items</param>
    /// <param name="quantity">The quantity</param>
    public static void StartPurchase(long[] items, long quantity)
    {
        GetInstance().Call(Methods.StartPurchase, items, quantity);
    }
    
    /// <summary>
    /// Transfers the item quantity using the specified item id
    /// </summary>
    /// <param name="itemId">The item id</param>
    /// <param name="quantity">The quantity</param>
    /// <param name="itemDestination">The item destination</param>
    /// <param name="split">The split</param>
    /// <returns>The int</returns>
    public static int TransferItemQuantity(ulong itemId, uint quantity, ulong itemDestination, bool split)
    {
        return GetInstance().Call(Methods.TransferItemQuantity, itemId, quantity, itemDestination, split).AsInt32();
    }
    
    /// <summary>
    /// Triggers the item drop using the specified definition
    /// </summary>
    /// <param name="definition">The definition</param>
    /// <returns>The int</returns>
    public static int TriggerItemDrop(long definition)
    {
        return GetInstance().Call(Methods.TriggerItemDrop, definition).AsInt32();
    }
    
    /// <summary>
    /// Starts the update properties
    /// </summary>
    public static void StartUpdateProperties()
    {
        GetInstance().Call(Methods.StartUpdateProperties);
    }
    
    /// <summary>
    /// Submits the update properties using the specified this inventory update handle
    /// </summary>
    /// <param name="thisInventoryUpdateHandle">The this inventory update handle</param>
    /// <returns>The int</returns>
    public static int SubmitUpdateProperties(long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SubmitUpdateProperties, thisInventoryUpdateHandle).AsInt32();
    }
    
    /// <summary>
    /// Describes whether remove property
    /// </summary>
    /// <param name="itemId">The item id</param>
    /// <param name="name">The name</param>
    /// <param name="thisInventoryUpdateHandle">The this inventory update handle</param>
    /// <returns>The bool</returns>
    public static bool RemoveProperty(ulong itemId, string name, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.RemoveProperty, itemId, name, thisInventoryUpdateHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether set property string
    /// </summary>
    /// <param name="itemId">The item id</param>
    /// <param name="name">The name</param>
    /// <param name="value">The value</param>
    /// <param name="thisInventoryUpdateHandle">The this inventory update handle</param>
    /// <returns>The bool</returns>
    public static bool SetPropertyString(ulong itemId, string name, string value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyString, itemId, name, value, thisInventoryUpdateHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether set property bool
    /// </summary>
    /// <param name="itemId">The item id</param>
    /// <param name="name">The name</param>
    /// <param name="value">The value</param>
    /// <param name="thisInventoryUpdateHandle">The this inventory update handle</param>
    /// <returns>The bool</returns>
    public static bool SetPropertyBool(ulong itemId, string name, bool value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyBool, itemId, name, value, thisInventoryUpdateHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether set property int
    /// </summary>
    /// <param name="itemId">The item id</param>
    /// <param name="name">The name</param>
    /// <param name="value">The value</param>
    /// <param name="thisInventoryUpdateHandle">The this inventory update handle</param>
    /// <returns>The bool</returns>
    public static bool SetPropertyInt(ulong itemId, string name, ulong value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyInt, itemId, name, value, thisInventoryUpdateHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether set property float
    /// </summary>
    /// <param name="itemId">The item id</param>
    /// <param name="name">The name</param>
    /// <param name="value">The value</param>
    /// <param name="thisInventoryUpdateHandle">The this inventory update handle</param>
    /// <returns>The bool</returns>
    public static bool SetPropertyFloat(ulong itemId, string name, float value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyFloat, itemId, name, value, thisInventoryUpdateHandle).AsBool();
    }

    /// <summary>
    /// The item flags enum
    /// </summary>
    [System.Flags]
    public enum ItemFlags : long
    {
        /// <summary>
        /// The no trade item flags
        /// </summary>
        NoTrade = 1,
        /// <summary>
        /// The removed item flags
        /// </summary>
        Removed = 256,
        /// <summary>
        /// The consumed item flags
        /// </summary>
        Consumed = 512
    }
}