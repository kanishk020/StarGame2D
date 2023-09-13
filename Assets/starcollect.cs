using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starcollect : MonoBehaviour
{
  public AudioSource collectSound;


  void OnTriggerEnter(Collider other)
  {
    collectSound.Play();
    Collect.theScore += 1;
    Destroy (gameObject);

  }
}
