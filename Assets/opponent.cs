
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class opponent : MonoBehaviour
{
    public int health = 100;
    public TMP_Text sceneText;
    public int scene;
    public TMP_Text scoreText;
    public float scoreAmount;
    public float scoreDecreasedPerSecond;


    private void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
        displayScene();

        scoreAmount = 1000f;
        scoreDecreasedPerSecond = 50f;
    }
    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
            int nextSceneIndex = scene + 1;

            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                Debug.LogError("Next scene index is out of bounds! Check Build Settings.");
            }
        }

    }

    void Die()
    {
        Destroy(gameObject);
    }
    private void displayScene()
    {
        sceneText.SetText("level: " + (scene));

    }

    private void Update()
    {
        scoreText.text = (int)scoreAmount + " score";
        scoreAmount -= scoreDecreasedPerSecond * Time.deltaTime;
    }
}