using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_night : MonoBehaviour
{
    //[SerializeField] 
    public string nextScene;

    void Start()
    {

    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if(collisionGameObject.name == "Player")
        {
            SceneManager.LoadScene(nextScene.ToString());
        }
    }
}
