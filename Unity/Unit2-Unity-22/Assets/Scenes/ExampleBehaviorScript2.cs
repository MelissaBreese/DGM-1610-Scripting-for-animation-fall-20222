using UnityEngine;
using System.Collections;

public class ExampleBehaviorScript2 : MonoBehaviour
{
    void update ()
   {
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer> ().material.color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Renderer> ().material.color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer> ().material.color = Color.yellow;
        }
   }
}