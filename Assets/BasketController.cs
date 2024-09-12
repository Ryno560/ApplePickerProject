using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.TryGetComponent<ICollectables>(out ICollectables collectables))
        {
            if(collectables.isCollectable())
                Destroy(collision.gameObject);
            else 
            {
                print("You Lose");
                
            }
        }
    }
}
