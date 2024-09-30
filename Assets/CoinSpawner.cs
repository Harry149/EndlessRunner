using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    public GameObject coinPrefab;

    public Vector2 coinOffset = new Vector2 (0, 1);
    // Start is called before the first frame update
    void Start()
    {
        spawncoin();
    }

    // Update is called once per frame
    void spawncoin()
    {
        Vector3 coinPosition = transform.position + (Vector3)coinOffset;

        Instantiate(coinPrefab, coinPosition, Quaternion.identity);
    }
}
