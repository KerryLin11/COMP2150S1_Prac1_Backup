using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class Mole : MonoBehaviour
{
    // Start is called before the first frame update

    public Color missed = Color.red;
    public Color down = Color.black;

    public Color up = Color.yellow;
    private SpriteRenderer sprite;
    private float privateTimer = 10;
    public float timer; //seconds

    private float missedTimer = 2.0f;

    private float returnTimer = 1.0f;

    float rand;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = down;
        privateTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {

        
        rand = Random.Range(1.0f,1000.0f);
        if(rand > 999.5f)
        {
            sprite.color = up;
        }
        if(sprite.color == up)
        {
            missedTimer -= Time.deltaTime;
        }
        if(missedTimer < 0)
        {
            sprite.color = missed;
            missedTimer = 2.0f;
        }
        if(sprite.color == missed)
        {
            returnTimer -= Time.deltaTime;
        }
        if(returnTimer < 0)
        {
            sprite.color = down;
            returnTimer = 1.0f;
        }



        if(missedTimer < 0)
        {
            sprite.color = missed;
            missedTimer = 2;
        }



        privateTimer -= Time.deltaTime;



        if(privateTimer < 0)
        {
            sprite.color = down;
        }
    }

     void OnMouseDown()
    {
        privateTimer = timer;
        sprite.color = down;
        missedTimer = 2;
    }
}
