using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    private int numberofCoins = 0;
    public Text coins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = "Coins: " + numberofCoins;
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")//if the player touches the coin then the counter will go up by 1
        {
            numberofCoins += 1;
            other.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Enemies enemy = collision.collider.GetComponent<Enemies>();

        if (enemy != null)
        {
            
            foreach (ContactPoint point in collision.contacts)
            {
                if (point.normal.y >= .18f)//if the player is higher than the enemy the enemy will get killed
                {
                    enemy.Hurt();
                    Debug.Log("Enemy Killed");
                }
                else//if the player is not above the enemy the game will restart
                {
                    SceneManager.LoadScene("SampleScene");
                    Debug.Log("Ded");
                }
            }            
        }

        
    }
}
