using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<Renderer>().isVisible)
        {
            int count = GameObject.FindGameObjectsWithTag("Item").Length;
            Debug.Log(count);

            Destroy(this.gameObject);
        }
    }
}
