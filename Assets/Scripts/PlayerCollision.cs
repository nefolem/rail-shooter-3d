using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] GameObject playerExplosion;
    [SerializeField] bool godmode;

    private void Start()
    {
        godmode = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            godmode = !godmode;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!godmode)
        {
            if (!other.gameObject.CompareTag("Laser") && !other.gameObject.CompareTag("Spawner"))
            {
                playerExplosion.SetActive(true);
                Invoke("ReloadLevel", 1.5f);
                gameObject.GetComponent<PlayerMovement>().enabled = false;
                //gameObject.SetActive(false);
                transform.Find("Body").gameObject.SetActive(false);
            }
        }
        
    }

    private void ReloadLevel()    {
        
        SceneManager.LoadScene(0);//SceneManager.GetActiveScene().name
    }
}
