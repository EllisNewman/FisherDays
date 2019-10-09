using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{

    void Start()
    {
        Invoke("Kill", 5f);
    }

    void Update()
    {

    }

    void Kill()
    {
        Destroy(gameObject);
    }

}
