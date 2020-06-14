using UnityEngine;

public class TriggerHalfWay : MonoBehaviour
{
    private void OnTriggerEnter(Collider objectEntered)
    {
        if (objectEntered.name == "PlayerController")
        {
            Debug.LogError($"object name : {objectEntered.name}");
        }
    }
}