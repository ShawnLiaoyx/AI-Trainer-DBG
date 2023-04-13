using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DataSetCard : MonoBehaviour
{
    [Serializable]
    public struct Feature
    {
        public AIBrain.FeatureTypes featureType;
        public int featureValue;
    
    }

    [SerializeField]
    public List<Feature> _features = new List<Feature>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("AIBrain"))
        {
            collision.GetComponent<AIBrain>().AddCard(this);
            Destroy(gameObject);
        }
    }
}
