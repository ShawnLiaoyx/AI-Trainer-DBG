using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDrawer : MonoBehaviour
{
    public List<GameObject> _cardPrefabs;
    // Start is called before the first frame update
    List<GameObject> _spawnedCards = new List<GameObject>();
    System.Random rand;
    void Start()
    {
        rand = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnCards();
        }
    }

    void SpawnCards()
    {
        if (_spawnedCards.Count != 0)
        {
            foreach (var c in _spawnedCards)
            {
                if (c != null)
                {
                    Destroy(c);
                }
            }
        }
        _spawnedCards.Clear();

        for (int i = 0; i < 5; i++)
        {
            int index = rand.Next(0, _cardPrefabs.Count);
            GameObject card = Instantiate(_cardPrefabs[index], new Vector3((float)rand.NextDouble(), (float)rand.NextDouble(), (float)rand.NextDouble()), Quaternion.identity);
            _spawnedCards.Add(card);
        }
    }
}
