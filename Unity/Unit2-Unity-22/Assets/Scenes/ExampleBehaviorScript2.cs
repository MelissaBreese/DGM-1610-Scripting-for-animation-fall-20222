using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviorScript2 : MonoBehaviour
{
   void update ()
   {
        if Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer> ().material.color = Color.purple;
        }
        if Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Renderer> ().material.color = Color.orange;
        }
        if Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer> ().material.color = Color.yellow;
        }
   }
}
