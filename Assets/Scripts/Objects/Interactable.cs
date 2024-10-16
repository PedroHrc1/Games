using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Interactable : MonoBehaviour
{

    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public InteractiveNotification InteractiveNotificationButton;
    public string origem;
    void Start()
    {
    }

    void Update()
    {
        if(isInRange && Input.GetKeyDown(interactKey)){
            interactAction.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            isInRange = true;
            InteractiveNotificationButton.SetInteractable(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            isInRange = false;
            InteractiveNotificationButton.SetInteractable(false);

        }
    }
}
