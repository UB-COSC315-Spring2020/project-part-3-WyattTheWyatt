using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questionblock : MonoBehaviour
{
    public Transform coinSpawnPoint;
    public GameObject coinSpawn;
    public Text coins;
    public int numberofCoins = 0;

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
        if(other.gameObject.tag == "Player")//if the player touches the bottom of the question block a coin will apear
        {
            Instantiate(coinSpawn, coinSpawnPoint.position, coinSpawnPoint.rotation);
            numberofCoins += 1;
        }
    }


}
