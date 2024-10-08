using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{

    public float fallThreshold = -10f;
    private DeathManager deathManager;
    // Start is called before the first frame update
    void Start()
    {
        deathManager = FindObjectOfType<DeathManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            deathManager.ShowDeathScreen();
        }
    }
}
