using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tml_Script : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject parentObject;
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        gameManager.transform.parent = parentObject.transform;
        transform.position = new Vector3 (transform.position.x, -2.79f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
