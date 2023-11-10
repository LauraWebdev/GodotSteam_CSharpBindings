using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void InventoryDefinitionUpdateEventHandler(Godot.Collections.Array definitions);
    private static event InventoryDefinitionUpdateEventHandler InventoryDefinitionUpdateEvent;
    static Action<Godot.Collections.Array> _inventoryDefinitionUpdateAction = (definitions) =>
    {
        InventoryDefinitionUpdateEvent?.Invoke(definitions);
    };
    public static event InventoryDefinitionUpdateEventHandler InventoryDefinitionUpdate
    {
        add
        {
            if(InventoryDefinitionUpdateEvent == null)
            {
                GetInstance().Connect(Signals.InventoryDefinitionUpdate, Callable.From(_inventoryDefinitionUpdateAction));
            }
            InventoryDefinitionUpdateEvent += value;
        }
        remove
        {
            InventoryDefinitionUpdateEvent -= value;
            if(InventoryDefinitionUpdateEvent == null)
            {
                GetInstance().Disconnect(Signals.InventoryDefinitionUpdate, Callable.From(_inventoryDefinitionUpdateAction));
            }
        }
    }
    
    public delegate void InventoryEligiblePromoItemEventHandler(long result, bool cached, Godot.Collections.Array definitions);
    private static event InventoryEligiblePromoItemEventHandler InventoryEligiblePromoItemEvent;
    static Action<long, bool, Godot.Collections.Array> _inventoryEligiblePromoItemAction = (result, cached, definitions) =>
    {
        InventoryEligiblePromoItemEvent?.Invoke(result, cached, definitions);
    };
    public static event InventoryEligiblePromoItemEventHandler InventoryEligiblePromoItem
    {
        add
        {
            if(InventoryEligiblePromoItemEvent == null)
            {
                GetInstance().Connect(Signals.InventoryEligiblePromoItem, Callable.From(_inventoryEligiblePromoItemAction));
            }
            InventoryEligiblePromoItemEvent += value;
        }
        remove
        {
            InventoryEligiblePromoItemEvent -= value;
            if(InventoryEligiblePromoItemEvent == null)
            {
                GetInstance().Disconnect(Signals.InventoryEligiblePromoItem, Callable.From(_inventoryEligiblePromoItemAction));
            }
        }
    }
    
    public delegate void InventoryFullUpdateEventHandler(long inventoryHandle);
    private static event InventoryFullUpdateEventHandler InventoryFullUpdateEvent;
    static Action<long> _inventoryFullUpdateAction = (inventoryHandle) =>
    {
        InventoryFullUpdateEvent?.Invoke(inventoryHandle);
    };
    public static event InventoryFullUpdateEventHandler InventoryFullUpdate
    {
        add
        {
            if(InventoryFullUpdateEvent == null)
            {
                GetInstance().Connect(Signals.InventoryFullUpdate, Callable.From(_inventoryFullUpdateAction));
            }
            InventoryFullUpdateEvent += value;
        }
        remove
        {
            InventoryFullUpdateEvent -= value;
            if(InventoryFullUpdateEvent == null)
            {
                GetInstance().Disconnect(Signals.InventoryFullUpdate, Callable.From(_inventoryFullUpdateAction));
            }
        }
    }
    
    public delegate void InventoryResultReadyEventHandler(long result, long inventoryHandle);
    private static event InventoryResultReadyEventHandler InventoryResultReadyEvent;
    static Action<long, long> _inventoryResultReadyAction = (result, inventoryHandle) =>
    {
        InventoryResultReadyEvent?.Invoke(result, inventoryHandle);
    };
    public static event InventoryResultReadyEventHandler InventoryResultReady
    {
        add
        {
            if(InventoryResultReadyEvent == null)
            {
                GetInstance().Connect(Signals.InventoryResultReady, Callable.From(_inventoryResultReadyAction));
            }
            InventoryResultReadyEvent += value;
        }
        remove
        {
            InventoryResultReadyEvent -= value;
            if(InventoryResultReadyEvent == null)
            {
                GetInstance().Disconnect(Signals.InventoryResultReady, Callable.From(_inventoryResultReadyAction));
            }
        }
    }
    
    public delegate void InventoryStartPurchaseResultEventHandler(string result, long orderId, long transactionId);
    private static event InventoryStartPurchaseResultEventHandler InventoryStartPurchaseResultEvent;
    static Action<string, long, long> _inventoryStartPurchaseResultAction = (result, orderId, transactionId) =>
    {
        InventoryStartPurchaseResultEvent?.Invoke(result, orderId, transactionId);
    };
    public static event InventoryStartPurchaseResultEventHandler InventoryStartPurchaseResult
    {
        add
        {
            if(InventoryStartPurchaseResultEvent == null)
            {
                GetInstance().Connect(Signals.InventoryStartPurchaseResult, Callable.From(_inventoryStartPurchaseResultAction));
            }
            InventoryStartPurchaseResultEvent += value;
        }
        remove
        {
            InventoryStartPurchaseResultEvent -= value;
            if(InventoryStartPurchaseResultEvent == null)
            {
                GetInstance().Disconnect(Signals.InventoryStartPurchaseResult, Callable.From(_inventoryStartPurchaseResultAction));
            }
        }
    }
    
    public delegate void InventoryRequestPricesResultEventHandler(long result, string currency);
    private static event InventoryRequestPricesResultEventHandler InventoryRequestPricesResultEvent;
    static Action<long, string> _inventoryRequestPricesResultAction = (result, currency) =>
    {
        InventoryRequestPricesResultEvent?.Invoke(result, currency);
    };
    public static event InventoryRequestPricesResultEventHandler InventoryRequestPricesResult
    {
        add
        {
            if(InventoryRequestPricesResultEvent == null)
            {
                GetInstance().Connect(Signals.InventoryRequestPricesResult, Callable.From(_inventoryRequestPricesResultAction));
            }
            InventoryRequestPricesResultEvent += value;
        }
        remove
        {
            InventoryRequestPricesResultEvent -= value;
            if(InventoryRequestPricesResultEvent == null)
            {
                GetInstance().Disconnect(Signals.InventoryRequestPricesResult, Callable.From(_inventoryRequestPricesResultAction));
            }
        }
    }
}