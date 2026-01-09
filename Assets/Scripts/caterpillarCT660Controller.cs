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
 *            Caterpillar CT660 Controller
 *      HoverCraft style to save resources, torque is unreal but heats cheap computers
 *         rotates loader and tranlates loads
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

    public float accelerationDecelerationRate = 0.5f;

    private AudioSource soundPlayer;

    private bool isMovingForward = false;
    private bool isMovingBackward = false;

    // Start is called before the first frame update
    void Start()
    {
        this.soundPlayer = GetComponent<AudioSource>();
    }

    private void playEngineSoundOn(){
        this.soundPlayer.clip = this.engineSoundClip;
        if (!this.soundPlayer.isPlaying) {
            this.soundPlayer.Play ();
        }
    }

    void increaseShiftGear(){
//automatic no clutch
    }

    void decreaseShiftGear(){

    }

    void accelerate(){
        this.forwardSpeed += this.accelerationDecelerationRate;
    }

    void moveForward(){
        this.playEngineSoundOn();
        this.transform.Translate(Vector3.forward * this.forwardSpeed * Time.deltaTime);
    }

    void moveBackward(){

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
        if(this.isMovingForward){
            this.rotateWheelsForward();
        }

        if(this.isMovingBackward){
            this.rotateWheelsBackward();
        }
    }

      void joystickControls(){
        if (Input.GetKey("up"))
        {
            this.moveForward();
            this.isMovingBackward = false;
            this.isMovingForward = true;
        }

        if (Input.GetKey("down"))
        {
            this.moveBackward();
             this.isMovingForward = false;
             this.isMovingBackward = true;
        }
         
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //this.doRestart();
        }
    }
}
