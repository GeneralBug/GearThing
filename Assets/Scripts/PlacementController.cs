using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls selection of object to be placed
public class PlacementController : MonoBehaviour
{
    [SerializeField]
    private ObjectGhost ghost;
    [SerializeField]
    private ObjectPlacer placer;

    public void SetObjectToPlace(GameObject objectType)
    {
        ghost.Refresh(objectType);

    }
}
