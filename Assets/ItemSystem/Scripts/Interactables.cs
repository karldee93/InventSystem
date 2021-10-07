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
}
