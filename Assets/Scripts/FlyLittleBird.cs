using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBird : MonoBehaviour
{
    public GameManagerOne gameManagerOne;

    public float velocidade = 1;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rb.velocity = Vector2.up * velocidade;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        gameManagerOne.GameOver();
    }
}
