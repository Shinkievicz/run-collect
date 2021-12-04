using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderRoulette : MonoBehaviour
{
    public Text Scores;
    public float x;
    public float dumpTime = 30f;
    private float _speed;
    public GameObject imageCont;
    public Transform[] children;
    public List<GameObject> chil = new List<GameObject>();
    public float[] widths;
    public float width;

    public Slider slider;
    private float lid = 100;
    bool turnSlider = false;
    bool turnOnOff = true;
    void Start()
    {
        int childCount = imageCont.transform.childCount;
        Debug.Log(childCount+"KKK");

        children = imageCont.GetComponentsInChildren<Transform>();
        widths = new float[children.Length];

        //   for (int i = 0; i < childCount; i++)
        //   {
        //       imageCont. 
        //   }
        foreach (Transform child in imageCont.GetComponent<Transform>());
        {
           // if (imageCont != transform[0])
            {
                chil.Add(imageCont.gameObject);
                //child is your child transform
            }
        }

        for (int i = 1; i < children.Length; i++)
        {
            RectTransform rt = children[i].GetComponent<RectTransform>();
            widths[i] = rt.rect.width;
          //  Debug.Log(width);
        }
        for (int i = 1; i < widths.Length; i++)
        {
            widths[0] = widths[0] + widths[i];
        }


        _speed = x * 1 / dumpTime;
        slider.maxValue = 100;
        slider.minValue = 0;
    }
    void Update()
    {
        if (turnOnOff == true)
        {
            if (turnSlider == false)
            {
                x = Mathf.MoveTowards(x, 0, _speed * Time.deltaTime);
                slider.value = x;
                //   Debug.Log(x);
                if (x == 0)
                {
                    turnSlider = true;
                }

            }
            else if (turnSlider == true)
            {
                x = Mathf.MoveTowards(x, 100, _speed * Time.deltaTime);
                slider.value = x;
                // Debug.Log(x);
                if (x == 100)
                {
                    turnSlider = false;
                }
            }
        }
        //  if (lid <= 0) { lid = 0; };
        //  if (slider.value >= 10) { lid = 100; };
        //  slider.value = Mathf.Lerp(slider.value, lid, Time.deltaTime);
        // num.text = slider.value.ToString();

        //   if (slider.value == 0)
        //   {
        //       turn = false;
        //   }
        //   else if (slider.value == 100)
        //   {
        //       turn = true;
        //   }
        //   if (turn == false)
        //   {
        //       slider.value = Mathf.Lerp(slider.value, 100, 1 - Mathf.Pow(1 - speed * 3.0f, Time.deltaTime * 60));
        //   }
        //   else if (turn == true)
        //   {
        //       slider.value = Mathf.Lerp(slider.value, 0, 1 - Mathf.Pow(1 - speed * 3.0f, Time.deltaTime * 60));
        //   }
        //
        //       slider.value = Mathf.Lerp(slider.value, 100, Time.deltaTime);
        //     // slider.value = 100;
        //   }
        //  else if (slider.value >= 2)
        //   {
        //
        //       slider.value = Mathf.Lerp(slider.value, 0, Time.deltaTime);
        //       // slider.value = 100;
        //   }
        //   //   if (slider.value >= 90 )
        //   //   {
        //        slider.value = Mathf.Lerp(slider.value, 0, Time.deltaTime);
        //   }
    }

    public void ClickMe()
    {
        for (int i = 1; i < widths.Length; i++)
        {
            width = width + widths[i] / widths[0] * 100;
            Debug.Log(width);
            if (slider.value <= width)// || slider.value >= widths[i] / widths[0] * 100) //slider.value <= width || 
            {
                Debug.Log(width);
                Debug.Log(width + "!!!"+"SUCCESS");
              //  string S = children[i].GetChild(1).GetComponent<TextMesh>().text;
               // Debug.Log(S + "^^^" + "SUCCESS");
                break;
            }
            else
            {

            //    Debug.Log("HER" + "!!!");
            }

           //  Debug.Log(width + "***");
        }


        string g = Scores.text;
        turnOnOff = false;
     //   Debug.Log(slider.value + "&&&" + g);

    }
}