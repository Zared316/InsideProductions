using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Background")
        {
            Destroy(gameObject);
        }
    }
}
