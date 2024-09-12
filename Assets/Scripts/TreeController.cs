using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class TreeController : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    [SerializeField] private GameObject rottenApple;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(AppleInstantiater), 1, 1);
    }

    // Update is called once per frame
    void AppleInstantiater()
    {
        Instantiate(ReturnCollectables(), transform.position, applePrefab.transform.rotation);
    }

    GameObject ReturnCollectables(){
        int random = Random.Range(0, 10);
        return random % 3 == 0 ? rottenApple : applePrefab;
    }

    void OnValidate(){
        Assert.IsNotNull(applePrefab, $"{nameof(applePrefab)} was null in {nameof(TreeController)}");
        Assert.IsNotNull(rottenApple);
    }
}
