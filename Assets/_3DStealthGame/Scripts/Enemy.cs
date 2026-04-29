using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject disappearPrefab;
    bool m_IsPlayerCaught; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
        {
            hit.GetComponent<GameEnding>().CaughtPlayer();
            m_IsPlayerCaught = true;
        }
        else if (hit.tag == "Orb")
        {
            Destroy(this.gameObject);
            Instantiate(disappearPrefab, transform.position, Quaternion.identity);
        }
    }
}
