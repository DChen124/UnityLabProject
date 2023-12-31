using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fire : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    
    public float speed = 20f;
    public int damage = 10;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        opponent enemy = hitInfo.GetComponent<opponent>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
        
    }
}
