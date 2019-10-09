using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleManager : MonoBehaviour
{
    public GameObject[] idolList;
    public GameObject gadgetPrefab;

    private List<GameObject> idolAnim;
    private float countDownTimer;

    // Start is called before the first frame update
    void Start()
    {
        idolAnim = new List<GameObject>();
        RandomBackground();
        RandomIdolAnimation();
        countDownTimer = Random.Range(10f, 60f);
    }
    
    void Update()
    {
        if(countDownTimer > float.Epsilon)
        {
            countDownTimer = countDownTimer - Time.deltaTime;
        }
        else
        {
            countDownTimer = Random.Range(10f, 60f);
            PickGadgetAnimate();
        }
    }

    void RandomBackground()
    {
        GameObject background = GameObject.Find("Background");
        Sprite bgSprite = Resources.Load<Sprite>("Pictures/Background/" + Random.Range(1, 8));
        background.GetComponent<SpriteRenderer>().sprite = bgSprite;
    }

    void RandomIdolAnimation()
    {
        foreach (var idol in idolList)
        {
            int coin = Random.Range(1, 3);
            if (coin > 1)
            {
                idol.gameObject.SetActive(false);
            }
            else
            {
                Animator animator = idol.GetComponentInChildren<Animator>();
                animator.Play("Idol", 0, Random.Range(0f, 1f));
                idolAnim.Add(idol.gameObject);
            }
        }
    }

    void PickGadgetAnimate()
    {
        GameObject chara = idolAnim[Random.Range(0, idolAnim.Count)];
        GameObject gadget = Instantiate(gadgetPrefab, chara.transform.position, new Quaternion(0, 0, 0, 0));
        gadget.transform.SetParent(chara.transform);
        gadget.GetComponentInChildren<Animator>().Play("Gadget" + Random.Range(1,4));
        StartCoroutine(KillGadget(gadget));
    }

    IEnumerator KillGadget(GameObject go)
    {
        yield return new WaitForSeconds(3f);
        Destroy(go);
    }

}
