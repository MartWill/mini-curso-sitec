using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBird : MonoBehaviour
{
    public gameManager gameManager;
    public float forca = 0;
    private Rigidbody2D rg;


    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rg.velocity = Vector2.up * forca;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        gameManager.GameOver();
    }

}
