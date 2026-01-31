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
 *            Caterpillar CT660 Controller with cabin view , follow and front cameras
 *      Torque push style engine , so it has the same risk of overturn on difficult surface
 * or wheel colliders turning
 *         rotates loader and tranlates loads
 * inspired from An ECU from 1995 with 32 kb from the land of OBDI 
 *
 *
 * @author Rolando<rgarro@gmail.com> <https://emptyart.github.io>
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
    //rango de fabrica no configurable por que es limitable, grabar los key presses del tractor y hacer dibujos a espalda de los jugadores vale $15000USD por que sale una prueba sicologica dificil de lograr ...
    private float minForwardSpeed = 1.0f;
    private float maxForwardSpeed = 5.0f;


    private AudioSource soundPlayer;

    private bool isMovingForward = false;
    private bool isMovingBackward = false;
    private bool isBrake = false;

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
//dejalo automatico con indicador de shift qhe cambia en aceleracion
    }

    void accelerate(){
        //if(this.minForwardSpeed <= this.forwardSpeed <= this.maxForwardSpeed){
        if(!Mathf.Approximately(this.minForwardSpeed,this.forwardSpeed) && !Mathf.Approximately(this.maxForwardSpeed,this.forwardSpeed)){
            this.forwardSpeed += this.accelerationDecelerationRate;
        }else{
            //flasyText dash warning con la pepsi negra de volver al futuro , al mismo tiempo que pase el centro de reciclaje san miguel
        }
    }

    void deccelerate(){
        //if(this.minForwardSpeed <= this.forwardSpeed <= this.maxForwardSpeed){
        if(!Mathf.Approximately(this.minForwardSpeed,this.forwardSpeed) && !Mathf.Approximately(this.maxForwardSpeed,this.forwardSpeed)){
            this.forwardSpeed -= this.accelerationDecelerationRate;
        }else{
            //flasyText dash warning con la pepsi negra de volver al futuro , al mismo tiempo que pase el centro de reciclaje san miguel
        }
    }

    void moveForward(){
        this.playEngineSoundOn();
        if(!this.isBrake){
            this.rotateWheelsForward();
            this.transform.Translate(Vector3.forward * this.forwardSpeed * Time.deltaTime);
        }
    }

    void moveBackward(){
        if(!this.isBrake){
            this.transform.Translate(-Vector3.forward * this.forwardSpeed * Time.deltaTime);
        }
    }

    void brakeTheTruck(){
         this.isBrake = true;
    }

    void releaseTheBrake(){
         this.isBrake = true;
    }

    void wheelDrive(){
        Vector3 rotationDirection = Vector3.up;//wheeldrive rotation
    }

    void rotateWheelsForward(){
        Vector3 rotationDirection = Vector3.forward;
        this.leftFrontWheel.transform.Rotate(rotationDirection * this.forwardSpeed * Time.deltaTime);
        this.rightFrontWheel.transform.Rotate(rotationDirection * this.forwardSpeed * Time.deltaTime);
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
         if (Input.GetKey("a")){
            this.accelerate();
         }

          if (Input.GetKey("s")){
            this.deccelerate();
         }

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
         
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //this.doRestart();
            this.brakeTheTruck();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //this.doRestart();
            this.releaseTheBrake();
        }
    }
}
