using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    [SerializeField]
    protected ItemObject itemObject;

    [SerializeField]
    protected int quantity = 1;

    protected Interactor interactor;

    public virtual void Interact()
    {
        Debug.Log("Interacting with " + transform.name);
    }
    public virtual void Interact(Interactor interactor)
    {
        Debug.Log("Interacting with " + transform.name + ". " + transform.name + ". (Interactor passed");
        this.interactor = interactor;
    }
}
