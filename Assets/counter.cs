using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    public int Counter = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Counter += 1;
        Debug.Log("collision");
    }



}
