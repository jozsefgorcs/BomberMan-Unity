using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject borderPrefab;
    [SerializeField]
    private GameObject obstaclePrefab;
    [SerializeField]
    private int widthBlockNumber;
    [SerializeField]
    private int heightBlockNumber;
    [SerializeField]
    private GameObject borderContainer;

    private float borderWidth; 
    void Start()
    {
        borderWidth = borderPrefab.GetComponent<RectTransform>().rect.width;
        GenerateBorder();
        GenerateObstacles();
    }

    private void GenerateObstacles()
    {
        for (int x = 0; x < widthBlockNumber; x++)
        {
            for (int y = 0; y < heightBlockNumber; y++)
            {
                if (x == 0 || x == widthBlockNumber - 1 || y == 0 || y == heightBlockNumber - 1)
                {
                    continue;
                }

                if (x % 2 == 0 && y % 2 == 0) {
                    var go = Instantiate(obstaclePrefab, borderContainer.transform);
                    go.transform.position = new Vector2(x * borderWidth, y * borderWidth);
                }
            }
        }
    }

    private void GenerateBorder()
    {
        
        for (int x = 0; x < widthBlockNumber; x++)
        {
            for (int y = 0; y < heightBlockNumber; y++)
            {
                if (x == 0 || x == widthBlockNumber - 1 || y == 0 || y == heightBlockNumber - 1) {
                    var go = Instantiate(borderPrefab, borderContainer.transform);
                    go.transform.position = new Vector2(x* borderWidth, y* borderWidth);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
