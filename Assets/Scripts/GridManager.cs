using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// based on https://unity3d.college/2017/10/08/simple-unity3d-snap-grid-system/
public class GridManager : MonoBehaviour
{ 
    [SerializeField]
    [Range(1f, 20f)]
    private float scale = 1f;
    [SerializeField]
    [Range(1, 100)]
    private int size = 40;

    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;

        int xCount = Mathf.RoundToInt(position.x / scale);
        int yCount = Mathf.RoundToInt(position.y / scale);
        int zCount = Mathf.RoundToInt(position.z / scale);

        Vector3 result = new Vector3(
            (float)xCount * scale,
            (float)yCount * scale,
            (float)zCount * scale);

        result += transform.position;

        return result;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        for (float x = 0; x < size; x += scale)
        {
            for (float z = 0; z < size; z += scale)
            {
                var point = GetNearestPointOnGrid(new Vector3(x, 0f, z));
                Gizmos.DrawSphere(point, 0.1f);
            }

        }
    }
}