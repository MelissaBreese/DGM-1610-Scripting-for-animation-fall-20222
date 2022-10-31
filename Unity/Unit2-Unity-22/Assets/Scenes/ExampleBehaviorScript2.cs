using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviorScript2 : MonoBehaviour
{
   public void update ()
   {
        if (Input.GetButtonDown(KeyCode.P))
        {
            GetComponent<Renderer> ().material.color = Color.Purple;
        }
        if (Input.GetButtonDown(KeyCode.O))
        {
            GetComponent<Renderer> ().material.color = Color.Orange;
        }
        if (Input.GetButtonDown(KeyCode.Y))
        {
            GetComponent<Renderer> ().material.color = Color.Yellow;
        }
   }
}