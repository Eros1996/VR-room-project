using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class GetLocalTimeZone : MonoBehaviour
{
    [SerializeField] private GameObject hour;
    [SerializeField] private GameObject minute;
    [SerializeField] private GameObject second;

    private DateTime localDate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        localDate = DateTime.Now;
        //Debug.Log(localDate.Hour + ":" + localDate.Minute + ":" + localDate.Second);
        second.transform.localRotation = Quaternion.Euler(localDate.Second*6f, 0f, 0f);
        minute.transform.localRotation = Quaternion.Euler(localDate.Minute * 6f, 0f, 0f);
        hour.transform.localRotation = Quaternion.Euler(localDate.Hour * 30f, 0f, 0f);

    }
}
