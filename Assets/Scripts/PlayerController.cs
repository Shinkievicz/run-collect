using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Transform pla;
    public GameObject grob;
    public int countOn= 0;
    public int scores = 0;
    public Text text;
    internal float speed = 8f;
    float arrowSpeed = 500f;
    public float vertical = 50;
    float curPos;
    private Rigidbody rb;
    private bool cliked;
    float startMousePos;
    private Vector3 moveVector;
    bool _isMouseDown;
    bool _isAroow;
    [SerializeField] private float _speed = 10f;
    float delta;
    public GameObject arrow;
    public List<GameObject> Children;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

         foreach (Transform child in pla)
         {
             if (child.tag == "Ally")
             {
             //   Debug.Log("Enemy");
                 Children.Add(child.gameObject);
             }
         }

        for (int i = 1; i < Children.Count; i++)
        {
            Children[i].SetActive(false);
        }

        for (int i = 0; i < Children.Count; i++)
        {
            if (Children[i].activeSelf)
            {
                countOn = countOn + 1;
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
         MoveForward();
        // MoveRightLeft();
        // Mover();
        MouseSwipeControl();
      //  Shoot();
    }
    void Shoot()
    {
        var pos = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
        //if (Input.GetKeyDown(KeyCode.Space))
        //
        if (_isAroow == true)
            
        {
            Instantiate(arrow, pos, Quaternion.identity);
         //   Debug.Log("shoot");
            arrow.GetComponent<Rigidbody>().AddForce(transform.forward * arrowSpeed); // adjusted speed
            
        }
        _isAroow = false;

    }

    void MoveForward()
    {

      //  rb.velocity = (transform.forward * vertical) * speed * Time.deltaTime;
        transform.position += Vector3.forward * Time.deltaTime * speed;
    }

    private void MouseSwipeControl()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _isAroow = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            startMousePos = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            _isMouseDown = true;
            curPos = Input.mousePosition.x;
            delta = curPos - startMousePos;
           // Debug.Log(delta);
        }
      else
      {
          _isMouseDown = false;
           
      }
    
      if (!_isMouseDown)
      {
          moveVector.x = 0;
      }
    
      if (Input.GetMouseButton(0))
      {
          _isMouseDown = true;
          if (delta < 0)
          {
                transform.position = transform.position + new Vector3(delta  * Time.deltaTime / 100, 0, 0);
          }
          else if (delta > 0)
          {
                transform.position = transform.position - new Vector3(-delta * Time.deltaTime / 100, 0, 0);
            }
      }
    }
    public void SetForfce()
    {
        text.text = scores.ToString();

    }

    private void LateUpdate()
    {
        text.text = scores.ToString();
    }

    public void TurnOffFromEnemy(int num)
    {

        for (int i = countOn; i > 0; i--)
        {

            if (Children[i].activeSelf)
            {

                Children[i].SetActive(false);
                Instantiate(grob, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
                Instantiate(grob, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
                num--;
                num--;
                if (num == 0)
                { break; }
            }
        }
    }
    public void TurnOnAlly()
    {
        ///pla.transform.position = gameObject.transform.position;

        for (int i = 0; i < Children.Count; i++)
        {
            if (Children[i].activeSelf && !Children[i+1].activeSelf)
            {
                Children[i+1].SetActive(true);
                Children[i+1].transform.position = gameObject.transform.position;
                break;
            }
                //Children[i].SetActive(false);
        }
        // pla.SetActive(true);
    }
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
  //   if (collision.gameObject.tag == "Ally")
  //   {
  //
  //       //Destroy(gameObject, 0.2f);
  //       Debug.Log("BDieng");
  //   }
    }

}

