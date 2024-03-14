using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDetection : MonoBehaviour
{
    public float Distance;
    public Transform A;
    public Transform B;

    public float DistanceX;
    public float DistanceY;
    public float DistanceZ;




    // Start is called before the first frame update

    void Start () {

      
   
    }



    // Update is called once per frame
    void Update()
    {
        Vector3 positionA = A.position;
        Vector3 positionB = B.position;

        Distance = Vector3.Distance(positionA,positionB);

        DistanceX = positionA.x - positionB.x;
        DistanceY = positionA.y - positionB.y;
        DistanceZ = positionA.z - positionB.z;



    }
}
