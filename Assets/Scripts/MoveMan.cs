using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MoveMan : MonoBehaviour
{
    public float RotateSpeed = 30f;
    public float Rotate = 4f;
    // private Rigidbody rb;
    AudioSource tslil;
    public Text Kituv;
    public int count = 0;
    void Start()
    {
        tslil = GetComponent<AudioSource>();
        Time.timeScale = 1;
        count = 0;
        //SetCountText();
        Kituv.text = "Eat The Bunnies";
        // rb = GetComponent<Rigidbody>();
    }
    /*void FixedUpdate()
    {
        float h = Input.GetAxis("Horizonal") * 5;
        float v = Input.GetAxis("Vertical") * 5;
        Vector3 vel = rb.velocity;
        vel.x = h;
        vel.z = v;
        rb.velocity = vel;
    }*/
    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up);
        }*/
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.right);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.left);
            //transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.position += Vector3.forward * Rotate * Time.deltaTime;
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.back);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position += Vector3.back * Rotate * Time.deltaTime;
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward);
        }
        StartAgain();
    }
    void OnCollisionEnter(Collision hitnagshut)
    {
        switch (hitnagshut.gameObject.tag)
        {
            case "MovingCubes":
                {
                    print("Player Lost!!");
                    tslil.Play();
                    Time.timeScale = 0;
                    Kituv.text = "Space for Retry";
                    break;
                }
            case "Bunny":
                {
                    Destroy(hitnagshut.gameObject);
                    count++;
                    Kituv.text = "Score:" + count;
                    break;
                }
            default:
                {
                    break;
                }
        }
        if (count == 5)
        {
            Kituv.text = "You Won!!!";
            SceneManager.LoadScene(0);
        }
    }
    void StartAgain()
    {
        if (Input.GetKey(KeyCode.Space) && Time.timeScale == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
