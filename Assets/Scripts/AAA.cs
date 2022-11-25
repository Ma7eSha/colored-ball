using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAA : MonoBehaviour
{

    private Renderer mr;

    public float R;
    public float G;
    public float B;

    void Start ()
    {
        mr = GetComponent<MeshRenderer>();

        StartCoroutine("rgbChange");
    }

   

    IEnumerator rgbChange()
    {
        while (true)
        {
            R = Random.Range(0f, 1f);
            G = Random.Range(0f, 1f);
            B = Random.Range(0f, 1f);

            mr.material.color = new Color(R, G, B, 1);

            yield return new WaitForSeconds(0.1f);
        }
    }
}
