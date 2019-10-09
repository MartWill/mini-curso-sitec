using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorCanos : MonoBehaviour
{
    public GameObject canos;
    public float maxTime;
    private float timer;
    public float weigth;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newCanos = Instantiate(canos);
            newCanos.transform.position = transform.position + new Vector3(0, Random.Range(weigth, -weigth), 0);
            Destroy(newCanos, 5);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
