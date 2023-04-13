using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;

public class TestUIController : MonoBehaviour
{
    AIBrain _aIBrain;
    Label _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        _aIBrain = GameObject.FindGameObjectWithTag("AIBrain").GetComponent<AIBrain>();
        _aIBrain._scores = this;
        _scoreText = GetComponent<UIDocument>().rootVisualElement.Q<Label>("AIScore");
        _scoreText.text = "";
        foreach (var s in Enum.GetNames(typeof(AIBrain.FeatureTypes)))
        {
            _scoreText.text += s + ": 0\n";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScores(in List<int> scoreValues)
    {
        _scoreText.text = "";
        foreach (var s in Enum.GetNames(typeof(AIBrain.FeatureTypes)))
        {
            _scoreText.text += s + ": " + scoreValues[(int)Enum.Parse(typeof(AIBrain.FeatureTypes), s)] +"\n";
        }
    }
}
