using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallChange : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public void Click()
    {
        int random = Random.Range(0, 100);

        text.text = random + "%".ToString();
    }
}
