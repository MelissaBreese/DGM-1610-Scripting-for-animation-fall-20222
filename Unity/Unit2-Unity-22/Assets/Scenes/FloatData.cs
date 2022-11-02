using UnityEngine;

[CreateAssetMenuAttribute]
public class floatData : ScriptableObject
{
   public float value;

   public void UpdateValue(float num)
   {
      value += num;
   }
}