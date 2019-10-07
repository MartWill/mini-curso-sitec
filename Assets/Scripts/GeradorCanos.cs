using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorCanos : MonoBehaviour
{

    public float maxTime = 1;

    private float timer = 0;

    public GameObject canos;

    public float heigth;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newCano = Instantiate(canos);
        newCano.transform.position = transform.position + new Vector3(0, Random.Range(-heigth, heigth), 0);
        Destroy(newCano, 15);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newCano = Instantiate(canos);
            newCano.transform.position = transform.position + new Vector3(0, Random.Range(-heigth, heigth), 0);
            Destroy(newCano, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
