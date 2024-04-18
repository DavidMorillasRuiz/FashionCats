using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VoteRandom : MonoBehaviour
{
    [SerializeField] private TMP_Text numberText;
    [SerializeField] private TMP_Text numberText2;
    [SerializeField] private TMP_Text numberText3;
    [SerializeField] bool youTouch1 = true;
    [SerializeField] bool youTouch2 = true; 
    [SerializeField] bool youTouch3 = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GenerateNumber1()
    {
        if (youTouch1)
        {
            int randomNumber = Random.Range(0, 11);
            numberText.text = randomNumber.ToString();
            youTouch1 = false;
        }
        
    }

    public void GenerateNumber2()
    {
        if(youTouch2)
        {
            int randomNumber = Random.Range(0, 11);
            numberText2.text = randomNumber.ToString();
            youTouch2 = false;
        }
        
    }

    public void GenerateNumber3()
    {
        if(youTouch3)
        {
            int randomNumber = Random.Range(0, 11);
            numberText3.text = randomNumber.ToString();
            youTouch3 = false;
        }
        
    }
}
