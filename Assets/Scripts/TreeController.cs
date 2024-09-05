using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(AppleInstantiater), 1, 1);
    }

    // Update is called once per frame
    void AppleInstantiater()
    {
        Instantiate(applePrefab, transform.position, applePrefab.transform.rotation);
    }
}
