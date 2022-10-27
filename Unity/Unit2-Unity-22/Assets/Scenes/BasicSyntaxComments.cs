using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntaxComments : MonoBehaviour
{
    void start()
    {
         // I am learning about how to do the comments part of the syntax

         /* Hello, this is an experiement!
         * This is two lines!
         **/
        Debug.Log(transform.position.y);

        if (transform.position.y  <=5f)
         {
              Debug.Log("I'm flying!");
         }
    }
}