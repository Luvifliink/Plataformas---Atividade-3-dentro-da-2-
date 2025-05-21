using UnityEngine;

using System;

public static class DoorEventChannel
{
    public static Action<string> OnDoorOpen;

    public static void RaiseDoorOpenEvent(string doorID)
    {
        OnDoorOpen?.Invoke(doorID);
    }
}