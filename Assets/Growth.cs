using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class EnlargeAndDestroy : MonoBehaviour
{
    public float enlargementSpeed = 0.5f; // Adjust the speed of enlargement
    public float destroyTime = 5f; // Adjust the time after which the object will be destroyed

    
    private void Start()
    {
        // You can adjust the initial scale of the object if needed
        // transform.localScale = new Vector3(1f, 1f, 1f);
    }

    private void Update()
    {
        // Enlarge the object over time
        transform.localScale += new Vector3(enlargementSpeed * Time.deltaTime, enlargementSpeed * Time.deltaTime, enlargementSpeed * Time.deltaTime);

    
        
        // Destroy the object after a certain amount of time
        destroyTime -= Time.deltaTime;
        if (destroyTime <= 0f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
       
    }
    
}
