using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerBasic : MonoBehaviour
{
    public float vitesse = 5.0f; // Vitesse de déplacement (modifiable dans l'inspecteur)

    void Update()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal");
        float deplacementVertical = Input.GetAxis("Vertical");

        Vector3 deplacement = new Vector3(deplacementHorizontal, deplacementVertical, 0) * vitesse * Time.deltaTime;

        transform.Translate(deplacement);
    }
}
