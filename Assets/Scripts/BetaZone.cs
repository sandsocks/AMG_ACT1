using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class BetaZone : MonoBehaviour
{
    public float deliksRadius = 3f;
    public float dropRadius = 1f;
    public float twerkRadius = 2f;
    public Transform betaZone;
    public Transform sigmaZone;
    public GameObject sigmaUI;
    private bool gameWon = false;
    
    void Update()
    {
        DeliksBa();
       // PanaloBa();
        SigmaWin();
    }

    void DeliksBa()
    {
       // foreach (Transform betaZone in betaZones)
    }

    //void PanaloBa()

    private void SigmaWin()
    {
        gameWon = true;
        if (sigmaUI != null)
        {
            sigmaUI.SetActive(true);
        }
        Debug.Log("Skibidi Toilet XD");
    }
}
