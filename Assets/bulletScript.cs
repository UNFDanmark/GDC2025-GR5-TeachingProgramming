using System;
using System.Collections;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    [SerializeField] float despawnTimer;
    
    IEnumerator Start()
    {
        yield return new WaitForSecondsRealtime(despawnTimer);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
