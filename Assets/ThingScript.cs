using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThingScript : MonoBehaviour
{
    public TMP_Text foodCountText;
    public TMP_Text feelingsText;

    public float foodCount;
    public int myfood;
    public bool alive = true;

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        foodCount = 20.0f;
        SetfoodCountText();
    }

    // Update is called once per frame
    void Update()
    {
        if(alive)
        {
            if(Input.GetKeyUp(KeyCode.E))
            {
                foodCount++;
            }
            foodCount -= 0.01f;
            SetfoodCountText();
            myfood = Mathf.RoundToInt(foodCount);
            anim.SetInteger("Food", myfood);
        }
        
    }

    void SetfoodCountText()
    {
        foodCountText.text = "Food: " + myfood.ToString();

        if(alive) // boolean value declared at start of script
        {
            if(myfood < 10 && myfood > 0)
            {
                feelingsText.text = "GIMME FOOD!";
            }
            else if (myfood >= 10 && myfood < 40)
            {
                feelingsText.text = "LA LA LA";
            }
            else if(myfood > 40 || myfood < 0)
            {
                feelingsText.text = "x_x";
                alive = false;
            }
        }
    }
}
