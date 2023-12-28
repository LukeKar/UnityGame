using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtEachOther : MonoBehaviour
{
    public GameObject Character1;
    public bool flip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = transform.localScale;
        if(Character1.transform.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * -1 *(flip ? -1 : 1);
        } else {
            scale.x = Mathf.Abs(scale.x) * (flip ? -1 : 1);;
        }


        transform.localScale = scale;
    }
}
