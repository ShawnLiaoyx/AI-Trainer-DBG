using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AIBrain : MonoBehaviour
{
    public enum FeatureTypes
    {
        RED = 0,
        GREEN = 1,
        BLUE = 2,
    }

    List<DataSetCard> _cards;
    List<int> _featureValues;

    public TestUIController _scores { set; get; }

    public void AddCard(DataSetCard card) 
    {
        _cards.Add(card);
        foreach (var c in card._features)
        {
            _featureValues[(int)c.featureType] += c.featureValue;
        }
        _scores.UpdateScores(_featureValues);
    }

    public void RemoveCard(DataSetCard card)
    {
        if (_cards.Contains(card))
        {
            _cards.Remove(card);
        }
    }
    private void Awake()
    {
        _featureValues = new List<int>();
        foreach (var i in Enum.GetValues(typeof(FeatureTypes)))
        {
            _featureValues.Add(0);
        }
        _cards = new List<DataSetCard>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
