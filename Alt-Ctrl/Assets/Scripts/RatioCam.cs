using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatioCam : MonoBehaviour
{
    private Camera mainCamera;
    public float cibleRatio = 16f / 9f; // Rapport d'aspect cible (par exemple, 16:9)

    void Start()
    {
        mainCamera = Camera.main;
        AjusterTaille();
    }

    void AjusterTaille()
    {
        float rapportActuel = (float)Screen.width / Screen.height;
        float nouvelleTaille = mainCamera.orthographicSize * (cibleRatio / rapportActuel);
        mainCamera.orthographicSize = nouvelleTaille;
    }
}
