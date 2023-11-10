namespace GodotSteam;

public static partial class Steam
{
    public static int AddPromoItem(long item)
    {
        return GetInstance().Call(Methods.AddPromoItem, item).AsInt32();
    }
    
    public static int AddPromoItems(long[] items)
    {
        return GetInstance().Call(Methods.AddPromoItems, items).AsInt32();
    }
    
    public static bool CheckResultSteamID(ulong steamIdExpected, long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.CheckResultSteamID, steamIdExpected, thisInventoryHandle).AsBool();
    }
    
    public static int ConsumeItem(ulong itemConsume, long quantity)
    {
        return GetInstance().Call(Methods.ConsumeItem, itemConsume, quantity).AsInt32();
    }
    
    public static int DeserializeResult(byte[] buffer)
    {
        return GetInstance().Call(Methods.DeserializeResult, buffer).AsInt32();
    }
    
    public static void DestroyResult(long thisInventoryHandle = 0)
    {
        GetInstance().Call(Methods.DestroyResult, thisInventoryHandle);
    }
    
    public static int ExchangeItems(long[] outputItems, uint outputQuantity, ulong inputItems, long inputQuantity)
    {
        return GetInstance().Call(Methods.ExchangeItems, outputItems, outputQuantity, inputItems, inputQuantity).AsInt32();
    }
    
    public static int GenerateItems(long[] items, long quantity)
    {
        return GetInstance().Call(Methods.GenerateItems, items, quantity).AsInt32();
    }
    
    public static long GetAllItems()
    {
        return GetInstance().Call(Methods.GetAllItems).AsInt64();
    }
    
    public static string GetItemDefinitionProperty(uint definition, string name)
    {
        return GetInstance().Call(Methods.GetItemDefinitionProperty, definition, name).AsString();
    }
    
    public static int GetItemsByID(ulong idArray, long count)
    {
        return GetInstance().Call(Methods.GetItemsByID, idArray, count).AsInt32();
    }
    
    public static ulong GetItemPrice(long definition)
    {
        return GetInstance().Call(Methods.GetItemPrice, definition).AsUInt64();
    }
    
    public static Godot.Collections.Array GetItemsWithPrices(long length)
    {
        return GetInstance().Call(Methods.GetItemsWithPrices, length).AsGodotArray();
    }
    
    public static long GetNumItemsWithPrices()
    {
        return GetInstance().Call(Methods.GetNumItemsWithPrices).AsInt64();
    }
    
    public static string GetResultItemProperty(uint index, string name, long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultItemProperty, index, name, thisInventoryHandle).AsString();
    }
    
    public static Godot.Collections.Array GetResultItems(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultItems, thisInventoryHandle).AsGodotArray();
    }
    
    public static string GetResultStatus(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultStatus, thisInventoryHandle).AsString();
    }
    
    public static uint GetResultTimestamp(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultTimestamp, thisInventoryHandle).AsUInt32();
    }
    
    public static long GrantPromoItems()
    {
        return GetInstance().Call(Methods.GrantPromoItems).AsInt64();
    }
    
    public static bool LoadItemDefinitions()
    {
        return GetInstance().Call(Methods.LoadItemDefinitions).AsBool();
    }
    
    public static void RequestEligiblePromoItemDefinitionsIDs(long steamId)
    {
        GetInstance().Call(Methods.RequestEligiblePromoItemDefinitionsIDs, steamId);
    }
    
    public static void RequestPrices()
    {
        GetInstance().Call(Methods.RequestPrices);
    }
    
    public static string SerializeResult(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.SerializeResult, thisInventoryHandle).AsString();
    }
    
    public static void StartPurchase(long[] items, long quantity)
    {
        GetInstance().Call(Methods.StartPurchase, items, quantity);
    }
    
    public static int TransferItemQuantity(ulong itemId, uint quantity, ulong itemDestination, bool split)
    {
        return GetInstance().Call(Methods.TransferItemQuantity, itemId, quantity, itemDestination, split).AsInt32();
    }
    
    public static int TriggerItemDrop(long definition)
    {
        return GetInstance().Call(Methods.TriggerItemDrop, definition).AsInt32();
    }
    
    public static void StartUpdateProperties()
    {
        GetInstance().Call(Methods.StartUpdateProperties);
    }
    
    public static int SubmitUpdateProperties(long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SubmitUpdateProperties, thisInventoryUpdateHandle).AsInt32();
    }
    
    public static bool RemoveProperty(ulong itemId, string name, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.RemoveProperty, itemId, name, thisInventoryUpdateHandle).AsBool();
    }
    
    public static bool SetPropertyString(ulong itemId, string name, string value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyString, itemId, name, value, thisInventoryUpdateHandle).AsBool();
    }
    
    public static bool SetPropertyBool(ulong itemId, string name, bool value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyBool, itemId, name, value, thisInventoryUpdateHandle).AsBool();
    }
    
    public static bool SetPropertyInt(ulong itemId, string name, ulong value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyInt, itemId, name, value, thisInventoryUpdateHandle).AsBool();
    }
    
    public static bool SetPropertyFloat(ulong itemId, string name, float value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyFloat, itemId, name, value, thisInventoryUpdateHandle).AsBool();
    }

    [System.Flags]
    public enum ItemFlags : long
    {
        NoTrade = 1,
        Removed = 256,
        Consumed = 512
    }
}