using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]                   //Tells Unity to place a header line of "Inscribed" above the following feild in the inspector, which described feilds of this script that won't change while running.
    //Prefab for instantiationg apples
    public GameObject applePrefab;                          //ASSIGN REFERENCE IN EDITOR

    //Speed at which the AppleTree moves:
    public float speed = 1f;                                //Overriden

    //Distance that the AppleTree turns around:
    public float leftAndRightEdge = 10f;                    //Overriden

    //Distance that the AppleTree will change directions:
    public float changeDirChance = 0.1f;                    //Overriden

    //Seconds between Apples instantiations:
    public float appleDropDelay = 1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Start dropping apples:
        Invoke("DropApple", 2f);
    }

    //Create an Apple object instance:
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);    //Adds an object based on the apple prefab.
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    //Update is called as fast as the computer can:
    void Update()
    {
        //Basic movement:
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Changing direction:
        if (pos.x < -leftAndRightEdge){     //If x position passes this point on the left,
            speed = Mathf.Abs(speed);           //Start moving right.
        }
        else if (pos.x > leftAndRightEdge){ //If x position passes too far right,
            speed = -Mathf.Abs(speed);          //Start moving left.
        }
    }

    //Called every game frame:
    void FixedUpdate(){ 
        //Random direction change:
        if (Random.value < changeDirChance)
        {
            speed *= -1;
        }
    }

}
