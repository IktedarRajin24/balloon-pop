using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI instructions;
    // Start is called before the first frame update
    void Start()
    {
        instructions.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= 3f)
        {
            instructions.enabled = false;
        }
    }
}
