using System;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string doorID;

    private void OnEnable()
    {
        DoorEventChannel.OnDoorOpen += OpenDoor;
    }

    private void OnDisable()
    {
        DoorEventChannel.OnDoorOpen -= OpenDoor;
    }

    private void OpenDoor(string triggeredID)
    {
        if (triggeredID == doorID)
        {
            Destroy(gameObject); 
        }
    }
}