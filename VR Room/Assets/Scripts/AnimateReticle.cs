using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateReticle : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3((Mathf.Sin(Time.time*1.5f) + 3)/3, (Mathf.Sin(Time.time*1.5f) + 3) / 3, (Mathf.Sin(Time.time*1.5f) + 3)/ 3);
        transform.localScale = vec;
    }
}
