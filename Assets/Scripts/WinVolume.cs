using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinVolume : MonoBehaviour
{

    [SerializeField]
    private string winText = "You Win!";
    [SerializeField]
    private AudioSource winSoundPrefab;
    private UIController uIController;

    private void Awake()
    {
        uIController = FindObjectOfType<UIController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player entered trigger");
        other.gameObject.SetActive(false);

        if(uIController != null)
        {
            uIController.ShowWinText(winText);
        }

        if(winSoundPrefab != null) 
        {
            SoundPlayer.Instance.PlaySFX(winSoundPrefab, transform.position);
        }
        
    }

    // detect if player entered this trigger volume
    // if so, tell the UIController to display win text
    // also, play some sound effect
}
