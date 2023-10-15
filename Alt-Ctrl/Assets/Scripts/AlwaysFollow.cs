using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysFollow : MonoBehaviour
{
    public float vitesse = 5.0f;

    void Update()
    {
        transform.Translate(Vector2.up * vitesse * Time.deltaTime); 
    }


}
