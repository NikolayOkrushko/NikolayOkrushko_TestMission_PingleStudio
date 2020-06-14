using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Test : MonoBehaviour
{
    [SerializeField] private List<RoadConstructionView> _roadConstructionsPrefabs = new List<RoadConstructionView>(); // список, который хранит в себе набор префабов из которыъ можно строить уровень
    [SerializeField] private List<RoadConstructionView> _createdRoadConstructions = new List<RoadConstructionView>(); // список, который хранит в себе набор уже созданных конструкций
    [SerializeField] private RoadConstructionView  _lastBuiltConstraction; // последняя дорога, которая была построена


    private const int _maxRoadConstructionInList = 5;

    private void Start()
    {
        StartBuildLevel();
    }

    private void StartBuildLevel()
    {
        _lastBuiltConstraction = Instantiate(_roadConstructionsPrefabs[Random.Range(0, _roadConstructionsPrefabs.Count)]);
        _createdRoadConstructions.Add(_lastBuiltConstraction);

        GenerateANewPath();
    }

    private void GenerateANewPath()
    {
        RoadConstructionView newBuiltRoadConstruction = Instantiate(_roadConstructionsPrefabs[Random.Range(0, _roadConstructionsPrefabs.Count)]);
        newBuiltRoadConstruction.transform.position = _lastBuiltConstraction.EndPointPosition.position;
        _createdRoadConstructions.Add(newBuiltRoadConstruction);
        _lastBuiltConstraction = newBuiltRoadConstruction;
        
        if (_createdRoadConstructions.Count >= _maxRoadConstructionInList)
        {
            RemoveRoadConstructionFromList();
        }
    }

    private void RemoveRoadConstructionFromList()
    {
        var indexOfDeletedRoadConstruction = Random.Range(0, _createdRoadConstructions.Count - 3);
        Destroy(_createdRoadConstructions[indexOfDeletedRoadConstruction].gameObject);
        _createdRoadConstructions.RemoveAt(indexOfDeletedRoadConstruction);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateANewPath();
        }
    }
}