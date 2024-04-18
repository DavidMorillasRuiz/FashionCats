using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArrayClothX : MonoBehaviour
{
    [SerializeField] Sprite[] _sprite;
    public int spritePosition;
    [SerializeField] private TMP_Text numberText;
    [SerializeField] private TMP_Text numberText2;
    [SerializeField] private TMP_Text numberText3;


    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (spritePosition <= _sprite.Length - 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = _sprite[spritePosition];
        }
        else if (spritePosition > _sprite.Length)
        {
            spritePosition = 0;
        }
    }

    public void ButtomCharacter()
    {
        spritePosition++;
    }

    public void GenerateNumber()
    {
        int randomNumber = Random.Range(0, 10);
        numberText.text = randomNumber.ToString();
    }

    public void GenerateNumber2()
    {
        int randomNumber = Random.Range(0, 10);
        numberText2.text = randomNumber.ToString();
    }

    public void GenerateNumber3()
    {
        int randomNumber = Random.Range(0, 10);
        numberText3.text = randomNumber.ToString();
    }
}
