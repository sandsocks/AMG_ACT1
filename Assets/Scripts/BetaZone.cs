using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class DangerZone : MonoBehaviour
{
    public float dangerRadius = 1f;
    public float winRadius = 1f;
    public float shakeRadius = 2f;
    public Transform dangerZones;
    public Transform winZone;
    public GameObject winnerUI;
    private bool gameWon = false;
    
    void Update()
    {
        DeliksBa();
        PanaloBa();
        Winner();
    }

    void DeliksBa()
    {
       foreach (Transform dangerZone in dangerZones)
       {
            Vector3 direction = dangerZones.position - transform.position;
            float distance = direction.magnitude;

            if (distance < dangerRadius)
            {
                StartCoroutine(HandleDangerZone(dangerZone));
                return;
            }
            else if (distance < shakeRadius)
            {
                ShakeItem(dangerZone);
            }
       }
    }

    void PanaloBa()
    {
        Vector3 direction = winZone.position - transform.position;
        float distance = direction.magnitude;

        if (distance < winRadius)
            {
                Winner();
            }
    }

    void ShakeItem(Transform dangerZone)
    {
        Vector3 origPos = dangerZone.position;
        dangerZone.position = origPos + new Vector3(Random.Range(-0.05f, 0.05f), Random.Range(-0.05f, 0.05f), 0);
    }

    private System.Collections.IEnumerator HandleDangerZone(Transform dangerZone)
    {
        // Shake and change color for effect
        Renderer renderer = dangerZone.GetComponent<Renderer>();
        Color originalColor = renderer.material.color;
        renderer.material.color = Color.yellow;

        Vector3 originalPosition = dangerZone.position;
        for (int i = 0; i < 10; i++)
        {
            dangerZone.position = originalPosition + new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 0);
            yield return new WaitForSeconds(0.05f);
        }

        // Reset position and color, then restart the scene
        dangerZone.position = originalPosition;
        renderer.material.color = originalColor;

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    private void Winner()
    {
        gameWon = true;
        if (winnerUI != null)
        {
            winnerUI.SetActive(true);
        }
        Debug.Log("Winner!");
    }
}
