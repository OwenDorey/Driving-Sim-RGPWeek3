using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextRace : MonoBehaviour
{
    public GameObject winScreen;
    private void OnTriggerEnter3D(Collider other)
    {
        if (other.tag =="Player")
        {
            winScreen.SetActive(true);
            Cursor.visible = true;
        }

    }

   
}
