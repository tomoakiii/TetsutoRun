using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.UI;
using TMPro;

public class BollMove_RED : MonoBehaviour
{
    public GameObject score;
    private Vector3 InitialPosition;
    private int ColideNum = 0;
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
        TextMeshProUGUI textmp = score.GetComponent<TextMeshProUGUI>();
        textmp.SetText("RED : " + ColideNum.ToString());

    }
}
