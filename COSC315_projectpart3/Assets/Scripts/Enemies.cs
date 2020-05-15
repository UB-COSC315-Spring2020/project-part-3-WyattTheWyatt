using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemies : MonoBehaviour
{
    Vector3 direction;
    public float enemySpeed = .05f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(-1, 0, 0);
        transform.Translate(direction * enemySpeed);
        
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Wall")
        {
            direction.x += 2;
            Debug.Log("Enemy hit wall");
        }

    }
    //Enemy death
    public void Hurt()
    {

        Destroy(this.gameObject);

    }

}
