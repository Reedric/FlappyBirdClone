using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 7;
    public float life = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;
        if (life <= 0) {
            Destroy(this.gameObject);
        }
    }
}
