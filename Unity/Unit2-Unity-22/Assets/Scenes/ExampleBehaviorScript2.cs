using UnityEngine;
using System.Collections;

public class ExampleBehaviorScript2 : MonoBehaviour
{
    void update ()
   {
        if (Input.GetKeyDown(UnityEngine.KeyCode.P))
        {
            GetComponent<Renderer> ().material.color = Color.Purple;
        }
        if (Input.GetKeyDown(UnityEngine.KeyCode.O))
        {
            GetComponent<Renderer> ().material.color = Color.Orange;
        }
        if (Input.GetKeyDown(UnityEngine.KeyCode.Y))
        {
            GetComponent<Renderer> ().material.color = Color.Yellow;
        }
   }
}