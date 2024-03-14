using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Viv_ControlAnim : MonoBehaviour
{
    //float to keep track of mouse position, it is serialized just for visualization purposes in unity
    public float x;
    public DistanceDetection distance;
    public float scaledValue;
    [SerializeField] Animator left_n_right;
   
    // Update is called once per frame
    void Update()
    {
        
         
        // gets the x axis distance from the distance calculation script
        x = (distance.DistanceX);

        // Scaling calculations
        if (x < -0.2)   //For going reverse speed
        {
            scaledValue = (0-(Mathf.Abs(x) - 0.1f) / (1.1f - 0.1f));
        }
        else if (x > 0.2)   //For going normal speed
        {
            scaledValue = (x - 0.1f) / (1.4f - 0.1f);
            
        }
        else
        {
            //To have a bigger range of positions where nothing moves - anything between -0.2 and 0.2 sets the speed to 0. 
        }
        {
            scaledValue = 0;
        }

        //Stops the speed from going below -1 or above 1
        scaledValue = Mathf.Clamp(scaledValue, -1, 1);

        //Actually changes the speed float in the animator
        left_n_right.SetFloat("SpeedControl", scaledValue);
    }
}
