using UnityEngine;

public class RoadConstructionView : MonoBehaviour
{
    public Transform BeginPointPosition => _beginPointPosition;
    public Transform EndPointPosition => _endpointPosition;
    
    [SerializeField] private Transform _beginPointPosition;
    [SerializeField] private Transform _endpointPosition;
    
}
