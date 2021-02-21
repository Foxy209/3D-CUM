using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lolicon : MonoBehaviour
{
    public Animator anime;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anime.SetTrigger("1122");
        }
    }
}
