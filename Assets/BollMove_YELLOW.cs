using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class BollMove_YELLOW : MonoBehaviour
{
    public GameObject score;
    private int ColideNum;
    private Vector3 InitialPosition;
    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -10f)
        {
            transform.position = InitialPosition;
            ColideNum -= 3;
        }
        if (transform.position.x <= -12f)
        {
            transform.position += new Vector3(1, 0, 0);
        }
        Rigidbody ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.AddForce(new Vector3(2f, -2f, 0));
        ScoreUpate();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stage"))
        {
            return;
        }
        else if (collision.gameObject.CompareTag("Annoying"))
        {
            ColideNum += 1;
        }
        else if (collision.gameObject.CompareTag("Service"))
        {
            ColideNum += 3;
        }
        Rigidbody ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.AddForce(new Vector3(-1f, 0.1f, 0) * 50f, ForceMode.Impulse);
        ScoreUpate();
    }

    void ScoreUpate()
    {
        TextMeshProUGUI textmp = score.GetComponent<TextMeshProUGUI>();
        textmp.SetText(ColideNum.ToString());
    }
}
