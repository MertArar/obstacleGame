using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrorer : MonoBehaviour
{
    int hits = 0;
    
    private void OnCollisionEnter(Collision other) 
    {
        hits++;
        Debug.Log("You've bumped into a thing this many times: " + hits);   
    }
}