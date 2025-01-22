using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit"){
        hits++;
        Debug.Log("You've bumped into a thing this many times"+ hits);
        }
   }
}
