namespace GodotSteam;

public static partial class Steam
{
    public static int AddPromoItem(long item)
    {
        return GetInstance().Call(Methods.AddPromoItem, item).As<int>();
    }
    
    public static int AddPromoItems(long[] items)
    {
        return GetInstance().Call(Methods.AddPromoItems, items).As<int>();
    }
    
    public static bool CheckResultSteamID(ulong steamIdExpected, long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.CheckResultSteamID, steamIdExpected, thisInventoryHandle).As<bool>();
    }
    
    public static int ConsumeItem(ulong itemConsume, long quantity)
    {
        return GetInstance().Call(Methods.ConsumeItem, itemConsume, quantity).As<int>();
    }
    
    public static int DeserializeResult(byte[] buffer)
    {
        return GetInstance().Call(Methods.DeserializeResult, buffer).As<int>();
    }
    
    public static void DestroyResult(long thisInventoryHandle = 0)
    {
        GetInstance().Call(Methods.DestroyResult, thisInventoryHandle);
    }
    
    public static int ExchangeItems(long[] outputItems, uint outputQuantity, ulong inputItems, long inputQuantity)
    {
        return GetInstance().Call(Methods.ExchangeItems, outputItems, outputQuantity, inputItems, inputQuantity).As<int>();
    }
    
    public static int GenerateItems(long[] items, long quantity)
    {
        return GetInstance().Call(Methods.GenerateItems, items, quantity).As<int>();
    }
    
    public static long GetAllItems()
    {
        return GetInstance().Call(Methods.GetAllItems).AsInt64();
    }
    
    public static string GetItemDefinitionProperty(uint definition, string name)
    {
        return GetInstance().Call(Methods.GetItemDefinitionProperty, definition, name).As<string>();
    }
    
    public static int GetItemsByID(ulong idArray, long count)
    {
        return GetInstance().Call(Methods.GetItemsByID, idArray, count).As<int>();
    }
    
    public static ulong GetItemPrice(long definition)
    {
        return GetInstance().Call(Methods.GetItemPrice, definition).As<ulong>();
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
        return GetInstance().Call(Methods.GetResultItemProperty, index, name, thisInventoryHandle).As<string>();
    }
    
    public static Godot.Collections.Array GetResultItems(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultItems, thisInventoryHandle).AsGodotArray();
    }
    
    public static string GetResultStatus(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultStatus, thisInventoryHandle).As<string>();
    }
    
    public static uint GetResultTimestamp(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.GetResultTimestamp, thisInventoryHandle).As<uint>();
    }
    
    public static long GrantPromoItems()
    {
        return GetInstance().Call(Methods.GrantPromoItems).AsInt64();
    }
    
    public static bool LoadItemDefinitions()
    {
        return GetInstance().Call(Methods.LoadItemDefinitions).As<bool>();
    }
    
    public static void RequestEligiblePromoItemDefinitionsIDs(ulong steamId)
    {
        GetInstance().Call(Methods.RequestEligiblePromoItemDefinitionsIDs, steamId);
    }
    
    public static void RequestPrices()
    {
        GetInstance().Call(Methods.RequestPrices);
    }
    
    public static string SerializeResult(long thisInventoryHandle = 0)
    {
        return GetInstance().Call(Methods.SerializeResult, thisInventoryHandle).As<string>();
    }
    
    public static void StartPurchase(long[] items, long quantity)
    {
        GetInstance().Call(Methods.StartPurchase, items, quantity);
    }
    
    public static int TransferItemQuantity(ulong itemId, uint quantity, ulong itemDestination, bool split)
    {
        return GetInstance().Call(Methods.TransferItemQuantity, itemId, quantity, itemDestination, split).As<int>();
    }
    
    public static int TriggerItemDrop(long definition)
    {
        return GetInstance().Call(Methods.TriggerItemDrop, definition).As<int>();
    }
    
    public static void StartUpdateProperties()
    {
        GetInstance().Call(Methods.StartUpdateProperties);
    }
    
    public static int SubmitUpdateProperties(long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SubmitUpdateProperties, thisInventoryUpdateHandle).As<int>();
    }
    
    public static bool RemoveProperty(ulong itemId, string name, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.RemoveProperty, itemId, name, thisInventoryUpdateHandle).As<bool>();
    }
    
    public static bool SetPropertyString(ulong itemId, string name, string value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyString, itemId, name, value, thisInventoryUpdateHandle).As<bool>();
    }
    
    public static bool SetPropertyBool(ulong itemId, string name, bool value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyBool, itemId, name, value, thisInventoryUpdateHandle).As<bool>();
    }
    
    public static bool SetPropertyInt(ulong itemId, string name, ulong value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyInt, itemId, name, value, thisInventoryUpdateHandle).As<bool>();
    }
    
    public static bool SetPropertyFloat(ulong itemId, string name, float value, long thisInventoryUpdateHandle = 0)
    {
        return GetInstance().Call(Methods.SetPropertyFloat, itemId, name, value, thisInventoryUpdateHandle).As<bool>();
    }

    [System.Flags]
    public enum ItemFlags : long
    {
        NoTrade = 1,
        Removed = 256,
        Consumed = 512
    }
}