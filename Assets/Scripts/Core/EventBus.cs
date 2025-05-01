using System;
using System.Collections.Generic;

public static class EventBus
{
    private static Dictionary<EventType, Action> eventTable = new();

    public static void Subscribe(EventType type, Action callback)
    {
        if (!eventTable.ContainsKey(type))
            eventTable[type] = callback;
        else
            eventTable[type] += callback;
    }

    public static void Unsubscribe(EventType type, Action callback)
    {
        if (eventTable.ContainsKey(type))
            eventTable[type] -= callback;
    }
    public static void ClearEvents() => 
        eventTable.Clear();

    public static void RaiseEvent(EventType type)
    {
        if (eventTable.ContainsKey(type))
            eventTable[type]?.Invoke();
    }
}
