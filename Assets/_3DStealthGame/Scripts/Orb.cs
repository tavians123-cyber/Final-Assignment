using UnityEngine;

public class Orb : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // how the orb spawns and moves 
        transform.Translate(new Vector3(0,0.1f,1) * Time.deltaTime * 8f);
        // when orb is far away enough, destroy it
        if(transform.position.z > 80f)
        {
            Destroy(this.gameObject);
        }
    }
}
