using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] _obstaclesArray;
    private int _obstacleElement;

    public List<GameObject> _activeObstacles = new List<GameObject>();
    private int _maxActiveObstacles = 1;

    private float _minYPos = -1.1f;
    private float _maxYPos = 1.1f;
    private float _spawnPosY;

    private Vector2 _spawnPos;


    private void FixedUpdate()
    {
        if (_activeObstacles.Count < _maxActiveObstacles)
        {
            CreateObstacle();
        }
        RemoveObstacle();
    }

    private void CreateObstacle()
    {
        SetPosition();
        _obstaclesArray[_obstacleElement].SetActive(true);
        _activeObstacles.Add(_obstaclesArray[_obstacleElement]);



    }

    private void SetPosition()
    {
        _obstacleElement = Random.Range(0, _obstaclesArray.Length);

        _spawnPosY = Random.Range(_minYPos, _maxYPos);

        _spawnPos = new Vector2(5, _spawnPosY);

        _obstaclesArray[_obstacleElement].transform.position = _spawnPos;


    }

    private void RemoveObstacle()
    {
        if (_activeObstacles[0].transform.position.x < -5f)
        {
            _activeObstacles[0].SetActive(false);
            _activeObstacles.RemoveAt(0);

        }
    }
}
