using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class BetaZone : MonoBehaviour
{
    [SerializeField] private float twerkRadius;
    [SerializeField] private float dropRadius;
    public GameObject sigmaUI;
    private bool gameWon = false;
    
    void Update()
    {

        SigmaWin();
    }

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
