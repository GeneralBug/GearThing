using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used for the UI buttons to tell stuff what gear to place
public class ObjectSelector : MonoBehaviour
{
    [SerializeField]
    private GameObject objectType;
    private PlacementController con;

    private void Start()
    {
        con = FindObjectOfType<PlacementController>();
    }
    public void OnButton()
    {
        con.SetObjectToPlace(objectType);
    }
}
