using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]

    public GameObject applePrefab;

    public GameObject rottenApplePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float changeDirChance = 0.1f;

    public float appleDropDelay = 1f;
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple(){
        GameObject apple = Instantiate<GameObject>(ReturnCollectables());
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -leftAndRightEdge){
            speed = Mathf.Abs(speed);
        } else if (pos.x > leftAndRightEdge) {
            speed = -Mathf.Abs(speed);
        //} else if (UnityEngine.Random.value < changeDirChance) {
        //    speed *= -1;
        //}
    }

    void FixedUpdate(){
        } if (UnityEngine.Random.value < changeDirChance) {
            speed *= -1;
        }
    }

    GameObject ReturnCollectables(){
        int random = Random.Range(0, 10);
        return random % 3 == 0 ? rottenApplePrefab : applePrefab;
    }
}
