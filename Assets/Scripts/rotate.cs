using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
   

    void FixedUpdate()
    {
        Quaternion flipCoin = Quaternion.AngleAxis(4, new Vector3(0, 180, 0));

        this.transform.rotation *= flipCoin;
    }
}
