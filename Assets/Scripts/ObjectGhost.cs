using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls the pre-placement ghost
public class ObjectGhost : MonoBehaviour
{
    private GameObject ghost;
    private GridManager grid;
    private RaycastHit hitInfo;
    private void Start()
    {
        ghost = new GameObject();
        grid = FindObjectOfType<GridManager>();
    }
    public void Refresh(GameObject objectType)
    {
        ghost = Instantiate(objectType);
        Debug.Log("setting ghost to object type " + objectType.name);
        //TODO: make it transparent or something
    }

    public void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (Input.GetMouseButtonDown(0))
            {
                //TODO: object placement, though not nice to do it in this script
            }
            else
            {
                MoveGhost(hitInfo.point);
            }
        }
    }

    private void MoveGhost(Vector3 clickPoint)
    {
        //TODO: player can rotate gear with mouse wheel
        Vector3 newPos = grid.GetNearestPointOnGrid(clickPoint);
        ghost.transform.position = newPos;
    }
}
