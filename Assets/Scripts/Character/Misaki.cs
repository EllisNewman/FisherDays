using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misaki : MonoBehaviour
{
    public GameObject fishString1;
    public GameObject fishString2;
    
    private Animator charaAnimator;
    
    void Start()
    {
        charaAnimator = GetComponent<Animator>();
        fishString1 = GameObject.Find("string");
        fishString2 = GameObject.Find("string_with_bait");
        fishString1.SetActive(false);
        fishString2.SetActive(false);
    }
    
    void Update()
    {

    }

    public void SetCurrentSpriteByIndex(int index)
    {
        if(index == 2)
        {
            fishString1.SetActive(true);
        }
        else
        {
            fishString1.SetActive(false);
        }
        if (index == 3)
        {
            fishString2.SetActive(true);
        }
        else
        {
            fishString2.SetActive(false);
        }
    }
}
