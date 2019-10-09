using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misaki : MonoBehaviour
{
    public bool isCountDown = false;
    public GameObject itemPrefab;

    private Animator charaAnimator;
    private float countDownTimer;
    private GameObject fishString1;
    private GameObject fishString2;


    void Start()
    {
        charaAnimator = GetComponent<Animator>();
        fishString1 = GameObject.Find("string");
        fishString2 = GameObject.Find("string_with_bait");
        fishString1.SetActive(false);
        fishString2.SetActive(false);

        countDownTimer = Random.Range(5f, 20f);
    }
    
    void Update()
    {
        if (isCountDown)
        {
            transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            if (countDownTimer > float.Epsilon)
            {
                countDownTimer = countDownTimer - Time.deltaTime;
            }
            else
            {
                transform.position = new Vector3(-1.47f, -0.69f, 0);
                countDownTimer = Random.Range(5f, 20f);
                charaAnimator.SetTrigger("itemGacha");
            }
        }
    }

    public void SpawnItem()
    {
        GameObject item = Instantiate(itemPrefab);
        Sprite itemSprite;
        itemSprite = Resources.Load<Sprite>("Pictures/Item/" + Random.Range(1,24));
        item.GetComponentInChildren<SpriteRenderer>().sprite = itemSprite;
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
