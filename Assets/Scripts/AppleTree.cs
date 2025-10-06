using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]                   //Tells Unity to place a header line of "Inscribed" above the following feild in the inspector, which described feilds of this script that won't change while running.
    //Prefab for instantiationg apples
    public GameObject applePrefab;

    //Speed at which the AppleTree moves:
    public float speed = 1f;

    //Distance that the AppleTree turns around:
    public float leftAndRightEdge = 10f;

    //Distance that the AppleTree will change directions:
    public float changeDirChance = 0.1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
