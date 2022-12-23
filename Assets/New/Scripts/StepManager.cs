using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class StepManager : MonoBehaviour
{


    #region variable

    RaycastHit hit;
    Ray ray;

    public int step;

    public GameObject glass1;
    public GameObject glass2;
    public GameObject glass2_1;
    public GameObject glass3;
    public GameObject glass4;
    public GameObject glass5;
    public GameObject glass6;
    public GameObject glass7;
    public GameObject glass8;
    public GameObject glass9;

    public GameObject button_mix_1;
    public GameObject button_mix_2;

    public GameObject indicator;
    public GameObject o_text;

    public GameObject water_glass3;

    public GameObject spoon1;
    public GameObject spoon2;
    public GameObject spoon3;
    public GameObject spoon4;
    public GameObject spoon4_1;

    public GameObject polimer_2;
    public GameObject polimer_3;

    public GameObject polimer_11;
    public GameObject polimer_12;


    public GameObject propant_4;




    public static bool key;
    public static int num;
    public static float timer;
    public static bool even;
    public static int step_count;




    #endregion


    void Start()
    {
        step_count = 1;// 1
        key = false;
        timer = 6;
        even = false;


    }

    void Update()
    {

        step = step_count;
        if (!InputManager.isPaused)
        {
            if (key)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    key = false;
                    Step();
                }
            }




            //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out hit, 3f))
            //{
            //    
            //        if (Input.GetKeyDown(KeyCode.Mouse0))
            //        {
            //            hit.collider.gameObject.SetActive(false);
            //
            //            step_count++;
            //        }
            //    
            //}




            #region Шаг 1
            if (step_count == 1)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            glass1.SetActive(false);

                            glass2_1.SetActive(true);

                            step_count++;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 2
            if (step_count == 2)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("spoon1") || hit.collider.gameObject.name.Equals("glass2_1") || hit.collider.gameObject.name.Equals("propant"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            spoon1.SetActive(false);

                            spoon2.SetActive(true);
                            spoon2.GetComponent<Animator>().Play("Spoon_put");


                            step_count = -1;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 3
            if (step_count == 3)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass2_1") || hit.collider.gameObject.name.Equals("propant_4") || hit.collider.gameObject.name.Equals("glass2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            glass3.SetActive(true);
                            glass2_1.SetActive(false);
                            propant_4.SetActive(false);


                            step_count++;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 4
            if (step_count == 4)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass3_1") || hit.collider.gameObject.name.Equals("hot") || hit.collider.gameObject.name.Equals("ice"))///--------------------------------------не сделал
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            water_glass3.SetActive(true);
                            water_glass3.GetComponent<Animator>().Play("water_pour");

                            step_count = -1;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 5
            if (step_count == 5)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass3_1") || hit.collider.gameObject.name.Equals("water"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            glass3.SetActive(false);
                            glass4.SetActive(true);

                            step_count = 6;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 6
            if (step_count == 6)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass4_1") || hit.collider.gameObject.name.Equals("water2") || hit.collider.gameObject.name.Equals("spoon1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            spoon1.SetActive(false);

                            spoon3.SetActive(true);
                            spoon3.GetComponent<Animator>().Play("Spoon3_mix");


                            step_count = -1;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 7
            if (step_count == 7)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass4_1") || hit.collider.gameObject.name.Equals("polimer"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            //spoon3.SetActive(false);
                            //spoon4.SetActive(true);
                            glass4.SetActive(false);
                            glass5.SetActive(true);

                            step_count++;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 8
            if (step_count == 8)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass5_1") || hit.collider.gameObject.name.Equals("polimer") || hit.collider.gameObject.name.Equals("button_mix_1") || hit.collider.gameObject.name.Equals("box_mixer"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            button_mix_1.SetActive(false);
                            button_mix_2.SetActive(true);
                            indicator.SetActive(true);

                            step_count++;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 9
            if (step_count == 9)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass6"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            glass6.SetActive(false);
                            glass7.SetActive(true);
                            o_text.SetActive(true);
                            //o_text.GetComponent<TextMesh>().text = "ХУЙ!!!!";

                            step_count++;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 10
            if (step_count == 10)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass7") || hit.collider.gameObject.name.Equals("spoon3") || hit.collider.gameObject.name.Equals("polimer"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            spoon4.SetActive(true);
                            spoon3.SetActive(false);
                            spoon4.GetComponent<Animator>().Play("Spoon4_put");

                            step_count = -1;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 11
            if (step_count == 11)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass7") || hit.collider.gameObject.name.Equals("polimer_3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            glass8.SetActive(true);
                            glass7.SetActive(false);
                            polimer_3.SetActive(false);
                            o_text.SetActive(false);

                            step_count++;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 12
            if (step_count == 12)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass5_1") || hit.collider.gameObject.name.Equals("polimer11") || hit.collider.gameObject.name.Equals("box_mixer") || hit.collider.gameObject.name.Equals("button_mix_2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            glass9.SetActive(true);
                            glass5.SetActive(false);
                            button_mix_2.SetActive(false);
                            button_mix_1.SetActive(true);
                            indicator.SetActive(false);

                            step_count++;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 13
            if (step_count == 13)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass9_1") || hit.collider.gameObject.name.Equals("polimer_5") || hit.collider.gameObject.name.Equals("glass8_1") || hit.collider.gameObject.name.Equals("polimer_4"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            glass8.GetComponent<Animator>().Play("glass8");

                            step_count = -1;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 14
            if (step_count == 14)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass9_1") || hit.collider.gameObject.name.Equals("polimer_6"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            glass5.SetActive(true);
                            glass9.SetActive(false); 
                            polimer_11.SetActive(false);
                            polimer_12.SetActive(true);
                            button_mix_1.SetActive(false);
                            button_mix_2.SetActive(true);
                            indicator.SetActive(true);

                            step_count++;
                        }
                    }
                }
            }
            #endregion

            #region Шаг 15
            if (step_count == 15)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("glass5_1") || hit.collider.gameObject.name.Equals("polimer12") || hit.collider.gameObject.name.Equals("button_mix_2") || hit.collider.gameObject.name.Equals("box_mixer"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            button_mix_2.SetActive(false);
                            button_mix_1.SetActive(true);
                            indicator.SetActive(false);
                            glass5.SetActive(false);
                            glass9.SetActive(true);

                            step_count++;
                        }
                    }
                }
            }
            #endregion

           




        }

    }






















    bool IsCouldUse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit, 15))
        {

            return true;
        }

        return false;
    }




    public void Step()
    {
        even = false;
        InputManager.isStopedController = false;
        //Time.timeScale = 1f;
        timer = 6;

        step_count = 7 + num;
    }

    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
