using System;
using System.Diagnostics.Tracing;
using UnityEngine;
using System;

public class PlatformButton : MonoBehaviour
{
    public string doorID; // ID da porta que será aberta

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DoorEventChannel.RaiseDoorOpenEvent(doorID);
        }
    }
}