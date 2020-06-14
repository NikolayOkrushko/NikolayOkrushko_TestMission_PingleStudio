using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float _distanceOfHeightToPursued = 20.0f;
    [SerializeField] private float _distanceBehindToPursued = 20.0f;

   private void LateUpdate()
    {
        Vector3 pos = player.transform.position;
        pos.y += _distanceOfHeightToPursued;
        pos.z -= _distanceBehindToPursued;
        transform.position = pos;
    }
}