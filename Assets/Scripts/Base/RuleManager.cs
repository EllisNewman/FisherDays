using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleManager : MonoBehaviour
{
    public GameObject[] idolList;

    // Start is called before the first frame update
    void Start()
    {
        RandomBackground();
        RandomIdolAnimation();
    }
    

    void RandomBackground()
    {
        GameObject background = GameObject.Find("Background");
        Sprite bgSprite = Resources.Load<Sprite>("Pictures/Background/" + Random.Range(1, 8));
        background.GetComponent<SpriteRenderer>().sprite = bgSprite;
    }

    void RandomIdolAnimation()
    {
        foreach(var idol in idolList)
        {
            Animator animator = idol.GetComponentInChildren<Animator>();
            animator.Play("Idol", 0, Random.Range(0f, 1f));
        }
    }
}
