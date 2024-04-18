using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArrayClothes : MonoBehaviour
{
    [SerializeField] Sprite[] _sprite;
    public int spritePosition;


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
        else if(spritePosition == _sprite.Length)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = null;
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


}
