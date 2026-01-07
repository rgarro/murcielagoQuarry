using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                          .------.
 *                         :|||"""`.`.
 *                         :|||     7.`.
 *      .===+===+===+===+===||`----L7'-`7`---.._
 *      []                  || ==       |       """-.
 *      []...._____.........||........../ _____ ____|
 *     c\____/,---.\_       ||_________/ /,---.\_  _/
 *      /_,-/ ,-. \ `._____|__________||/ ,-. \ \_[
 *          /\ `-' /                    /\ `-' /
 *            `---'                       `---'         
 * Caterpillar CT660 Controller
 * 
 * 
 *
 *
 * @author Rolando<rgarro@gmail.com>
 */
public class caterpillarCT660Controller : MonoBehaviour
{

    public GameObject leftFrontWheel;
    public GameObject rightFrontWheel;
    public GameObject leftCenterWheel;
    public GameObject rightCenterWheel;
    public GameObject leftRearWheel;
    public GameObject rightRearWheel;

    public float anglesToTurn = 3.00f;

    public AudioClip engineSoundClip;
    public float forwardSpeed = 2.00f;
    public GameObject caJon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void increaseShiftGear(){
//automatic no clutch
    }

    void decreaseShiftGear(){

    }

    void accelerate(){

    }

    void brakeTheTruck(){
         
    }

    void rotateWheelsForward(){

    }

    void rotateWheelsBackward(){

    }

    void voltearCajon(){

    }

    void recogerCajon(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void joystickControls(){
        if (Input.GetKey("up"))
        {
            this.accelerate();
            rotateWheelsForward()
        }

        if (Input.GetKey("down"))
        {
            
        }
         
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //this.doRestart();
        }
    }
}
