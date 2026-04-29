using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public float horziontalScreenSize;
    public float verticalScreenSize;
    // Start is called before the first frame update
    public void Start()
    {
        horziontalScreenSize = 10f;
        verticalScreenSize = 6.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }
}
